using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.Common;
using Google.Play.Review;

namespace KWRating.Rating
{
	public class RatingsManager
	{
		[CompilerGenerated]
		private sealed class _003CShowAndroidReviewPopUp_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private ReviewManager _003CreviewManager_003E5__2;

			private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> _003CratingPopUpInfoAction_003E5__3;

			private PlayAsyncOperation<VoidResult, ReviewErrorCode> _003CratingPopUpAction_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowAndroidReviewPopUp_003Ed__1(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public void TryShowRatingsPopUp()
		{
		}

		[IteratorStateMachine(typeof(_003CShowAndroidReviewPopUp_003Ed__1))]
		private IEnumerator ShowAndroidReviewPopUp()
		{
			return null;
		}
	}
}
