"""
Batch fix sprite .asset files:
1. Generate .meta files for exported PNGs (with unique GUIDs)
2. Map sprite m_Name -> PNG GUID
3. Update .asset files: set texture reference, clear atlas tags
"""
import os
import re
import uuid
import hashlib

SPRITE_ASSET_DIR = r"I:\client\myclaudeproj\CatProject\Assets\Sprite"
PNG_DIR = r"I:\client\myclaudeproj\CatProject\Assets\Textures\Sprite"

META_TEMPLATE = """fileFormatVersion: 2
guid: {guid}
TextureImporter:
  internalIDToNameTable: []
  externalObjects: {{}}
  serializedVersion: 13
  mipmaps:
    mipMapMode: 0
    enableMipMap: 0
    sRGBTexture: 1
    linearTexture: 0
    fadeOut: 0
    borderMipMap: 0
    mipMapsPreserveCoverage: 0
    alphaTestReferenceValue: 0.5
    mipMapFadeDistanceStart: 1
    mipMapFadeDistanceEnd: 3
  bumpmap:
    convertToNormalMap: 0
    externalNormalMap: 0
    heightScale: 0.25
    normalMapFilter: 0
    flipGreenChannel: 0
  isReadable: 1
  streamingMipmaps: 0
  streamingMipmapsPriority: 0
  vTOnly: 0
  ignoreMipmapLimit: 0
  grayScaleToAlpha: 0
  generateCubemap: 6
  cubemapConvolution: 0
  seamlessCubemap: 0
  textureFormat: 1
  maxTextureSize: 2048
  textureSettings:
    serializedVersion: 2
    filterMode: 1
    aniso: 1
    mipBias: 0
    wrapU: 1
    wrapV: 1
    wrapW: 1
  nPOTScale: 0
  lightmap: 0
  compressionQuality: 50
  spriteMode: 1
  spriteExtrude: 1
  spriteMeshType: 1
  alignment: 0
  spritePivot: {{x: 0.5, y: 0.5}}
  spritePixelsToUnits: 100
  spriteBorder: {{x: 0, y: 0, z: 0, w: 0}}
  spriteGenerateFallbackPhysicsShape: 1
  alphaUsage: 1
  alphaIsTransparency: 1
  spriteTessellationDetail: -1
  textureType: 8
  textureShape: 1
  singleChannelComponent: 0
  flipbookRows: 1
  flipbookColumns: 1
  maxTextureSizeSet: 0
  compressionQualitySet: 0
  textureFormatSet: 0
  ignorePngGamma: 0
  applyGammaDecoding: 0
  swizzle: 50462976
  cookieLightType: 0
  platformSettings:
  - serializedVersion: 4
    buildTarget: DefaultTexturePlatform
    maxTextureSize: 2048
    resizeAlgorithm: 0
    textureFormat: -1
    textureCompression: 1
    compressionQuality: 50
    crunchedCompression: 0
    allowsAlphaSplitting: 0
    overridden: 0
    ignorePlatformSupport: 0
    androidETC2FallbackOverride: 0
    forceMaximumCompressionQuality_BC6H_BC7: 0
  spriteSheet:
    serializedVersion: 2
    sprites: []
    outline: []
    customData:
    physicsShape: []
    bones: []
    spriteID:
    internalID: 0
    vertices: []
    indices:
    edges: []
    weights: []
    secondaryTextures: []
    spriteCustomMetadata:
      entries: []
    nameFileIdTable: {{}}
  mipmapLimitGroupName:
  pSDRemoveMatte: 0
  userData:
  assetBundleName:
  assetBundleVariant:
"""


def generate_guid(name):
    """Generate a deterministic GUID from name (so re-running gives same result)"""
    h = hashlib.md5(name.encode()).hexdigest()
    return h


def step1_generate_meta_files():
    """Generate .meta files for all PNGs that don't have one"""
    png_files = [f for f in os.listdir(PNG_DIR) if f.endswith('.png')]
    created = 0
    skipped = 0
    guid_map = {}  # name (without .png) -> guid

    for png in png_files:
        meta_path = os.path.join(PNG_DIR, png + ".meta")
        name = png[:-4]  # strip .png
        guid = generate_guid("sprite_tex_" + name)

        if not os.path.exists(meta_path):
            with open(meta_path, 'w', encoding='utf-8', newline='\n') as f:
                f.write(META_TEMPLATE.format(guid=guid))
            created += 1
        else:
            # Read existing GUID
            with open(meta_path, 'r', encoding='utf-8') as f:
                content = f.read()
            m = re.search(r'guid:\s*([0-9a-f]+)', content)
            if m:
                guid = m.group(1)
            skipped += 1

        guid_map[name] = guid

    print(f"[Step 1] Meta files: created={created}, skipped={skipped}, total PNGs={len(png_files)}")
    return guid_map


def step2_fix_asset_files(guid_map):
    """Fix sprite .asset files to reference PNG textures"""
    asset_files = [f for f in os.listdir(SPRITE_ASSET_DIR) if f.endswith('.asset')]
    fixed = 0
    no_match = 0
    already_ok = 0
    errors = 0

    for asset_file in asset_files:
        asset_path = os.path.join(SPRITE_ASSET_DIR, asset_file)
        try:
            with open(asset_path, 'r', encoding='utf-8') as f:
                content = f.read()

            # Skip if texture is already set (not fileID: 0)
            if 'texture: {fileID: 2800000' in content:
                already_ok += 1
                continue

            # Extract m_Name
            m = re.search(r'm_Name:\s*(.+)', content)
            if not m:
                errors += 1
                continue
            sprite_name = m.group(1).strip()

            # Find matching PNG
            if sprite_name not in guid_map:
                no_match += 1
                continue

            guid = guid_map[sprite_name]

            # 1. Replace texture: {fileID: 0} in m_RD section (first occurrence)
            # We need to replace only the FIRST texture: {fileID: 0} (in m_RD, not m_AtlasRD)
            content = content.replace(
                '    texture: {fileID: 0}',
                '    texture: {fileID: 2800000, guid: ' + guid + ', type: 3}',
                1  # only first occurrence
            )

            # 2. Clear m_AtlasTags
            content = re.sub(
                r'm_AtlasTags:\n(  - .+\n)+',
                'm_AtlasTags: []\n',
                content
            )

            with open(asset_path, 'w', encoding='utf-8', newline='\n') as f:
                f.write(content)
            fixed += 1

        except Exception as e:
            errors += 1
            if errors <= 5:
                print(f"  Error processing {asset_file}: {e}")

    print(f"[Step 2] Assets: fixed={fixed}, no_match={no_match}, already_ok={already_ok}, errors={errors}")
    print(f"  Total asset files processed: {len(asset_files)}")


if __name__ == '__main__':
    print("=== Sprite Fix Script ===")
    print(f"PNG dir: {PNG_DIR}")
    print(f"Asset dir: {SPRITE_ASSET_DIR}")

    # Step 1
    guid_map = step1_generate_meta_files()
    print(f"  GUID map size: {len(guid_map)}")

    # Step 2
    step2_fix_asset_files(guid_map)

    print("=== Done ===")
