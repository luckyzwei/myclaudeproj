using Firebase.Firestore;

[FirestoreData]
public struct FirebaseUserData
{
	[FirestoreProperty]
	public byte[] binary { get; set; }

	[FirestoreProperty]
	public long saveDate { get; set; }

	[FirestoreProperty]
	public string userid { get; set; }

	[FirestoreProperty]
	public string binary_str { get; set; }

	[FirestoreProperty]
	public int maxstage { get; set; }
}
