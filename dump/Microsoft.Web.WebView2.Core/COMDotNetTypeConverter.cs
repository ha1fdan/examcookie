using Microsoft.Web.WebView2.Core.Raw;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core
{
	internal static class COMDotNetTypeConverter
	{
		public static Color ColorCOMToNet(COREWEBVIEW2_COLOR color)
		{
			return Color.FromArgb((Int32)color.A, (Int32)color.R, (Int32)color.G, (Int32)color.B);
		}

		public static COREWEBVIEW2_COLOR ColorNetToCOM(Color dotNetColor)
		{
			COREWEBVIEW2_COLOR variable = new COREWEBVIEW2_COLOR()
			{
				A = dotNetColor.get_A(),
				R = dotNetColor.get_R(),
				G = dotNetColor.get_G(),
				B = dotNetColor.get_B()
			};
			return variable;
		}

		public static List<CoreWebView2Cookie> CookieListCOMToNet(ICoreWebView2CookieList rawCookieList)
		{
			List<CoreWebView2Cookie> list = new List<CoreWebView2Cookie>(Convert.ToInt32(rawCookieList.Count));
			for (UInt32 i = 0; i < rawCookieList.Count; i++)
			{
				list.Add(new CoreWebView2Cookie(rawCookieList.GetValueAtIndex(i)));
			}
			return list;
		}

		public static IReadOnlyList<CoreWebView2ClientCertificate> CoreWebView2ClientCertificateCollectionCOMToNet(ICoreWebView2ClientCertificateCollection rawClientCertificateCollection)
		{
			if (rawClientCertificateCollection == null)
			{
				return null;
			}
			List<CoreWebView2ClientCertificate> list = new List<CoreWebView2ClientCertificate>(Convert.ToInt32(rawClientCertificateCollection.Count));
			for (UInt32 i = 0; i < rawClientCertificateCollection.Count; i++)
			{
				list.Add(new CoreWebView2ClientCertificate(rawClientCertificateCollection.GetValueAtIndex(i)));
			}
			return new ReadOnlyCollection<CoreWebView2ClientCertificate>(list);
		}

		public static IList<CoreWebView2ContextMenuItem> CoreWebView2ContextMenuItemCollectionCOMToNet(ICoreWebView2ContextMenuItemCollection rawContextMenuCollection)
		{
			COMDotNetTypeConverter.u003cu003ec__DisplayClass11_0 variable = null;
			if (rawContextMenuCollection == null)
			{
				return null;
			}
			List<CoreWebView2ContextMenuItem> list = new List<CoreWebView2ContextMenuItem>(Convert.ToInt32(rawContextMenuCollection.Count));
			for (UInt32 num = 0; num < rawContextMenuCollection.Count; num++)
			{
				list.Add(new CoreWebView2ContextMenuItem(rawContextMenuCollection.GetValueAtIndex(num)));
			}
			ObservableCollection<CoreWebView2ContextMenuItem> observableCollection = new ObservableCollection<CoreWebView2ContextMenuItem>(list);
			observableCollection.add_CollectionChanged(new NotifyCollectionChangedEventHandler(variable, (Object sender, NotifyCollectionChangedEventArgs args) => {
				switch (args.get_Action())
				{
					case 0:
					{
						this.rawContextMenuCollection.InsertValueAtIndex((UInt32)args.get_NewStartingIndex(), ((CoreWebView2ContextMenuItem)args.get_NewItems().get_Item(0))._nativeICoreWebView2ContextMenuItem);
						return;
					}
					case 1:
					{
						this.rawContextMenuCollection.RemoveValueAtIndex((UInt32)args.get_OldStartingIndex());
						return;
					}
					case 2:
					{
						this.rawContextMenuCollection.RemoveValueAtIndex((UInt32)args.get_OldStartingIndex());
						this.rawContextMenuCollection.InsertValueAtIndex((UInt32)args.get_NewStartingIndex(), ((CoreWebView2ContextMenuItem)args.get_NewItems().get_Item(0))._nativeICoreWebView2ContextMenuItem);
						return;
					}
					case 3:
					case 4:
					{
						UInt32 count = this.rawContextMenuCollection.Count;
						for (UInt32 i = 0; i < count; i++)
						{
							this.rawContextMenuCollection.RemoveValueAtIndex(0);
						}
						for (Int32 j = 0; j < this.collection.get_Count(); j++)
						{
							this.rawContextMenuCollection.InsertValueAtIndex((UInt32)j, this.collection.get_Item(j)._nativeICoreWebView2ContextMenuItem);
						}
						return;
					}
					default:
					{
						return;
					}
				}
			}));
			return observableCollection;
		}

		public static IReadOnlyList<CoreWebView2FrameInfo> CoreWebView2FrameInfoCollectionCOMToNet(ICoreWebView2FrameInfoCollection rawFrameInfoCollection)
		{
			if (rawFrameInfoCollection == null)
			{
				return null;
			}
			List<CoreWebView2FrameInfo> list = new List<CoreWebView2FrameInfo>();
			ICoreWebView2FrameInfoCollectionIterator iterator = rawFrameInfoCollection.GetIterator();
			while (iterator.HasCurrent != 0)
			{
				list.Add(new CoreWebView2FrameInfo(iterator.GetCurrent()));
				iterator.MoveNext();
			}
			return new ReadOnlyCollection<CoreWebView2FrameInfo>(list);
		}

		public static IReadOnlyList<Object> CoreWebView2ObjectCollectionViewCOMToNet(ICoreWebView2ObjectCollectionView rawObjectCollection)
		{
			if (rawObjectCollection == null)
			{
				return null;
			}
			List<Object> list = new List<Object>(Convert.ToInt32(rawObjectCollection.Count));
			for (UInt32 i = 0; i < rawObjectCollection.Count; i++)
			{
				Object valueAtIndex = rawObjectCollection.GetValueAtIndex(i);
				if (valueAtIndex != null)
				{
					ICoreWebView2File variable = valueAtIndex as ICoreWebView2File;
					if (variable == null)
					{
						goto Label0;
					}
					valueAtIndex = new CoreWebView2File(variable);
				}
				list.Add(valueAtIndex);
			Label0:
			}
			return new ReadOnlyCollection<Object>(list);
		}

		public static IReadOnlyList<CoreWebView2PermissionSetting> CoreWebView2PermissionSettingCollectionViewCOMToNet(ICoreWebView2PermissionSettingCollectionView rawPermissionSettingCollectionView)
		{
			if (rawPermissionSettingCollectionView == null)
			{
				return null;
			}
			List<CoreWebView2PermissionSetting> list = new List<CoreWebView2PermissionSetting>(Convert.ToInt32(rawPermissionSettingCollectionView.Count));
			for (UInt32 i = 0; i < rawPermissionSettingCollectionView.Count; i++)
			{
				list.Add(new CoreWebView2PermissionSetting(rawPermissionSettingCollectionView.GetValueAtIndex(i)));
			}
			return new ReadOnlyCollection<CoreWebView2PermissionSetting>(list);
		}

		public static IReadOnlyList<String> CoreWebView2StringCollectionCOMToNet(ICoreWebView2StringCollection rawStringCollection)
		{
			if (rawStringCollection == null)
			{
				return null;
			}
			List<String> list = new List<String>(Convert.ToInt32(rawStringCollection.Count));
			for (UInt32 i = 0; i < rawStringCollection.Count; i++)
			{
				list.Add(rawStringCollection.GetValueAtIndex(i));
			}
			return new ReadOnlyCollection<String>(list);
		}

		public static Point PointCOMToNet(tagPOINT point)
		{
			return new Point(point.x, point.y);
		}

		public static tagPOINT PointNetToCOM(Point dotNetPoint)
		{
			tagPOINT variable = new tagPOINT()
			{
				x = Convert.ToInt32(dotNetPoint.get_X()),
				y = Convert.ToInt32(dotNetPoint.get_Y())
			};
			return variable;
		}

		public static IReadOnlyList<CoreWebView2ProcessInfo> ProcessInfoCollectionCOMToNet(ICoreWebView2ProcessInfoCollection rawCoreWebView2ProcessInfoCollection)
		{
			if (rawCoreWebView2ProcessInfoCollection == null)
			{
				return null;
			}
			List<CoreWebView2ProcessInfo> list = new List<CoreWebView2ProcessInfo>(Convert.ToInt32(rawCoreWebView2ProcessInfoCollection.Count));
			for (UInt32 i = 0; i < rawCoreWebView2ProcessInfoCollection.Count; i++)
			{
				list.Add(new CoreWebView2ProcessInfo(rawCoreWebView2ProcessInfoCollection.GetValueAtIndex(i)));
			}
			return new ReadOnlyCollection<CoreWebView2ProcessInfo>(list);
		}

		public static Rectangle RectangleCOMToNet(tagRECT rect)
		{
			Int32 num = rect.left;
			Int32 num1 = rect.top;
			Int32 num2 = rect.right - rect.left;
			Int32 num3 = rect.bottom - rect.top;
			return new Rectangle(num, num1, num2, num3);
		}

		public static tagRECT RectangleNetToCOM(Rectangle dotNetRect)
		{
			tagRECT variable = new tagRECT()
			{
				top = dotNetRect.get_Top(),
				left = dotNetRect.get_Left(),
				right = dotNetRect.get_Right(),
				bottom = dotNetRect.get_Bottom()
			};
			return variable;
		}

		public static COMStreamWrapper StreamCOMToNet(IStream stream)
		{
			if (stream == null)
			{
				return null;
			}
			return new COMStreamWrapper(stream);
		}
	}
}