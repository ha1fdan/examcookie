using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2PrivateHostObjectHelper
	{
		internal ICoreWebView2PrivateHostObjectHelper3 _nativeICoreWebView2PrivateHostObjectHelper3Value;

		internal ICoreWebView2PrivateHostObjectHelper2 _nativeICoreWebView2PrivateHostObjectHelper2Value;

		internal ICoreWebView2PrivateHostObjectHelper _nativeICoreWebView2PrivateHostObjectHelperValue;

		internal Object _rawNative;

		internal ICoreWebView2PrivateHostObjectHelper _nativeICoreWebView2PrivateHostObjectHelper
		{
			get
			{
				if (this._nativeICoreWebView2PrivateHostObjectHelperValue == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateHostObjectHelperValue = (ICoreWebView2PrivateHostObjectHelper)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateHostObjectHelperValue;
			}
			set
			{
				this._nativeICoreWebView2PrivateHostObjectHelperValue = value;
			}
		}

		internal ICoreWebView2PrivateHostObjectHelper2 _nativeICoreWebView2PrivateHostObjectHelper2
		{
			get
			{
				if (this._nativeICoreWebView2PrivateHostObjectHelper2Value == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateHostObjectHelper2Value = (ICoreWebView2PrivateHostObjectHelper2)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateHostObjectHelper2Value;
			}
			set
			{
				this._nativeICoreWebView2PrivateHostObjectHelper2Value = value;
			}
		}

		internal ICoreWebView2PrivateHostObjectHelper3 _nativeICoreWebView2PrivateHostObjectHelper3
		{
			get
			{
				if (this._nativeICoreWebView2PrivateHostObjectHelper3Value == null)
				{
					try
					{
						this._nativeICoreWebView2PrivateHostObjectHelper3Value = (ICoreWebView2PrivateHostObjectHelper3)this._rawNative;
					}
					catch (Exception exception)
					{
						throw new NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateHostObjectHelper3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://learn.microsoft.com/microsoft-edge/webview2/concepts/versioning", exception);
					}
				}
				return this._nativeICoreWebView2PrivateHostObjectHelper3Value;
			}
			set
			{
				this._nativeICoreWebView2PrivateHostObjectHelper3Value = value;
			}
		}

		internal CoreWebView2PrivateHostObjectHelper()
		{
			this._rawNative = new CoreWebView2PrivateHostObjectHelper.RawHelper();
		}

		internal CoreWebView2PrivateHostObjectHelper(Object rawCoreWebView2PrivateHostObjectHelper)
		{
			this._rawNative = rawCoreWebView2PrivateHostObjectHelper;
		}

		internal Object CreateBuiltInDispatch(Object originalHostObject)
		{
			Object obj;
			try
			{
				obj = originalHostObject;
				obj = this._nativeICoreWebView2PrivateHostObjectHelper3.CreateBuiltInDispatch(ref obj);
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
			return obj;
		}

		internal Int32 IsAsyncMethod(Object rawObject, String methodName, Int32 parameterCount)
		{
			Int32 num;
			try
			{
				Object obj = rawObject;
				num = this._nativeICoreWebView2PrivateHostObjectHelper2.IsAsyncMethod(ref obj, methodName, parameterCount);
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
			return num;
		}

		internal Int32 IsMethodMember(Object rawObject, String memberName)
		{
			Int32 num;
			try
			{
				Object obj = rawObject;
				num = this._nativeICoreWebView2PrivateHostObjectHelper.IsMethodMember(ref obj, memberName);
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
			return num;
		}

		internal Void SetAsyncMethodContinuation(Object rawObject, String methodName, Int32 parameterCount, Object methodResult, CoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
		{
			try
			{
				Object obj = rawObject;
				Object obj1 = methodResult;
				this._nativeICoreWebView2PrivateHostObjectHelper2.SetAsyncMethodContinuation(ref obj, methodName, parameterCount, ref obj1, continuation._nativeICoreWebView2PrivateHostObjectAsyncMethodContinuation);
			}
			catch (InvalidCastException invalidCastException1)
			{
				InvalidCastException invalidCastException = invalidCastException1;
				if (invalidCastException.get_HResult() != -2147467262)
				{
					throw invalidCastException;
				}
				throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", invalidCastException);
			}
			catch (COMException cOMException1)
			{
				COMException cOMException = cOMException1;
				if (cOMException.get_HResult() != -2147019873)
				{
					throw cOMException;
				}
				throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", cOMException);
			}
		}

		private class AwaitableReflection
		{
			private Type _awaitable;

			private MethodInfo _getAwaiter;

			private Type _awaiter;

			private PropertyInfo _isCompleted;

			private MethodInfo _onCompleted;

			private MethodInfo _getResult;

			private AwaitableReflection(Type awaitable, MethodInfo getAwaiter, Type awaiter, PropertyInfo isCompleted, MethodInfo onCompleted, MethodInfo getResult)
			{
				this._awaitable = awaitable;
				this._getAwaiter = getAwaiter;
				this._awaiter = awaiter;
				this._isCompleted = isCompleted;
				this._onCompleted = onCompleted;
				this._getResult = getResult;
			}

			public static CoreWebView2PrivateHostObjectHelper.AwaitableReflection FromAwaitableType(Type type)
			{
				MethodInfo method = type.GetMethod("GetAwaiter");
				if (method == null || method.GetParameters().Length != 0)
				{
					return null;
				}
				Type returnType = method.get_ReturnType();
				PropertyInfo property = returnType.GetProperty("IsCompleted");
				if (property == null || !property.get_CanRead() || property.get_PropertyType() != typeof(Boolean))
				{
					return null;
				}
				MethodInfo methodInfo = returnType.GetMethod("OnCompleted");
				if (methodInfo == null)
				{
					return null;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				if ((Int32)parameters.Length != 1 || parameters[0].get_ParameterType() != typeof(Action))
				{
					return null;
				}
				MethodInfo method1 = returnType.GetMethod("GetResult");
				if (method1 == null || method1.GetParameters().Length != 0)
				{
					return null;
				}
				return new CoreWebView2PrivateHostObjectHelper.AwaitableReflection(type, method, returnType, property, methodInfo, method1);
			}

			public Object InvokeGetAwaiter(Object awaitable)
			{
				if (awaitable.GetType() != this._awaitable)
				{
					throw new InvalidOperationException(String.Format("Invoking {0} on an object of type {1} when an awaitable object of type {2} was expected.", this._getAwaiter.get_Name(), awaitable.GetType(), this._awaitable));
				}
				return this._getAwaiter.Invoke(awaitable, Array.Empty<Object>());
			}

			public Object InvokeGetResult(Object awaiter)
			{
				if (awaiter.GetType() != this._awaiter)
				{
					throw new InvalidOperationException(String.Format("Invoking {0} on an object of type {1} when an awaiter object of type {2} was expected.", this._getResult.get_Name(), awaiter.GetType(), this._awaiter));
				}
				return this._getResult.Invoke(awaiter, Array.Empty<Object>());
			}

			public Boolean InvokeIsCompleted(Object awaiter)
			{
				if (awaiter.GetType() != this._awaiter)
				{
					throw new InvalidOperationException(String.Format("Invoking {0} on an object of type {1} when an awaiter object of type {2} was expected.", this._isCompleted.get_Name(), awaiter.GetType(), this._awaiter));
				}
				return (Boolean)this._isCompleted.GetValue(awaiter);
			}

			public Void InvokeOnCompleted(Object awaiter, Action continuation)
			{
				if (awaiter.GetType() != this._awaiter)
				{
					throw new InvalidOperationException(String.Format("Invoking {0} on an object of type {1} when an awaiter object of type {2} was expected.", this._onCompleted.get_Name(), awaiter.GetType(), this._awaiter));
				}
				this._onCompleted.Invoke(awaiter, new Object[] { continuation });
			}
		}

		private class RawHelper : ICoreWebView2PrivateHostObjectHelper, ICoreWebView2PrivateHostObjectHelper2, ICoreWebView2PrivateHostObjectHelper3
		{
			private const Int32 DISP_E_MEMBERNOTFOUND = -2147352573;

			private const Int32 DISP_E_TYPEMISMATCH = -2147352571;

			private const Int32 WIN_BOOL_TRUE = 1;

			private const Int32 WIN_BOOL_FALSE = 0;

			private const Int32 S_OK = 0;

			public RawHelper()
			{
			}

			public Object CreateBuiltInDispatch(ref Object originalHostObject)
			{
				return new BuiltInHostObject(originalHostObject);
			}

			private MethodInfo GetMethodInfo(Type type, String methodName, Int32? parameterCount)
			{
				if (!type.get_IsClass() || type.get_IsCOMObject())
				{
					throw new COMException(null, -2147352571);
				}
				MemberInfo[] member = type.GetMember(methodName);
				if (member.Length == 0)
				{
					throw new COMException(null, -2147352573);
				}
				MemberInfo[] memberInfoArray = member;
				for (Int32 i = 0; i < (Int32)memberInfoArray.Length; i++)
				{
					MemberInfo memberInfo = memberInfoArray[i];
					if (memberInfo.get_MemberType() == 8)
					{
						MethodInfo methodInfo = (MethodInfo)memberInfo;
						if (!parameterCount.get_HasValue() || (Int32)methodInfo.GetParameters().Length == parameterCount.get_Value())
						{
							return methodInfo;
						}
					}
				}
				return null;
			}

			public Int32 IsAsyncMethod(ref Object rawObject, String methodName, Int32 parameterCount)
			{
				MethodInfo methodInfo = this.GetMethodInfo(rawObject.GetType(), methodName, new Int32?(parameterCount));
				if (methodInfo == null)
				{
					throw new COMException(null, -2147352571);
				}
				if (CoreWebView2PrivateHostObjectHelper.AwaitableReflection.FromAwaitableType(methodInfo.get_ReturnType()) != null)
				{
					return 1;
				}
				return 0;
			}

			public Int32 IsMethodMember(ref Object rawObject, String memberName)
			{
				Int32? nullable = null;
				if (this.GetMethodInfo(rawObject.GetType(), memberName, nullable) != null)
				{
					return 1;
				}
				return 0;
			}

			public Void SetAsyncMethodContinuation(ref Object rawObject, String methodName, Int32 parameterCount, ref Object methodResult, ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
			{
				CoreWebView2PrivateHostObjectHelper.RawHelper.u003cu003ec__DisplayClass10_0 variable = null;
				if (this.GetMethodInfo(rawObject.GetType(), methodName, new Int32?(parameterCount)) == null)
				{
					throw new COMException(null, -2147352571);
				}
				CoreWebView2PrivateHostObjectHelper.AwaitableReflection awaitableReflection = CoreWebView2PrivateHostObjectHelper.AwaitableReflection.FromAwaitableType(methodResult.GetType());
				if (awaitableReflection == null)
				{
					throw new COMException(null, -2147352571);
				}
				Object obj2 = awaitableReflection.InvokeGetAwaiter(methodResult);
				Action action = new Action(variable, () => {
					Object obj = null;
					Int32 hRForException = 0;
					try
					{
						obj = this.ar.InvokeGetResult(this.awaiter);
					}
					catch (Exception exception)
					{
						hRForException = Marshal.GetHRForException(exception);
					}
					if (obj.GetType().get_FullName() == "System.Threading.Tasks.VoidTaskResult")
					{
						obj = null;
					}
					Object obj1 = obj;
					this.continuation.Invoke(hRForException, ref obj1);
				});
				if (awaitableReflection.InvokeIsCompleted(obj2))
				{
					action.Invoke();
					return;
				}
				awaitableReflection.InvokeOnCompleted(obj2, action);
			}
		}
	}
}