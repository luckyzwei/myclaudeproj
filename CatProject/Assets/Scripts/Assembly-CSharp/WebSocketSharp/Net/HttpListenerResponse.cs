using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerResponse : IDisposable
	{
		[CompilerGenerated]
		private sealed class _003CfindCookie_003Ed__69 : IEnumerable<Cookie>, IEnumerable, IEnumerator<Cookie>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Cookie _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public HttpListenerResponse _003C_003E4__this;

			private Cookie cookie;

			public Cookie _003C_003E3__cookie;

			private IEnumerator<Cookie> _003C_003E7__wrap1;

			Cookie IEnumerator<Cookie>.Current
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
			public _003CfindCookie_003Ed__69(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Cookie> IEnumerable<Cookie>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private bool _closeConnection;

		private Encoding _contentEncoding;

		private long _contentLength;

		private string _contentType;

		private HttpListenerContext _context;

		private CookieCollection _cookies;

		private static readonly string _defaultProductName;

		private bool _disposed;

		private WebHeaderCollection _headers;

		private bool _headersSent;

		private bool _keepAlive;

		private ResponseStream _outputStream;

		private Uri _redirectLocation;

		private bool _sendChunked;

		private int _statusCode;

		private string _statusDescription;

		private Version _version;

		internal bool CloseConnection
		{
		get { return _closeConnection; }
		set { _closeConnection = value; }
	}

		internal WebHeaderCollection FullHeaders => null;

		internal bool HeadersSent
		{
		get { return _headersSent; }
		set { _headersSent = value; }
	}

		internal string ObjectName => null;

		internal string StatusLine => null;

		public Encoding ContentEncoding
		{
		get { return _contentEncoding; }
		set { _contentEncoding = value; }
	}

		public long ContentLength64
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string ContentType
		{
		get { return _contentType; }
		set { _contentType = value; }
	}

		public CookieCollection Cookies
		{
		get { return _cookies; }
		set { _cookies = value; }
	}

		public WebHeaderCollection Headers
		{
		get { return _headers; }
		set { _headers = value; }
	}

		public bool KeepAlive
		{
		get { return _keepAlive; }
		set { _keepAlive = value; }
	}

		public Stream OutputStream => null;

		public Version ProtocolVersion => null;

		public string RedirectLocation
		{
		get { return _redirectLocation != null ? _redirectLocation.ToString() : null; }
		set { _redirectLocation = value != null ? new Uri(value) : null; }
	}

		public bool SendChunked
		{
		get { return _sendChunked; }
		set { _sendChunked = value; }
	}

		public int StatusCode
		{
		get { return _statusCode; }
		set { _statusCode = value; }
	}

		public string StatusDescription
		{
		get { return _statusDescription; }
		set { _statusDescription = value; }
	}

		static HttpListenerResponse()
		{
		}

		internal HttpListenerResponse(HttpListenerContext context)
		{
		}

		private bool canSetCookie(Cookie cookie)
		{
			return false;
		}

		private void close(bool force)
		{
		}

		private void close(byte[] responseEntity, int bufferLength, bool willBlock)
		{
		}

		private static string createContentTypeHeaderText(string value, Encoding encoding)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CfindCookie_003Ed__69))]
		private IEnumerable<Cookie> findCookie(Cookie cookie)
		{
			return null;
		}

		private static bool isValidForContentType(string value)
		{
			return false;
		}

		private static bool isValidForStatusDescription(string value)
		{
			return false;
		}

		public void Abort()
		{
		}

		public void AppendCookie(Cookie cookie)
		{
		}

		public void AppendHeader(string name, string value)
		{
		}

		public void Close()
		{
		}

		public void Close(byte[] responseEntity, bool willBlock)
		{
		}

		public void CopyFrom(HttpListenerResponse templateResponse)
		{
		}

		public void Redirect(string url)
		{
		}

		public void SetCookie(Cookie cookie)
		{
		}

		public void SetHeader(string name, string value)
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
