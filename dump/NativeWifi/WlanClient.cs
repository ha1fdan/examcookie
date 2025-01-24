using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace NativeWifi
{
	public class WlanClient : IDisposable
	{
		private IntPtr clientHandle;

		private UInt32 negotiatedVersion;

		private readonly Wlan.WlanNotificationCallbackDelegate wlanNotificationCallback;

		private readonly Dictionary<Guid, WlanClient.WlanInterface> ifaces = new Dictionary<Guid, WlanClient.WlanInterface>();

		public WlanClient.WlanInterface[] Interfaces
		{
			get
			{
				IntPtr intPtr;
				WlanClient.WlanInterface wlanInterface = null;
				WlanClient.WlanInterface[] wlanInterfaceArray;
				Wlan.ThrowIfError(Wlan.WlanEnumInterfaces(this.clientHandle, IntPtr.Zero, out intPtr));
				try
				{
					Wlan.WlanInterfaceInfoListHeader structure = (Wlan.WlanInterfaceInfoListHeader)Marshal.PtrToStructure(intPtr, typeof(Wlan.WlanInterfaceInfoListHeader));
					Int64 num = intPtr.ToInt64() + (Int64)Marshal.SizeOf(structure);
					WlanClient.WlanInterface[] wlanInterfaceArray1 = new WlanClient.WlanInterface[structure.numberOfItems];
					List<Guid> list = new List<Guid>();
					for (Int32 i = 0; (Int64)i < (UInt64)structure.numberOfItems; i++)
					{
						Wlan.WlanInterfaceInfo wlanInterfaceInfo = (Wlan.WlanInterfaceInfo)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanInterfaceInfo));
						num += (Int64)Marshal.SizeOf(wlanInterfaceInfo);
						list.Add(wlanInterfaceInfo.interfaceGuid);
						if (!this.ifaces.TryGetValue(wlanInterfaceInfo.interfaceGuid, ref wlanInterface))
						{
							wlanInterface = new WlanClient.WlanInterface(this, wlanInterfaceInfo);
							this.ifaces.set_Item(wlanInterfaceInfo.interfaceGuid, wlanInterface);
						}
						wlanInterfaceArray1[i] = wlanInterface;
					}
					Queue<Guid> queue = new Queue<Guid>();
					foreach (Guid key in this.ifaces.get_Keys())
					{
						if (!list.Contains(key))
						{
							queue.Enqueue(key);
						}
					}
					while (queue.get_Count() != 0)
					{
						Guid guid = queue.Dequeue();
						this.ifaces.Remove(guid);
					}
					wlanInterfaceArray = wlanInterfaceArray1;
				}
				finally
				{
					Wlan.WlanFreeMemory(intPtr);
				}
				return wlanInterfaceArray;
			}
		}

		public WlanClient()
		{
			Wlan.WlanNotificationSource wlanNotificationSource;
			Wlan.ThrowIfError(Wlan.WlanOpenHandle(1, IntPtr.Zero, out this.negotiatedVersion, out this.clientHandle));
			try
			{
				this.wlanNotificationCallback = new Wlan.WlanNotificationCallbackDelegate(this.OnWlanNotification);
				Wlan.ThrowIfError(Wlan.WlanRegisterNotification(this.clientHandle, Wlan.WlanNotificationSource.All, false, this.wlanNotificationCallback, IntPtr.Zero, IntPtr.Zero, out wlanNotificationSource));
			}
			catch
			{
				this.Close();
				throw;
			}
		}

		private Void Close()
		{
			try
			{
				if (this.clientHandle != IntPtr.Zero)
				{
					Wlan.WlanCloseHandle(this.clientHandle, IntPtr.Zero);
					this.clientHandle = IntPtr.Zero;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
			}
		}

		protected override Void Finalize()
		{
			try
			{
				this.Close();
			}
			finally
			{
				this.Finalize();
			}
		}

		public String GetStringForReasonCode(Wlan.WlanReasonCode reasonCode)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			Wlan.ThrowIfError(Wlan.WlanReasonCodeToString(reasonCode, stringBuilder.get_Capacity(), stringBuilder, IntPtr.Zero));
			return stringBuilder.ToString();
		}

		private Void OnWlanNotification(ref Wlan.WlanNotificationData notifyData, IntPtr context)
		{
			WlanClient.WlanInterface wlanInterface = null;
			this.ifaces.TryGetValue(notifyData.interfaceGuid, ref wlanInterface);
			Wlan.WlanNotificationSource wlanNotificationSource = notifyData.notificationSource;
			if (wlanNotificationSource == Wlan.WlanNotificationSource.ACM)
			{
				Wlan.WlanNotificationCodeAcm wlanNotificationCodeAcm = notifyData.notificationCode;
				if (wlanNotificationCodeAcm == Wlan.WlanNotificationCodeAcm.ScanFail)
				{
					Int32 num = Marshal.SizeOf(typeof(Int32));
					if (notifyData.dataSize >= num)
					{
						Wlan.WlanReasonCode wlanReasonCode = Marshal.ReadInt32(notifyData.dataPtr);
						if ((object)wlanInterface != (object)null)
						{
							wlanInterface.OnWlanReason(notifyData, wlanReasonCode);
						}
					}
				}
				else
				{
					if ((Int32)wlanNotificationCodeAcm - (Int32)Wlan.WlanNotificationCodeAcm.ConnectionStart > (Int32)Wlan.WlanNotificationCodeAcm.AutoconfDisabled)
					{
						if ((Int32)wlanNotificationCodeAcm - (Int32)Wlan.WlanNotificationCodeAcm.Disconnecting <= (Int32)Wlan.WlanNotificationCodeAcm.AutoconfEnabled)
						{
							goto Label1;
						}
						goto Label0;
					}
				Label1:
					Wlan.WlanConnectionNotificationData? nullable = WlanClient.ParseWlanConnectionNotification(ref notifyData);
					if (nullable.get_HasValue() && (object)wlanInterface != (object)null)
					{
						wlanInterface.OnWlanConnection(notifyData, nullable.get_Value());
					}
				}
			Label0:
			}
			else if (wlanNotificationSource == Wlan.WlanNotificationSource.MSM)
			{
				Wlan.WlanNotificationCodeMsm wlanNotificationCodeMsm = notifyData.notificationCode;
				if ((Int32)wlanNotificationCodeMsm - (Int32)Wlan.WlanNotificationCodeMsm.Associating > (Int32)Wlan.WlanNotificationCodeMsm.RoamingStart)
				{
					if ((Int32)wlanNotificationCodeMsm - (Int32)Wlan.WlanNotificationCodeMsm.Disassociating <= (Int32)Wlan.WlanNotificationCodeMsm.Connected)
					{
						goto Label3;
					}
					goto Label2;
				}
			Label3:
				Wlan.WlanConnectionNotificationData? nullable1 = WlanClient.ParseWlanConnectionNotification(ref notifyData);
				if (nullable1.get_HasValue() && (object)wlanInterface != (object)null)
				{
					wlanInterface.OnWlanConnection(notifyData, nullable1.get_Value());
				}
			Label2:
			}
			if ((object)wlanInterface != (object)null)
			{
				wlanInterface.OnWlanNotification(notifyData);
			}
		}

		private static Wlan.WlanConnectionNotificationData? ParseWlanConnectionNotification(ref Wlan.WlanNotificationData notifyData)
		{
			Wlan.WlanConnectionNotificationData? nullable;
			Wlan.WlanConnectionNotificationData? nullable1;
			try
			{
				Int32 num = Marshal.SizeOf(typeof(Wlan.WlanConnectionNotificationData));
				if (notifyData.dataSize >= num)
				{
					Wlan.WlanConnectionNotificationData structure = (Wlan.WlanConnectionNotificationData)Marshal.PtrToStructure(notifyData.dataPtr, typeof(Wlan.WlanConnectionNotificationData));
					if (structure.wlanReasonCode == Wlan.WlanReasonCode.Success)
					{
						Int64 num1 = notifyData.dataPtr.ToInt64();
						IntPtr intPtr = Marshal.OffsetOf(typeof(Wlan.WlanConnectionNotificationData), "profileXml");
						IntPtr intPtr1 = new IntPtr(num1 + intPtr.ToInt64());
						structure.profileXml = Marshal.PtrToStringUni(intPtr1);
					}
					nullable1 = new Wlan.WlanConnectionNotificationData?(structure);
				}
				else
				{
					nullable = null;
					nullable1 = nullable;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				nullable = null;
				nullable1 = nullable;
			}
			return nullable1;
		}

		Void System.IDisposable.Dispose()
		{
			GC.SuppressFinalize(this);
			this.Close();
		}

		public class WlanInterface
		{
			private readonly WlanClient client;

			private Wlan.WlanInterfaceInfo info;

			private Boolean queueEvents;

			private readonly AutoResetEvent eventQueueFilled;

			private readonly Queue<Object> eventQueue;

			public Boolean Autoconf
			{
				get
				{
					return this.GetInterfaceInt(Wlan.WlanIntfOpcode.AutoconfEnabled) != 0;
				}
				set
				{
					this.SetInterfaceInt(Wlan.WlanIntfOpcode.AutoconfEnabled, (value ? 1 : 0));
				}
			}

			public Wlan.Dot11BssType BssType
			{
				get
				{
					return this.GetInterfaceInt(Wlan.WlanIntfOpcode.BssType);
				}
				set
				{
					this.SetInterfaceInt(Wlan.WlanIntfOpcode.BssType, (Int32)value);
				}
			}

			public Int32 Channel
			{
				get
				{
					return this.GetInterfaceInt(Wlan.WlanIntfOpcode.ChannelNumber);
				}
			}

			public Wlan.WlanConnectionAttributes CurrentConnection
			{
				get
				{
					Int32 num;
					IntPtr intPtr;
					Wlan.WlanOpcodeValueType wlanOpcodeValueType;
					Wlan.WlanConnectionAttributes structure;
					Wlan.ThrowIfError(Wlan.WlanQueryInterface(this.client.clientHandle, this.info.interfaceGuid, Wlan.WlanIntfOpcode.CurrentConnection, IntPtr.Zero, out num, out intPtr, out wlanOpcodeValueType));
					try
					{
						structure = (Wlan.WlanConnectionAttributes)Marshal.PtrToStructure(intPtr, typeof(Wlan.WlanConnectionAttributes));
					}
					finally
					{
						Wlan.WlanFreeMemory(intPtr);
					}
					return structure;
				}
			}

			public Wlan.Dot11OperationMode CurrentOperationMode
			{
				get
				{
					return this.GetInterfaceInt(Wlan.WlanIntfOpcode.CurrentOperationMode);
				}
			}

			public String InterfaceDescription
			{
				get
				{
					return this.info.interfaceDescription;
				}
			}

			public Guid InterfaceGuid
			{
				get
				{
					return this.info.interfaceGuid;
				}
			}

			public String InterfaceName
			{
				get
				{
					return this.NetworkInterface.get_Name();
				}
			}

			public Wlan.WlanInterfaceState InterfaceState
			{
				get
				{
					return this.GetInterfaceInt(Wlan.WlanIntfOpcode.InterfaceState);
				}
			}

			public NetworkInterface NetworkInterface
			{
				get
				{
					NetworkInterface networkInterface;
					NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
					Int32 num = 0;
					while (true)
					{
						if (num < (Int32)allNetworkInterfaces.Length)
						{
							NetworkInterface networkInterface1 = allNetworkInterfaces[num];
							Guid guid = new Guid(networkInterface1.get_Id());
							if (!guid.Equals(this.info.interfaceGuid))
							{
								num++;
							}
							else
							{
								networkInterface = networkInterface1;
								break;
							}
						}
						else
						{
							networkInterface = null;
							break;
						}
					}
					return networkInterface;
				}
			}

			public Wlan.WlanRadioState RadioState
			{
				get
				{
					Int32 num;
					IntPtr intPtr;
					Wlan.WlanOpcodeValueType wlanOpcodeValueType;
					Wlan.WlanRadioState structure;
					Wlan.ThrowIfError(Wlan.WlanQueryInterface(this.client.clientHandle, this.info.interfaceGuid, Wlan.WlanIntfOpcode.RadioState, IntPtr.Zero, out num, out intPtr, out wlanOpcodeValueType));
					try
					{
						structure = (Wlan.WlanRadioState)Marshal.PtrToStructure(intPtr, typeof(Wlan.WlanRadioState));
					}
					finally
					{
						Wlan.WlanFreeMemory(intPtr);
					}
					return structure;
				}
			}

			public Int32 RSSI
			{
				get
				{
					return this.GetInterfaceInt(Wlan.WlanIntfOpcode.RSSI);
				}
			}

			internal WlanInterface(WlanClient client, Wlan.WlanInterfaceInfo info)
			{
				this.client = client;
				this.info = info;
			}

			protected Void Connect(Wlan.WlanConnectionParameters connectionParams)
			{
				Wlan.ThrowIfError(Wlan.WlanConnect(this.client.clientHandle, this.info.interfaceGuid, ref connectionParams, IntPtr.Zero));
			}

			public Void Connect(Wlan.WlanConnectionMode connectionMode, Wlan.Dot11BssType bssType, String profile)
			{
				Wlan.WlanConnectionParameters wlanConnectionParameter = new Wlan.WlanConnectionParameters()
				{
					wlanConnectionMode = connectionMode,
					profile = profile,
					dot11BssType = bssType,
					flags = 0
				};
				this.Connect(wlanConnectionParameter);
			}

			public Void Connect(Wlan.WlanConnectionMode connectionMode, Wlan.Dot11BssType bssType, Wlan.Dot11Ssid ssid, Wlan.WlanConnectionFlags flags)
			{
				Wlan.WlanConnectionParameters wlanConnectionParameter = new Wlan.WlanConnectionParameters()
				{
					wlanConnectionMode = connectionMode,
					dot11SsidPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ssid))
				};
				Marshal.StructureToPtr(ssid, wlanConnectionParameter.dot11SsidPtr, false);
				wlanConnectionParameter.dot11BssType = bssType;
				wlanConnectionParameter.flags = flags;
				this.Connect(wlanConnectionParameter);
				Marshal.DestroyStructure(wlanConnectionParameter.dot11SsidPtr, ssid.GetType());
				Marshal.FreeHGlobal(wlanConnectionParameter.dot11SsidPtr);
			}

			public Boolean ConnectSynchronously(Wlan.WlanConnectionMode connectionMode, Wlan.Dot11BssType bssType, String profile, Int32 connectTimeout)
			{
				Boolean flag;
				this.queueEvents = true;
				try
				{
					this.Connect(connectionMode, bssType, profile);
					while (true)
					{
						if ((!this.queueEvents ? true : !this.eventQueueFilled.WaitOne(connectTimeout, true)))
						{
							break;
						}
						lock (this.eventQueue)
						{
							while (this.eventQueue.get_Count() != 0)
							{
								Object obj = this.eventQueue.Dequeue();
								if (obj is WlanClient.WlanInterface.WlanConnectionNotificationEventData)
								{
									WlanClient.WlanInterface.WlanConnectionNotificationEventData wlanConnectionNotificationEventDatum = (WlanClient.WlanInterface.WlanConnectionNotificationEventData)obj;
									if (wlanConnectionNotificationEventDatum.notifyData.notificationSource == Wlan.WlanNotificationSource.ACM)
									{
										if (wlanConnectionNotificationEventDatum.notifyData.notificationCode == 10)
										{
											if (wlanConnectionNotificationEventDatum.connNotifyData.profileName == profile)
											{
												flag = true;
												return flag;
											}
										}
									}
									break;
								}
							}
						}
					}
				}
				finally
				{
					this.queueEvents = false;
					this.eventQueue.Clear();
				}
				flag = false;
				return flag;
			}

			private static Wlan.WlanAvailableNetwork[] ConvertAvailableNetworkListPtr(IntPtr availNetListPtr)
			{
				Wlan.WlanAvailableNetworkListHeader structure = (Wlan.WlanAvailableNetworkListHeader)Marshal.PtrToStructure(availNetListPtr, typeof(Wlan.WlanAvailableNetworkListHeader));
				Int64 num = availNetListPtr.ToInt64() + (Int64)Marshal.SizeOf(typeof(Wlan.WlanAvailableNetworkListHeader));
				Wlan.WlanAvailableNetwork[] wlanAvailableNetworkArray = new Wlan.WlanAvailableNetwork[structure.numberOfItems];
				for (Int32 i = 0; (Int64)i < (UInt64)structure.numberOfItems; i++)
				{
					wlanAvailableNetworkArray[i] = (Wlan.WlanAvailableNetwork)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanAvailableNetwork));
					num += (Int64)Marshal.SizeOf(typeof(Wlan.WlanAvailableNetwork));
				}
				return wlanAvailableNetworkArray;
			}

			private static Wlan.WlanBssEntry[] ConvertBssListPtr(IntPtr bssListPtr)
			{
				Wlan.WlanBssListHeader structure = (Wlan.WlanBssListHeader)Marshal.PtrToStructure(bssListPtr, typeof(Wlan.WlanBssListHeader));
				Int64 num = bssListPtr.ToInt64() + (Int64)Marshal.SizeOf(typeof(Wlan.WlanBssListHeader));
				Wlan.WlanBssEntry[] wlanBssEntryArray = new Wlan.WlanBssEntry[structure.numberOfItems];
				for (Int32 i = 0; (Int64)i < (UInt64)structure.numberOfItems; i++)
				{
					wlanBssEntryArray[i] = (Wlan.WlanBssEntry)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanBssEntry));
					num += (Int64)Marshal.SizeOf(typeof(Wlan.WlanBssEntry));
				}
				return wlanBssEntryArray;
			}

			public Void DeleteProfile(String profileName)
			{
				Wlan.ThrowIfError(Wlan.WlanDeleteProfile(this.client.clientHandle, this.info.interfaceGuid, profileName, IntPtr.Zero));
			}

			private Void EnqueueEvent(Object queuedEvent)
			{
				lock (this.eventQueue)
				{
					this.eventQueue.Enqueue(queuedEvent);
				}
				this.eventQueueFilled.Set();
			}

			public Wlan.WlanAvailableNetwork[] GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags flags)
			{
				IntPtr intPtr;
				Wlan.WlanAvailableNetwork[] wlanAvailableNetworkArray;
				Wlan.ThrowIfError(Wlan.WlanGetAvailableNetworkList(this.client.clientHandle, this.info.interfaceGuid, flags, IntPtr.Zero, out intPtr));
				try
				{
					wlanAvailableNetworkArray = WlanClient.WlanInterface.ConvertAvailableNetworkListPtr(intPtr);
				}
				finally
				{
					Wlan.WlanFreeMemory(intPtr);
				}
				return wlanAvailableNetworkArray;
			}

			private Int32 GetInterfaceInt(Wlan.WlanIntfOpcode opCode)
			{
				Int32 num;
				IntPtr intPtr;
				Wlan.WlanOpcodeValueType wlanOpcodeValueType;
				Int32 num1;
				Wlan.ThrowIfError(Wlan.WlanQueryInterface(this.client.clientHandle, this.info.interfaceGuid, opCode, IntPtr.Zero, out num, out intPtr, out wlanOpcodeValueType));
				try
				{
					num1 = Marshal.ReadInt32(intPtr);
				}
				finally
				{
					Wlan.WlanFreeMemory(intPtr);
				}
				return num1;
			}

			public Wlan.WlanBssEntry[] GetNetworkBssList()
			{
				IntPtr intPtr;
				Wlan.WlanBssEntry[] wlanBssEntryArray;
				Wlan.ThrowIfError(Wlan.WlanGetNetworkBssList(this.client.clientHandle, this.info.interfaceGuid, IntPtr.Zero, Wlan.Dot11BssType.Any, false, IntPtr.Zero, out intPtr));
				try
				{
					wlanBssEntryArray = WlanClient.WlanInterface.ConvertBssListPtr(intPtr);
				}
				finally
				{
					Wlan.WlanFreeMemory(intPtr);
				}
				return wlanBssEntryArray;
			}

			public Wlan.WlanBssEntry[] GetNetworkBssList(Wlan.Dot11Ssid ssid, Wlan.Dot11BssType bssType, Boolean securityEnabled)
			{
				IntPtr intPtr;
				Wlan.WlanBssEntry[] wlanBssEntryArray;
				IntPtr intPtr1 = Marshal.AllocHGlobal(Marshal.SizeOf(ssid));
				Marshal.StructureToPtr(ssid, intPtr1, false);
				try
				{
					Wlan.ThrowIfError(Wlan.WlanGetNetworkBssList(this.client.clientHandle, this.info.interfaceGuid, intPtr1, bssType, securityEnabled, IntPtr.Zero, out intPtr));
					try
					{
						wlanBssEntryArray = WlanClient.WlanInterface.ConvertBssListPtr(intPtr);
					}
					finally
					{
						Wlan.WlanFreeMemory(intPtr);
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr1);
				}
				return wlanBssEntryArray;
			}

			public Wlan.WlanProfileInfo[] GetProfiles()
			{
				IntPtr intPtr;
				Wlan.WlanProfileInfo[] wlanProfileInfoArray;
				Wlan.ThrowIfError(Wlan.WlanGetProfileList(this.client.clientHandle, this.info.interfaceGuid, IntPtr.Zero, out intPtr));
				try
				{
					Wlan.WlanProfileInfoListHeader structure = (Wlan.WlanProfileInfoListHeader)Marshal.PtrToStructure(intPtr, typeof(Wlan.WlanProfileInfoListHeader));
					Wlan.WlanProfileInfo[] wlanProfileInfoArray1 = new Wlan.WlanProfileInfo[structure.numberOfItems];
					Int64 num = intPtr.ToInt64() + (Int64)Marshal.SizeOf(structure);
					for (Int32 i = 0; (Int64)i < (UInt64)structure.numberOfItems; i++)
					{
						Wlan.WlanProfileInfo wlanProfileInfo = (Wlan.WlanProfileInfo)Marshal.PtrToStructure(new IntPtr(num), typeof(Wlan.WlanProfileInfo));
						wlanProfileInfoArray1[i] = wlanProfileInfo;
						num += (Int64)Marshal.SizeOf(wlanProfileInfo);
					}
					wlanProfileInfoArray = wlanProfileInfoArray1;
				}
				finally
				{
					Wlan.WlanFreeMemory(intPtr);
				}
				return wlanProfileInfoArray;
			}

			public String GetProfileXml(String profileName)
			{
				IntPtr intPtr;
				Wlan.WlanProfileFlags wlanProfileFlag;
				Wlan.WlanAccess wlanAccess;
				String stringUni;
				Wlan.ThrowIfError(Wlan.WlanGetProfile(this.client.clientHandle, this.info.interfaceGuid, profileName, IntPtr.Zero, out intPtr, out wlanProfileFlag, out wlanAccess));
				try
				{
					stringUni = Marshal.PtrToStringUni(intPtr);
				}
				finally
				{
					Wlan.WlanFreeMemory(intPtr);
				}
				return stringUni;
			}

			internal Void OnWlanConnection(Wlan.WlanNotificationData notifyData, Wlan.WlanConnectionNotificationData connNotifyData)
			{
				if (this.WlanConnectionNotification != null)
				{
					this.WlanConnectionNotification(notifyData, connNotifyData);
				}
				if (this.queueEvents)
				{
					WlanClient.WlanInterface.WlanConnectionNotificationEventData wlanConnectionNotificationEventDatum = new WlanClient.WlanInterface.WlanConnectionNotificationEventData()
					{
						notifyData = notifyData,
						connNotifyData = connNotifyData
					};
					this.EnqueueEvent(wlanConnectionNotificationEventDatum);
				}
			}

			internal Void OnWlanNotification(Wlan.WlanNotificationData notifyData)
			{
				if (this.WlanNotification != null)
				{
					this.WlanNotification(notifyData);
				}
			}

			internal Void OnWlanReason(Wlan.WlanNotificationData notifyData, Wlan.WlanReasonCode reasonCode)
			{
				if (this.WlanReasonNotification != null)
				{
					this.WlanReasonNotification(notifyData, reasonCode);
				}
				if (this.queueEvents)
				{
					WlanClient.WlanInterface.WlanReasonNotificationData wlanReasonNotificationDatum = new WlanClient.WlanInterface.WlanReasonNotificationData()
					{
						notifyData = notifyData,
						reasonCode = reasonCode
					};
					this.EnqueueEvent(wlanReasonNotificationDatum);
				}
			}

			public Void Scan()
			{
				Wlan.ThrowIfError(Wlan.WlanScan(this.client.clientHandle, this.info.interfaceGuid, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));
			}

			private Void SetInterfaceInt(Wlan.WlanIntfOpcode opCode, Int32 value)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(4);
				Marshal.WriteInt32(intPtr, value);
				try
				{
					Wlan.ThrowIfError(Wlan.WlanSetInterface(this.client.clientHandle, this.info.interfaceGuid, opCode, 4, intPtr, IntPtr.Zero));
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}

			public Wlan.WlanReasonCode SetProfile(Wlan.WlanProfileFlags flags, String profileXml, Boolean overwrite)
			{
				Wlan.WlanReasonCode wlanReasonCode;
				Wlan.ThrowIfError(Wlan.WlanSetProfile(this.client.clientHandle, this.info.interfaceGuid, flags, profileXml, null, overwrite, IntPtr.Zero, out wlanReasonCode));
				return wlanReasonCode;
			}

			public event WlanClient.WlanInterface.WlanConnectionNotificationEventHandler WlanConnectionNotification;

			public event WlanClient.WlanInterface.WlanNotificationEventHandler WlanNotification;

			public event WlanClient.WlanInterface.WlanReasonNotificationEventHandler WlanReasonNotification;

			private struct WlanConnectionNotificationEventData
			{
				public Wlan.WlanNotificationData notifyData;

				public Wlan.WlanConnectionNotificationData connNotifyData;
			}

			public delegate Void WlanConnectionNotificationEventHandler(Wlan.WlanNotificationData notifyData, Wlan.WlanConnectionNotificationData connNotifyData);

			public delegate Void WlanNotificationEventHandler(Wlan.WlanNotificationData notifyData);

			private struct WlanReasonNotificationData
			{
				public Wlan.WlanNotificationData notifyData;

				public Wlan.WlanReasonCode reasonCode;
			}

			public delegate Void WlanReasonNotificationEventHandler(Wlan.WlanNotificationData notifyData, Wlan.WlanReasonCode reasonCode);
		}
	}
}