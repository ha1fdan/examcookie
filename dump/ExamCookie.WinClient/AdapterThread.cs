using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NativeWifi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ExamCookie.WinClient
{
	public class AdapterThread
	{
		private const Int32 THREAD_SLEEP = 500;

		private Boolean _Started;

		public Boolean Started
		{
			get
			{
				return this._Started;
			}
			set
			{
				this._Started = value;
			}
		}

		public AdapterThread()
		{
			this._Started = false;
		}

		public AdapterThread(Int32 polltime)
		{
			Int32 num = polltime;
			base();
			AdapterThread._Closureu0024__17u002d0 variable = null;
			this._Started = false;
			if (num > 0)
			{
				if (num < 500)
				{
					num = 500;
				}
				Thread thread = new Thread(new ThreadStart(variable, () => this.u0024VBu0024Me.Main(this.u0024VBu0024Local_polltime)));
				this.Started = true;
				thread.Start();
			}
		}

		private Int32 GetSSID(String description, ref String ssid)
		{
			Int32 num;
			try
			{
				WlanClient.WlanInterface[] interfaces = (new WlanClient()).Interfaces;
				for (Int32 i = 0; i < (Int32)interfaces.Length; i = checked(i + 1))
				{
					WlanClient.WlanInterface wlanInterface = interfaces[i];
					if ((object)wlanInterface != (object)null)
					{
						if (wlanInterface.InterfaceState == Wlan.WlanInterfaceState.Connected)
						{
							Wlan.Dot11Ssid currentConnection = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
							if ((object)wlanInterface.NetworkInterface != (object)null)
							{
								if (wlanInterface.NetworkInterface.get_NetworkInterfaceType() == 71)
								{
									ssid = new String(Encoding.get_ASCII().GetChars(currentConnection.SSID, 0, (Void*)(checked((Int32)currentConnection.SSIDLength))));
									num = 0;
									return num;
								}
							}
						}
					}
				}
				num = 1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public Dictionary<String, String> IpConfig()
		{
			IEnumerator<UnicastIPAddressInformation> enumerator = null;
			Dictionary<String, String> dictionary;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				List<String> list = new List<String>();
				Dictionary<String, String> dictionary1 = new Dictionary<String, String>();
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				for (Int32 i = 0; i < (Int32)allNetworkInterfaces.Length; i = checked(i + 1))
				{
					NetworkInterface networkInterface = allNetworkInterfaces[i];
					try
					{
						IPInterfaceProperties pProperties = networkInterface.GetIPProperties();
						stringBuilder.AppendLineFormat("{0}:", new Object[] { networkInterface.get_Description() });
						stringBuilder.AppendLine();
						stringBuilder.AppendLineFormat("   OperationalStatus ........ : {0}", new Object[] { networkInterface.get_OperationalStatus().ToString() });
						if (networkInterface.get_OperationalStatus() == 1)
						{
							String str = "";
							if (this.GetSSID(networkInterface.get_Description(), ref str) == 0)
							{
								stringBuilder.AppendLineFormat("   SSID ..................... : {0}", new Object[] { str });
							}
							stringBuilder.AppendLineFormat("   PhysicalMACAddress ....... : {0}", new Object[] { Module1.ToMACAddress(networkInterface.GetPhysicalAddress().GetAddressBytes()) });
							try
							{
								enumerator = networkInterface.GetIPProperties().get_UnicastAddresses().GetEnumerator();
								while (enumerator.MoveNext())
								{
									IPAddressInformation current = enumerator.get_Current();
									stringBuilder.AppendLineFormat("   {0} ............. : {1}", new Object[] { Interaction.IIf(current.get_Address().ToString().Contains("::"), "IPv6 Address", "IP-Address  "), current.get_Address().ToString() });
								}
							}
							finally
							{
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							stringBuilder.AppendLineFormat("   DHCP enabled ............. : {0}", new Object[] { pProperties.GetIPv4Properties().get_IsDhcpEnabled() });
							if (pProperties.get_DhcpServerAddresses().get_Count() > 0)
							{
								list.Clear();
								Int32 count = checked(pProperties.get_DhcpServerAddresses().get_Count() - 1);
								for (Int32 j = 0; j <= count; j = checked(j + 1))
								{
									list.Add(pProperties.get_DhcpServerAddresses().get_Item(j).ToString());
								}
								stringBuilder.AppendLineFormat("   DHCP servers ............. : {0}", new Object[] { Strings.Join(list.ToArray(), ", ") });
							}
							if (pProperties.get_GatewayAddresses().get_Count() > 0)
							{
								list.Clear();
								Int32 num = checked(pProperties.get_GatewayAddresses().get_Count() - 1);
								for (Int32 k = 0; k <= num; k = checked(k + 1))
								{
									list.Add(pProperties.get_GatewayAddresses().get_Item(k).get_Address().ToString());
								}
								stringBuilder.AppendLineFormat("   Default Gateway .......... : {0}", new Object[] { Strings.Join(list.ToArray(), ", ") });
							}
							stringBuilder.AppendLineFormat("   DNS enabled .............. : {0}", new Object[] { pProperties.get_IsDnsEnabled() });
							stringBuilder.AppendLineFormat("   Dynamically configured DNS : {0}", new Object[] { pProperties.get_IsDynamicDnsEnabled() });
						}
						dictionary1.Add(networkInterface.get_Id(), stringBuilder.ToString());
						stringBuilder.Clear();
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception exception = exception1;
						AdapterThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
						if (onExceptionEventHandler != null)
						{
							onExceptionEventHandler(exception);
						}
						ProjectData.ClearProjectError();
					}
				}
				dictionary = dictionary1;
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				Exception exception2 = exception3;
				AdapterThread.OnExceptionEventHandler onExceptionEventHandler1 = this.OnException;
				if (onExceptionEventHandler1 != null)
				{
					onExceptionEventHandler1(exception2);
				}
				dictionary = null;
				ProjectData.ClearProjectError();
			}
			return dictionary;
		}

		private Void Main(Int32 polltime)
		{
			Dictionary<String, String>.Enumerator enumerator = new Dictionary<String, String>.Enumerator();
			Dictionary<String, String>.Enumerator enumerator1 = new Dictionary<String, String>.Enumerator();
			Dictionary<String, String>.Enumerator enumerator2 = new Dictionary<String, String>.Enumerator();
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary<String, String> dictionary = new Dictionary<String, String>();
			List<String> list = new List<String>();
			while (this.Started)
			{
				try
				{
					try
					{
						if (stopwatch.get_ElapsedMilliseconds() >= (Int64)polltime)
						{
							stopwatch.Restart();
							list.Clear();
							if (dictionary.get_Count() != 0)
							{
								Dictionary<String, String> dictionary1 = this.IpConfig();
								try
								{
									enumerator1 = dictionary1.GetEnumerator();
									while (enumerator1.MoveNext())
									{
										KeyValuePair<String, String> current = enumerator1.get_Current();
										if (!dictionary.ContainsKey(current.get_Key()))
										{
											list.Add(current.get_Value());
										}
										else if (Operators.CompareString(dictionary.get_Item(current.get_Key()), current.get_Value(), false) != 0)
										{
											list.Add(current.get_Value());
										}
									}
								}
								finally
								{
									enumerator1.Dispose();
								}
								dictionary.Clear();
								try
								{
									enumerator2 = dictionary1.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										KeyValuePair<String, String> keyValuePair = enumerator2.get_Current();
										dictionary.Add(keyValuePair.get_Key(), keyValuePair.get_Value());
									}
								}
								finally
								{
									enumerator2.Dispose();
								}
							}
							else
							{
								dictionary = this.IpConfig();
								try
								{
									enumerator = dictionary.GetEnumerator();
									while (enumerator.MoveNext())
									{
										list.Add(enumerator.get_Current().get_Value());
									}
								}
								finally
								{
									enumerator.Dispose();
								}
							}
							if (list.get_Count() > 0)
							{
								AdapterThread.OnAdapterChangedEventHandler onAdapterChangedEventHandler = this.OnAdapterChanged;
								if (onAdapterChangedEventHandler != null)
								{
									onAdapterChangedEventHandler(new AdapterThread.AdapterChanged(String.Concat(Strings.Join(list.ToArray(), "|"), "\r\n")));
								}
							}
						}
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception exception = exception1;
						AdapterThread.OnExceptionEventHandler onExceptionEventHandler = this.OnException;
						if (onExceptionEventHandler != null)
						{
							onExceptionEventHandler(exception);
						}
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					Thread.Sleep(500);
				}
			}
		}

		public event AdapterThread.OnAdapterChangedEventHandler OnAdapterChanged;

		public event AdapterThread.OnDebugEventHandler OnDebug;

		public event AdapterThread.OnExceptionEventHandler OnException;

		[Serializable]
		public class AdapterChanged
		{
			public String Reference;

			public String Token;

			public DateTime CanSend;

			public DateTime TimeStamp;

			public String Data;

			public AdapterChanged()
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Data = "";
			}

			public AdapterChanged(String data)
			{
				this.Reference = Guid.NewGuid().ToString();
				this.Token = "";
				this.CanSend = DateTime.MinValue;
				this.TimeStamp = DateTime.MinValue;
				this.Data = "";
				this.Data = data;
			}
		}

		public delegate Void OnAdapterChangedEventHandler(AdapterThread.AdapterChanged sender);

		public delegate Void OnDebugEventHandler(String message);

		public delegate Void OnExceptionEventHandler(Exception ex);
	}
}