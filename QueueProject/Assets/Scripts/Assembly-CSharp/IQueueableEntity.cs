using System;

public interface IQueueableEntity
{
	void StartProcess(Action finishCallback);

	int GetPriority();

	int GetUnlockLocationMask();
}
