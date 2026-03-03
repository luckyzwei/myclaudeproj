internal interface IAnalytics
{
	void Event(IngameEventType eventType, string eventName, params object[] args);

	void InAppPurchaseEvent(params object[] args);
}
