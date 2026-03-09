namespace KWFirebase
{
	public class PurchaseResult
	{
		public bool IsSuccessful { get; }

		public string ErrorMessage { get; }

		public PurchaseResult(bool isSuccessful, string errorMessage)
		{
		}
	}
}
