using System.Runtime.CompilerServices;

namespace UnitTesting
{
	public class UnitTestCallback
	{
		public interface IDelegate
		{
			void ReportSuccess(string extraInfo, string callerName, string callerPath, int callerLineNumber);

			void ReportFailure(string extraInfo, string callerName, string callerPath, int callerLineNumber);
		}

		private IDelegate m_delegate;

		private bool m_isSuccess;

		private bool m_isCompleted;

		private string m_message;

		public bool IsCompleted => false;

		public string Message => null;

		public bool IsFailed => false;

		public void Success(string extraInfo = "", [CallerMemberName] string callerName = "", [CallerFilePath] string callerPath = "", [CallerLineNumber] int callerLineNumber = 0)
		{
		}

		public void Failed(string extraInfo = "", [CallerMemberName] string callerName = "", [CallerFilePath] string callerPath = "", [CallerLineNumber] int callerLineNumber = 0)
		{
		}

		public void Initialise(IDelegate del)
		{
		}

		public void ResetState()
		{
		}
	}
}
