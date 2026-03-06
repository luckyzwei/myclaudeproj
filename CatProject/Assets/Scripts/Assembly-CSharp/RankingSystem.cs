using Treeplla;
using UniRx;

public class RankingSystem
{
	private CompositeDisposable disposables;

	public int UserRank { get; private set; }

	public void Init()
	{
		disposables = new CompositeDisposable();
		UserRank = 0;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		if (gameRoot.UserData.Level != null)
		{
			gameRoot.UserData.Level.Subscribe(level =>
			{
				UpdateRank(level);
			}).AddTo(disposables);
		}
	}

	private void UpdateRank(int point)
	{
		if (point <= 0)
		{
			UserRank = 0;
			return;
		}

		if (point >= 100)
			UserRank = 10;
		else if (point >= 80)
			UserRank = 9;
		else if (point >= 65)
			UserRank = 8;
		else if (point >= 50)
			UserRank = 7;
		else if (point >= 40)
			UserRank = 6;
		else if (point >= 30)
			UserRank = 5;
		else if (point >= 22)
			UserRank = 4;
		else if (point >= 15)
			UserRank = 3;
		else if (point >= 8)
			UserRank = 2;
		else
			UserRank = 1;
	}
}
