namespace KWAnalytics.Analytics
{
	public class EventValidator
	{
		private ParameterDefinitions m_parameterDefinitions;

		private readonly EventValidatorCache m_eventValidatorCache;

		private readonly AnalyticsEventValidatorRequestHandler m_requestHandler;

		private bool m_isInitialized;

		public void Initialize()
		{
		}

		public void Cleanup()
		{
		}

		private void LoadParameterDefinitions()
		{
		}

		private void OnEventSuccess(string responseJson)
		{
		}

		private void OnEventError(long errorCode, string errorMessage)
		{
		}

		public bool IsValidEvent(AnalyticParameterTypes.BaseParameterType parameterType, BaseSchema eventSchema, string eventJoinId)
		{
			return false;
		}

		private void ReportValidationError(ParameterDefinition parameter, object value, string eventJoinId, BaseSchema eventSchema, string rawEventJson)
		{
		}

		private bool IsValidEventParameter(ParameterDefinition parameter, object value)
		{
			return false;
		}

		private bool ValidateVarchar(ParameterDefinition parameter, object value)
		{
			return false;
		}

		private bool ValidateFloatOrDouble(object value)
		{
			return false;
		}

		private bool ValidateNumeric(ParameterDefinition parameter, object value)
		{
			return false;
		}

		private bool ContainsUnicode(string input)
		{
			return false;
		}

		public ParameterDefinitions GetParameterDefinitions()
		{
			return null;
		}

		public ParameterDefinitions GetBakedParameterDefinitions()
		{
			return null;
		}
	}
}
