using System;
using Balancy.Models.KWSpinWheel;

public interface ISpinWheelCustomizer
{
	void Customize();

	void AnimateIn(Action callback);

	void AnimateOut(Action callback);

	SpinWheelRewards GetCurrentReward();
}
