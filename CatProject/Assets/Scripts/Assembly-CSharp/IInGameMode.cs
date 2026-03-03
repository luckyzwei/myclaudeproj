public interface IInGameMode
{
	void Load();

	void UnLoad();

	void SetCameraBoundMinY(float value);

	void SetCameraBoundMaxY(float value);
}
