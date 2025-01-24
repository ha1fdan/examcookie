using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Web.WebView2.WinForms
{
	[ComVisible(true)]
	public class CoreWebView2CreationProperties
	{
		private String _browserExecutableFolder;

		private String _userDataFolder;

		private String _language;

		private String _additionalBrowserArguments;

		private Task<CoreWebView2Environment> _task;

		public String AdditionalBrowserArguments
		{
			get
			{
				return this._additionalBrowserArguments;
			}
			set
			{
				this._additionalBrowserArguments = value;
				this._task = null;
			}
		}

		public String BrowserExecutableFolder
		{
			get
			{
				return this._browserExecutableFolder;
			}
			set
			{
				this._browserExecutableFolder = value;
				this._task = null;
			}
		}

		public Boolean? IsInPrivateModeEnabled
		{
			get;
			set;
		}

		public String Language
		{
			get
			{
				return this._language;
			}
			set
			{
				this._language = value;
				this._task = null;
			}
		}

		public String ProfileName
		{
			get;
			set;
		}

		public String UserDataFolder
		{
			get
			{
				return this._userDataFolder;
			}
			set
			{
				this._userDataFolder = value;
				this._task = null;
			}
		}

		public CoreWebView2CreationProperties()
		{
		}

		internal CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions(CoreWebView2Environment environment)
		{
			CoreWebView2ControllerOptions profileName = null;
			if (this.ProfileName != null || this.IsInPrivateModeEnabled.get_HasValue())
			{
				profileName = environment.CreateCoreWebView2ControllerOptions();
				profileName.ProfileName = this.ProfileName;
				profileName.IsInPrivateModeEnabled = this.IsInPrivateModeEnabled.GetValueOrDefault();
			}
			return profileName;
		}

		internal Task<CoreWebView2Environment> CreateEnvironmentAsync()
		{
			if (this._task == null && (this.BrowserExecutableFolder != null || this.UserDataFolder != null || this.Language != null || this.AdditionalBrowserArguments != null))
			{
				this._task = CoreWebView2Environment.CreateAsync(this.BrowserExecutableFolder, this.UserDataFolder, new CoreWebView2EnvironmentOptions(this.AdditionalBrowserArguments, this.Language, null, false, null));
			}
			return this._task ?? Task.FromResult<CoreWebView2Environment>(null);
		}
	}
}