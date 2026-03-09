using System;
using Balancy.Models;
using KWAudio;

[Serializable]
public class QueenSFX
{
	public Balancy.Models.SkinSFX id;

	public AudioClipReference QueenGood;

	public AudioClipReference QueenBad;

	public AudioClipReference[] X;

	public AudioClipReference[] UndoX;

	public AudioClipReference QueenCelebrate;
}
