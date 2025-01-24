using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Web.WebView2.Core
{
	internal class CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler : ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler, INotifyCompletion
	{
		private Action continuation;

		public IReadOnlyList<CoreWebView2PermissionSetting> collectionView
		{
			get;
			private set;
		}

		public Int32 errCode
		{
			get;
			private set;
		}

		public Boolean IsCompleted
		{
			get;
			private set;
		}

		public CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler()
		{
			this.IsCompleted = false;
		}

		public CoreWebView2GetNonDefaultPermissionSettingsCompletedHandler GetAwaiter()
		{
			return this;
		}

		public IReadOnlyList<CoreWebView2PermissionSetting> GetResult()
		{
			return this.collectionView;
		}

		public Void Invoke(Int32 errCode, ICoreWebView2PermissionSettingCollectionView permissionSettingCollectionView)
		{
			this.collectionView = COMDotNetTypeConverter.CoreWebView2PermissionSettingCollectionViewCOMToNet(permissionSettingCollectionView);
			this.errCode = errCode;
			this.IsCompleted = true;
			if (this.continuation != null)
			{
				this.continuation.Invoke();
			}
		}

		public Void Invoke(Int32 errCode, IReadOnlyList<CoreWebView2PermissionSetting> collectionView)
		{
			this.collectionView = collectionView;
			this.errCode = errCode;
			this.IsCompleted = true;
			if (this.continuation != null)
			{
				this.continuation.Invoke();
			}
		}

		public Void OnCompleted(Action continuation)
		{
			this.continuation = continuation;
			if (this.IsCompleted)
			{
				continuation.Invoke();
			}
		}
	}
}