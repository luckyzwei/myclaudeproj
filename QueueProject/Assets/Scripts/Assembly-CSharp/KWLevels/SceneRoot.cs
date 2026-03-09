using UnityEngine;

namespace KWLevels
{
	public class SceneRoot : MonoBehaviour
	{
		[SerializeField]
		private Vector3 m_endPosition;

		[SerializeField]
		private Vector3 m_startPosition;

		[SerializeField]
		private Vector3 m_endPointForward;

		public Vector3 EndPoint => default(Vector3);

		public Vector3 StartPoint => default(Vector3);

		public Vector3 EndPointForward => default(Vector3);

		public Vector3 EndPointEditor
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 StartPointEditor
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 EndPointForwardEditor
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void SetEndPoint(Vector3 endPoint)
		{
		}

		public void SetStartPoint(Vector3 startPoint)
		{
		}

		public void SetEndPointForward(Vector3 endPointForward)
		{
		}
	}
}
