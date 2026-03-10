using System;

// JSON data models for Balancy cached config files
[Serializable]
public class BalancySpriteRef
{
	public string id;
	public int type;
}

[Serializable]
public class BalancySkinEntry
{
	public string unnyId;
	public string clientID;
	public string unnyIdProduct;
	public BalancySpriteRef sprite;
	public BalancySpriteRef flourishSprite;
	public int giftedAtRegistration;
	public int sFX;
}

[Serializable]
public class BalancySkinList
{
	public BalancySkinEntry[] list;
}

[Serializable]
public class BalancyBoardColorsEntry
{
	public string unnyId;
	public string clientID;
	public string unnyIdProduct;
	public BalancySpriteRef sprite;
	public int colorConfigIndex;
	public bool hideUnlessOwned;
}

[Serializable]
public class BalancyBoardColorsList
{
	public BalancyBoardColorsEntry[] list;
}
