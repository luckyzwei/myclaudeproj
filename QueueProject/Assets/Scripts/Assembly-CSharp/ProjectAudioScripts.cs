using KWAudio;
using UnityEngine;

public class ProjectAudioScripts : MonoBehaviour
{
	private static AudioSoundList s_soundList;

	private static AudioSoundList SoundList
	{
		get
		{
			if (s_soundList == null)
				s_soundList = Resources.Load<AudioSoundList>("AudioSoundList");
			return s_soundList;
		}
	}

	private static void PlayClip(AudioClipReference clipRef)
	{
		if (clipRef == null || clipRef.audioClip == null) return;
		var cam = Camera.main;
		Vector3 pos = cam != null ? cam.transform.position : Vector3.zero;
		AudioSource.PlayClipAtPoint(clipRef.audioClip, pos, clipRef.volume > 0f ? clipRef.volume : 1f);
	}

	public void PlayButtonPostitive()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.globalButtonPositive);
	}

	public void PlayButtonNeutral()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.globalButtonNeutral);
	}

	public void PlayHapticSound()
	{
	}

	public void PlaySfxToggle()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.globalSliderOn);
	}

	public void PlayMusicToggle()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.globalSliderOff);
	}

	public void PlayInfoPopUpSFX()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.infoPopupSFX);
	}

	public void PlayPopUpSFX()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.globalPopUpWindow);
	}

	public void PlaySwipeSFX()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.swipe);
	}

	public void PlaySwooshSFX()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.globalSwoosh);
	}

	public void PlayNextMonthClick()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.monthNext);
	}

	public void PlayNextDayClick()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.selectedDate);
	}

	public void PlayClaimButtonSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.buttonClaim);
	}

	public void PlayLevelCompleteAnimationSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.levelComplete);
	}

	public void PlayCoinTallySfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.coinTallyingUp);
	}

	public void PlaySpinWheelSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.spinningWheel);
	}

	public void PlayPiggyBankFillSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.piggyBankFill);
	}

	public void PlayPlayerProfileSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.playerProfile);
	}

	public void PlayBoosterPopupSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.boosterPopup);
	}

	public void PlayLeagueFinishedSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.leagueFinished);
	}

	public void PlayLeaguePromotionSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.leaguePromotion);
	}

	public void PlayLeagueDemotionSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.leagueDemotion);
	}

	public void PlayLeagueTallyContinueSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.leagueContinue);
	}

	public void PlayFeatureUnlockSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.featureUnlocked);
	}

	public void PlayClaimButton()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.claimButton);
	}

	public void PlayGameOverSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.gameOver);
	}

	public void PlayButtonPage()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.pageSelect);
	}

	public void PlayOnBoardPage()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.onboardBoardPage);
	}

	public void PlayTapSfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.tapSound);
	}

	public void VipButtonsfx()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.vipAppear);
	}

	public void DailyChallengePurple()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.purplePopUp);
	}

	public void QueenHint()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.queenhintFx);
	}

	public void ClickQH()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.qgButton);
	}

	public void QueenBarFill()
	{
		var sl = SoundList;
		if (sl != null) PlayClip(sl.barFill);
	}
}
