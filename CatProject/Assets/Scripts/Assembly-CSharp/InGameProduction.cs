using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/InGame/Production", false, false)]
public class InGameProduction : InGameFloatingUI
{
	public class Sequence
	{
		public string title;

		public Sprite icon;

		public string value;
	}

	[SerializeField]
	private Text title;

	[SerializeField]
	private Text value;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Animator productionAni;

	private Queue<Sequence> direction;

	private CompositeDisposable disposable;

	public Action onEnd;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Show(Queue<Sequence> seqList, Action OnEnd)
	{
	}

	private void Play()
	{
	}
}
