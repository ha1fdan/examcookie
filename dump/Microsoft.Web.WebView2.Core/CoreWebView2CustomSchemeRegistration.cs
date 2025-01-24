using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core
{
	[ComVisible(true)]
	public class CoreWebView2CustomSchemeRegistration
	{
		public List<String> AllowedOrigins { get; set; } = new List<String>();

		public Boolean HasAuthorityComponent
		{
			get;
			set;
		}

		public String SchemeName
		{
			get;
		}

		public Boolean TreatAsSecure
		{
			get;
			set;
		}

		public CoreWebView2CustomSchemeRegistration(String schemeName)
		{
			this.SchemeName = schemeName;
		}

		internal IntPtr GetNative()
		{
			return Marshal.GetComInterfaceForObject(new CoreWebView2CustomSchemeRegistration.RawCustomSchemeRegistration(this.SchemeName, this.TreatAsSecure, this.HasAuthorityComponent, this.AllowedOrigins), typeof(ICoreWebView2CustomSchemeRegistration));
		}

		private class RawCustomSchemeRegistration : ICoreWebView2CustomSchemeRegistration
		{
			private List<String> AllowedOrigins
			{
				get;
			}

			public Int32 HasAuthorityComponent
			{
				get;
				set;
			}

			public String SchemeName
			{
				get
				{
					return get_SchemeName();
				}
				set
				{
					set_SchemeName(value);
				}
			}

			// <SchemeName>k__BackingField
			private String u003cSchemeNameu003ek__BackingField;

			public String get_SchemeName()
			{
				return this.u003cSchemeNameu003ek__BackingField;
			}

			public Void set_SchemeName(String value)
			{
				this.u003cSchemeNameu003ek__BackingField = value;
			}

			public Int32 TreatAsSecure
			{
				get;
				set;
			}

			public RawCustomSchemeRegistration(String schemeName, Boolean treatAsSecure, Boolean hasAuthorityComponent, List<String> allowedOrigins)
			{
				this.SchemeName = schemeName;
				this.TreatAsSecure = (treatAsSecure ? 1 : 0);
				this.HasAuthorityComponent = (hasAuthorityComponent ? 1 : 0);
				this.AllowedOrigins = allowedOrigins;
			}

			public Void GetAllowedOrigins(out UInt32 allowedOriginsCount, IntPtr allowedOriginsPtr)
			{
				allowedOriginsCount = (UInt32)this.AllowedOrigins.get_Count();
				if (allowedOriginsCount == 0)
				{
					return;
				}
				IntPtr intPtr = Marshal.AllocCoTaskMem(allowedOriginsCount * Marshal.SizeOf<IntPtr>());
				for (Int32 i = 0; (Int64)i < (UInt64)allowedOriginsCount; i++)
				{
					Marshal.WriteIntPtr(intPtr + i * Marshal.SizeOf<IntPtr>(), Marshal.StringToCoTaskMemAuto(this.AllowedOrigins.get_Item(i)));
				}
				Marshal.WriteIntPtr(allowedOriginsPtr, intPtr);
			}

			public Void SetAllowedOrigins(UInt32 allowedOriginsCount, ref String allowedOrigins)
			{
				throw new NotImplementedException();
			}
		}
	}
}