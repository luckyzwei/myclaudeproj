using Firebase.Firestore;

[FirestoreData]
public struct FirebaseRewardTableData
{
	[FirestoreProperty]
	public string table_str { get; set; }
}
