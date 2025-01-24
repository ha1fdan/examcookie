using ExamCookie.Library;
using ExamCookie.WinClient.ExamApiV3Service;
using ExamCookie.WinClient.My;
using ExamCookie.WinClient.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExamCookie.WinClient
{
	internal static class Module1
	{
		public static String APP_DATA_PATH;

		public static String APP_FILENAME;

		public static String APP_CURRENT_DIR;

		public static String APP_CURRENT_USER;

		public static String OFFLINE_PACKAGE_FOLDER;

		public static Object PACKAGE_FILE_EXTENSION;

		public static Int32 WM_DETECT;

		public static String USER_SIGN_IN_TOKEN;

		public static Boolean USER_SIGNED_OUT;

		public static Boolean USER_SIGN_OUT_SUCCESS;

		public static Int32 FORCE_CLOSE_DELAY;

		public static Boolean LOG_SESSION;

		public static Boolean LOG_SESSION_LOCAL;

		public static String UNI_AUTH_CODE;

		public static String UNI_CODE_VERIFIER;

		public static String UNI_SIGNIN_TOKEN;

		public static String ID_TOKEN_HINT;

		public static String UNI_LOGOUT_URL;

		public static String UNI_REDIRECT_SUCCESS_URL;

		public static String UNI_REDIRECT_LOGOUT_URL;

		public static ParameterOut Config;

		public static List<ExamCookie.WinClient.ClientError> ClientReport;

		public static List<String> SessionLog;

		public static String LastError;

		static Module1()
		{
			Module1.APP_DATA_PATH = "C:\\Temp\\ExamCookie\\AppData";
			Module1.APP_FILENAME = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
			Module1.APP_CURRENT_DIR = Directory.GetCurrentDirectory();
			Module1.APP_CURRENT_USER = WindowsIdentity.GetCurrent().get_Name();
			Module1.OFFLINE_PACKAGE_FOLDER = "ecoffline";
			Module1.PACKAGE_FILE_EXTENSION = "ecpck";
			Module1.WM_DETECT = 0;
			Module1.USER_SIGN_IN_TOKEN = "";
			Module1.USER_SIGNED_OUT = false;
			Module1.USER_SIGN_OUT_SUCCESS = false;
			Module1.FORCE_CLOSE_DELAY = 10;
			Module1.LOG_SESSION = true;
			Module1.LOG_SESSION_LOCAL = false;
			Module1.UNI_AUTH_CODE = "";
			Module1.UNI_CODE_VERIFIER = "";
			Module1.UNI_SIGNIN_TOKEN = "";
			Module1.ID_TOKEN_HINT = "";
			Module1.UNI_LOGOUT_URL = "https://sso.emu.dk/logout";
			Module1.UNI_REDIRECT_SUCCESS_URL = "https://examcookieclientui.azurewebsites.net/success.html";
			Module1.UNI_REDIRECT_LOGOUT_URL = "https://et-broker.unilogin.dk/auth/realms/broker/protocol/openid-connect/logout";
			Module1.Config = new ParameterOut();
			Module1.ClientReport = new List<ExamCookie.WinClient.ClientError>();
			Module1.SessionLog = new List<String>();
			Module1.LastError = "";
		}

		public static StringBuilder AppendLineFormat(this StringBuilder value, String format, params Object[] args)
		{
			StringBuilder stringBuilder = value.Append(String.Concat(String.Format(format, args), "\r\n"));
			return stringBuilder;
		}

		public static Boolean Containing(this String value, String item)
		{
			Boolean flag = value.ToLower().IndexOf(item.ToLower()) >= 0;
			return flag;
		}

		public static Boolean Containing(this String value, String[] items)
		{
			Boolean flag;
			String[] strArray = items;
			Int32 num = 0;
			while (true)
			{
				if (num >= (Int32)strArray.Length)
				{
					flag = false;
					break;
				}
				else if (!value.Containing(strArray[num]))
				{
					num = checked(num + 1);
				}
				else
				{
					flag = true;
					break;
				}
			}
			return flag;
		}

		public static String CreateFolderWithFullControl(String folder, String username)
		{
			String message;
			try
			{
				if (!Directory.Exists(folder))
				{
					Directory.CreateDirectory(folder);
				}
				DirectorySecurity directorySecurity = new DirectorySecurity();
				directorySecurity.AddAccessRule(new FileSystemAccessRule(username, 2032127, 3, 0, 0));
				Directory.GetAccessControl(folder);
				Directory.SetAccessControl(folder, directorySecurity);
				message = "";
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				message = exception.get_Message();
				ProjectData.ClearProjectError();
			}
			return message;
		}

		public static Void DebugPrint(String message, params Object[] args)
		{
			try
			{
				Debug.Print(message, args);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		public static Int32 DeserializeFromFile(String filename, ref Object obj)
		{
			Int32 num;
			try
			{
				if (!File.Exists(filename))
				{
					num = 1;
				}
				else
				{
					FileStream fileStream = new FileStream(filename, 3);
					try
					{
						if (fileStream.get_Length() != (Int64)0)
						{
							BinaryFormatter binaryFormatter = new BinaryFormatter();
							obj = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(fileStream));
							num = 0;
						}
						else
						{
							num = 2;
						}
					}
					finally
					{
						if (fileStream != null)
						{
							fileStream.Dispose();
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Int32 DeserializeFromFileDecrypted(String filename, ref Object obj)
		{
			Int32 num;
			try
			{
				if (!File.Exists(filename))
				{
					num = 1;
				}
				else
				{
					Rijndael rijndael = Rijndael.Create();
					try
					{
						FileStream fileStream = new FileStream(filename, 3);
						try
						{
							if (fileStream.get_Length() != (Int64)0)
							{
								Byte[] numArray = null;
								Byte[] numArray1 = null;
								Module1.GetCryptoKeyPair(ref numArray, ref numArray1);
								ICryptoTransform cryptoTransform = rijndael.CreateDecryptor(numArray, numArray1);
								CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoTransform, 0);
								try
								{
									BinaryFormatter binaryFormatter = new BinaryFormatter();
									obj = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(cryptoStream));
									num = 0;
								}
								finally
								{
									if (cryptoStream != null)
									{
										cryptoStream.Dispose();
									}
								}
							}
							else
							{
								num = 2;
							}
						}
						finally
						{
							if (fileStream != null)
							{
								fileStream.Dispose();
							}
						}
					}
					finally
					{
						if (rijndael != null)
						{
							rijndael.Dispose();
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Int32 DeserializeFromXmlFile(String filename, ref Object obj)
		{
			Int32 num;
			num = ((object)obj != (object)null ? Module1.DeserializeFromXmlFile(filename, obj.GetType(), ref obj) : 1);
			return num;
		}

		public static Int32 DeserializeFromXmlFile(String filename, Type type, ref Object obj)
		{
			Int32 num;
			try
			{
				if (!File.Exists(filename))
				{
					num = 1;
				}
				else
				{
					StreamReader streamReader = new StreamReader(filename);
					try
					{
						if (streamReader.get_EndOfStream())
						{
							num = 2;
						}
						else
						{
							obj = RuntimeHelpers.GetObjectValue(Module1.DeSerializeFromXmlString(streamReader.ReadToEnd(), type));
							num = ((object)obj == (object)null ? 3 : 0);
						}
					}
					finally
					{
						if (streamReader != null)
						{
							streamReader.Dispose();
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Object DeSerializeFromXmlString(String obj, Type type)
		{
			Object obj1;
			try
			{
				if (obj == null)
				{
					obj1 = null;
				}
				else if (Operators.CompareString(obj, "", false) != 0)
				{
					StringReader stringReader = new StringReader(obj);
					try
					{
						obj1 = (new XmlSerializer(type)).Deserialize(stringReader);
					}
					finally
					{
						if (stringReader != null)
						{
							stringReader.Dispose();
						}
					}
				}
				else
				{
					obj1 = null;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				obj1 = null;
				ProjectData.ClearProjectError();
			}
			return obj1;
		}

		[DllImport("user32.dll", CharSet=1, ExactSpelling=false)]
		public static extern Boolean EnumDisplaySettings(String lpszDeviceName, Int32 iModeNum, ref Module1.DEVMODE lpDevMode);

		public static ExamApiV3Client ExamClient()
		{
			ExamApiV3Client examApiV3Client;
			try
			{
				CustomBinding customBinding = new CustomBinding();
				customBinding.set_Name("CustomBinding_IExamApiV3");
				ServicePointManager.set_SecurityProtocol(3072);
				SecurityBindingElement securityBindingElement = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
				securityBindingElement.set_DefaultAlgorithmSuite(SecurityAlgorithmSuite.get_Default());
				securityBindingElement.set_MessageSecurityVersion(MessageSecurityVersion.get_WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10());
				securityBindingElement.set_IncludeTimestamp(false);
				securityBindingElement.get_LocalClientSettings().set_DetectReplays(false);
				securityBindingElement.get_LocalServiceSettings().set_DetectReplays(false);
				customBinding.get_Elements().Add(securityBindingElement);
				MtomMessageEncodingBindingElement mtomMessageEncodingBindingElement = new MtomMessageEncodingBindingElement();
				mtomMessageEncodingBindingElement.set_MessageVersion(MessageVersion.get_Soap11());
				customBinding.get_Elements().Add(mtomMessageEncodingBindingElement);
				customBinding.get_Elements().Add(new HttpsTransportBindingElement());
				examApiV3Client = new ExamApiV3Client(customBinding, new EndpointAddress(String.Concat(Resources.WCF_ENDPOINT, "/ExamApiV3.svc")));
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				examApiV3Client = null;
				ProjectData.ClearProjectError();
			}
			return examApiV3Client;
		}

		public static String FormatExamEndTime(DateTime timeEnd, Int32 timeExt, String timeFormat = "HH:mm:ss")
		{
			String str;
			if (timeExt != 0)
			{
				TimeSpan timeSpan = TimeSpan.FromMinutes((Double)timeExt);
				str = String.Format("{0} +{1}", Strings.Format(timeEnd, timeFormat), String.Format("{0:00}:{1:00}", Math.Floor(timeSpan.get_TotalHours()), timeSpan.get_Minutes()));
			}
			else
			{
				str = Strings.Format(timeEnd, timeFormat);
			}
			return str;
		}

		public static Byte[] GetBytes(this String value)
		{
			Byte[] numArray = new Byte[checked(checked(value.get_Length() - 1) + 1)];
			Buffer.BlockCopy(value.ToCharArray(), 0, numArray, 0, (Int32)numArray.Length);
			return numArray;
		}

		public static String GetClientErrorLog()
		{
			String str;
			try
			{
				str = (Module1.ClientReport.get_Count() != 0 ? Module1.SerializeToXmlString(Module1.ClientReport.ToArray(), false) : "");
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static Void GetCryptoKeyPair(ref Byte[] key, ref Byte[] iv)
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			key = mD5CryptoServiceProvider.ComputeHash(Encoding.get_UTF8().GetBytes(current.get_User().get_Value()));
			iv = mD5CryptoServiceProvider.ComputeHash(Encoding.get_UTF8().GetBytes(current.get_Name()));
		}

		public static Byte[,] GetDifferences(this Image img1, Image img2)
		{
			Byte[,] numArray;
			img1.Resize(16, 16);
			Bitmap grayScaleVersion = (Bitmap)img1.Resize(16, 16).GetGrayScaleVersion();
			try
			{
				Bitmap bitmap = (Bitmap)img2.Resize(16, 16).GetGrayScaleVersion();
				try
				{
					Byte[,] numArray1 = new Byte[16, 16];
					Byte[,] grayScaleValues = grayScaleVersion.GetGrayScaleValues();
					Byte[,] grayScaleValues1 = bitmap.GetGrayScaleValues();
					Int32 num = 0;
					do
					{
						Int32 num1 = 0;
						do
						{
							numArray1[num1, num] = checked((Byte)Math.Abs((Int32)(checked(grayScaleValues[num1, num] - grayScaleValues1[num1, num]))));
							num1 = checked(num1 + 1);
						}
						while (num1 <= 15);
						num = checked(num + 1);
					}
					while (num <= 15);
					numArray = numArray1;
				}
				finally
				{
					if (bitmap != null)
					{
						bitmap.Dispose();
					}
				}
			}
			finally
			{
				if (grayScaleVersion != null)
				{
					grayScaleVersion.Dispose();
				}
			}
			return numArray;
		}

		[DllImport("Shcore.dll", CharSet=1, ExactSpelling=false)]
		public static extern Int32 GetDpiForMonitor(IntPtr hmonitor, Int32 dpiType, ref UInt32 dpiX, ref UInt32 dpiY);

		public static String GetFileversion()
		{
			return Application.get_ProductVersion();
		}

		public static Byte[,] GetGrayScaleValues(this Image img)
		{
			Byte[,] numArray;
			Bitmap grayScaleVersion = (Bitmap)img.Resize(16, 16).GetGrayScaleVersion();
			try
			{
				Byte[,] numArray1 = new Byte[16, 16];
				Int32 num = 0;
				do
				{
					Int32 num1 = 0;
					do
					{
						Color pixel = grayScaleVersion.GetPixel(num1, num);
						numArray1[num1, num] = checked((Byte)Math.Abs((Int16)pixel.get_R()));
						num1 = checked(num1 + 1);
					}
					while (num1 <= 15);
					num = checked(num + 1);
				}
				while (num <= 15);
				numArray = numArray1;
			}
			finally
			{
				if (grayScaleVersion != null)
				{
					grayScaleVersion.Dispose();
				}
			}
			return numArray;
		}

		public static Image GetGrayScaleVersion(this Image original)
		{
			Image image;
			Single[][] singleArray = new Single[][] { new Single[] { 0.3f, 0.3f, 0.3f, 0f, 0f }, new Single[] { 0.59f, 0.59f, 0.59f, 0f, 0f }, new Single[] { 0.11f, 0.11f, 0.11f, 0f, 0f }, default(Single[]), default(Single[]) };
			singleArray[3] = new Single[] { default(Single), default(Single), default(Single), 1f, default(Single) };
			singleArray[4] = new Single[] { default(Single), default(Single), default(Single), default(Single), 1f };
			ColorMatrix colorMatrix = new ColorMatrix(singleArray);
			Bitmap bitmap = new Bitmap(original.get_Width(), original.get_Height());
			try
			{
				Graphics graphic = Graphics.FromImage(bitmap);
				try
				{
					ImageAttributes imageAttribute = new ImageAttributes();
					try
					{
						imageAttribute.SetColorMatrix(colorMatrix);
						graphic.DrawImage(original, new Rectangle(0, 0, original.get_Width(), original.get_Height()), 0, 0, original.get_Width(), original.get_Height(), 2, imageAttribute);
					}
					finally
					{
						if (imageAttribute != null)
						{
							imageAttribute.Dispose();
						}
					}
				}
				finally
				{
					if (graphic != null)
					{
						graphic.Dispose();
					}
				}
				image = (Image)bitmap.Clone();
			}
			finally
			{
				if (bitmap != null)
				{
					bitmap.Dispose();
				}
			}
			return image;
		}

		public static String GetMD5Hash(String value)
		{
			String lower;
			MD5 mD5 = MD5.Create();
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				Byte[] numArray = mD5.ComputeHash(Encoding.get_UTF8().GetBytes(value));
				for (Int32 i = 0; i < (Int32)numArray.Length; i = checked(i + 1))
				{
					Byte num = numArray[i];
					stringBuilder.Append(num.ToString("X2"));
				}
				lower = stringBuilder.ToString().ToLower();
			}
			finally
			{
				if (mD5 != null)
				{
					mD5.Dispose();
				}
			}
			return lower;
		}

		public static String GetMethodName(Object sender)
		{
			String str;
			try
			{
				if (Operators.CompareString(Versioned.TypeName(RuntimeHelpers.GetObjectValue(sender)), "RuntimeMethodInfo", false) != 0)
				{
					str = (Operators.CompareString(Versioned.TypeName(RuntimeHelpers.GetObjectValue(sender)), "String", false) != 0 ? "" : Conversions.ToString(sender));
				}
				else
				{
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "ReflectedType", new Object[0], null, null, null), null, "Name", new Object[0], null, null, null), "."), NewLateBinding.LateGet(sender, null, "name", new Object[0], null, null, null)));
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static Int32 GetNetworkTime(ref DateTime networkDateTime)
		{
			Int32 integer;
			try
			{
				Byte[] numArray = new Byte[48];
				numArray[0] = 27;
				IPAddress[] addressList = Dns.GetHostEntry("pool.ntp.org").get_AddressList();
				IPEndPoint pEndPoint = new IPEndPoint(addressList[0], 123);
				Socket socket = new Socket(2, 2, 17);
				try
				{
					socket.set_ReceiveTimeout(3000);
					socket.Connect(pEndPoint);
					socket.Send(numArray);
					socket.Receive(numArray);
					socket.Close();
				}
				finally
				{
					if (socket != null)
					{
						socket.Dispose();
					}
				}
				UInt64 num = (UInt64)BitConverter.ToUInt32(numArray, 40);
				UInt64 num1 = (UInt64)BitConverter.ToUInt32(numArray, 44);
				num = (UInt64)Module1.SwapEndianness(num);
				num1 = (UInt64)Module1.SwapEndianness(num1);
				Decimal num2 = Decimal.Add(Decimal.Multiply(new Decimal(num), new Decimal((Int64)1000)), Decimal.Divide(Decimal.Multiply(new Decimal(num1), new Decimal((Int64)1000)), new Decimal(0, 1, 0, false, 0)));
				DateTime dateTime = new DateTime(1900, 1, 1);
				networkDateTime = dateTime.AddMilliseconds((Double)Convert.ToInt64(num2));
				integer = Conversions.ToInteger(Interaction.IIf(networkDateTime.get_Year() < 2018, 1, 0));
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.get_Message(), new Object[0]);
				integer = -1;
				ProjectData.ClearProjectError();
			}
			return integer;
		}

		public static String GetOperatingSystem()
		{
			String oSFullName;
			try
			{
				oSFullName = MyProject.Computer.get_Info().get_OSFullName();
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					oSFullName = Environment.get_OSVersion().ToString();
					ProjectData.ClearProjectError();
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					oSFullName = exception.get_Message();
					ProjectData.ClearProjectError();
				}
			}
			return oSFullName;
		}

		public static Int32 GetParentProcessId(this System.Diagnostics.Process process)
		{
			Int32 rawValue;
			try
			{
				rawValue = checked((Int32)(new PerformanceCounter("Process", "Creating Process ID", process.get_ProcessName())).get_RawValue());
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				rawValue = -1;
				ProjectData.ClearProjectError();
			}
			return rawValue;
		}

		public static String GetQueryString(this Uri uri, String name)
		{
			String str;
			try
			{
				if ((object)uri == (object)null)
				{
					str = "";
				}
				else
				{
					Int32 num = uri.ToString().IndexOf(name);
					if (num < 0)
					{
						str = "";
					}
					else
					{
						Int32 length = uri.ToString().IndexOf("&", num);
						if (length == -1)
						{
							length = uri.ToString().get_Length();
						}
						str = uri.ToString().Substring(checked(checked(num + name.get_Length()) + 1), checked(checked(checked(length - num) - name.get_Length()) - 1)).Trim();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static String GetString(this Byte[] value)
		{
			Char[] chrArray = null;
			Buffer.BlockCopy(value, 0, chrArray, 0, (Int32)value.Length);
			return new String(chrArray);
		}

		public static Dictionary<String, String> GetUrlParameters(this String url)
		{
			String str = (new Uri(url)).get_Query().TrimStart(new Char[] { '?' });
			String[] strArray = str.Split(new Char[] { '&' });
			Dictionary<String, String> dictionary = new Dictionary<String, String>();
			String[] strArray1 = strArray;
			for (Int32 i = 0; i < (Int32)strArray1.Length; i = checked(i + 1))
			{
				String str1 = strArray1[i];
				String[] strArray2 = str1.Split(new Char[] { '=' });
				if ((Int32)strArray2.Length == 2)
				{
					dictionary.set_Item(strArray2[0], strArray2[1]);
				}
			}
			return dictionary;
		}

		public static String GetWindowsReleaseId()
		{
			String str = Conversions.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ReleaseId", ""));
			return str;
		}

		public static Boolean Has(this String value, String item)
		{
			Boolean flag;
			flag = (value.ToLower().IndexOf(item.ToLower()) != -1 ? true : false);
			return flag;
		}

		public static Boolean HasAll(this String value, String[] items)
		{
			Boolean flag;
			String[] strArray = items;
			Int32 num = 0;
			while (true)
			{
				if (num < (Int32)strArray.Length)
				{
					String str = strArray[num];
					if (value.ToLower().IndexOf(str.ToLower()) != -1)
					{
						num = checked(num + 1);
					}
					else
					{
						flag = false;
						break;
					}
				}
				else
				{
					flag = true;
					break;
				}
			}
			return flag;
		}

		public static Boolean HasAny(this String value, String[] items)
		{
			Boolean flag;
			String[] strArray = items;
			Int32 num = 0;
			while (true)
			{
				if (num < (Int32)strArray.Length)
				{
					String str = strArray[num];
					if (value.ToLower().IndexOf(str.ToLower()) < 0)
					{
						num = checked(num + 1);
					}
					else
					{
						flag = true;
						break;
					}
				}
				else
				{
					flag = false;
					break;
				}
			}
			return flag;
		}

		public static Boolean HasOnly(this String value, String item)
		{
			Boolean flag;
			flag = (Operators.CompareString(value.ToLower(), item.ToLower(), false) != 0 ? false : true);
			return flag;
		}

		[DllImport("wininet.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		public static extern Boolean InternetCheckConnection(String lpszUrl, Int32 dwFlags, Int32 dwReserved);

		[DllImport("wininet.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		public static extern Boolean InternetGetConnectedState(ref Int32 lpdwFlags, Int32 dwReserved);

		public static Boolean IsFolderHidden(String folderPath)
		{
			Boolean attributes;
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
				attributes = (directoryInfo.get_Attributes() & 2) == 2;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Debug.Print(exception.ToString());
				attributes = false;
				ProjectData.ClearProjectError();
			}
			return attributes;
		}

		public static Boolean IsInternetConnected()
		{
			Boolean flag;
			try
			{
				Ping ping = new Ping();
				String[] strArray = new String[] { "www.google.com", "8.8.8.8", "8.8.4.4" };
				Int32 num = 0;
				while (num < (Int32)strArray.Length)
				{
					if (ping.Send(strArray[num]).get_Status() != 0)
					{
						num = checked(num + 1);
					}
					else
					{
						flag = true;
						return flag;
					}
				}
				flag = false;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public static Boolean IsInternetConnected(ref Module1.NetConnectType type)
		{
			Boolean flag;
			try
			{
				Int32 num = 0;
				Boolean flag1 = Module1.InternetGetConnectedState(ref num, 0);
				if (!flag1)
				{
					type = Module1.NetConnectType.INTERNET_CONNECTION_OFFLINE;
				}
				else if ((num & 2) > 0 | (num & 1) > 0 | (num & 4) > 0)
				{
					type = Module1.NetConnectType.INTERNET_CONNECTION_ONLINE;
					if ((num & 16) > 0)
					{
					}
				}
				else if ((num & 32) > 0)
				{
					type = Module1.NetConnectType.INTERNET_CONNECTION_OFFLINE;
				}
				else if ((num & 64) > 0)
				{
					type = Module1.NetConnectType.INTERNET_CONNECTION_CONFIGURED;
				}
				else if ((num & 16) <= 0)
				{
					type = Module1.NetConnectType.INTERNET_CONNECTION_OFFLINE;
				}
				else
				{
					type = Module1.NetConnectType.INTERNET_RAS_INSTALLED;
				}
				flag = flag1;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		public static Boolean IsNull(this DateTime value)
		{
			return DateTime.Compare(value, DateTime.MinValue) == 0;
		}

		public static Double LabTime(this DateTime value)
		{
			return DateAndTime.get_Now().Subtract(value).get_TotalMilliseconds();
		}

		public static Void Log(Object source, String message, params Object[] args)
		{
			Module1.Log(Module1.LogType.DEBUG, RuntimeHelpers.GetObjectValue(source), message, args);
		}

		public static Void Log(Module1.LogType type, Object source, String message, params Object[] args)
		{
			try
			{
				String str = message;
				if ((Int32)args.Length > 0)
				{
					str = String.Format(message, args);
				}
				String str1 = String.Concat(new String[] { DateAndTime.get_TimeString(), ";", type.ToString().ToUpper(), ";", Module1.GetMethodName(RuntimeHelpers.GetObjectValue(source)), ";", str, "\u0003" });
				Debug.Print(str1);
				if (type == Module1.LogType.ERROR)
				{
					Module1.LastError = message;
					Module1.LogToClientReport(message);
				}
				if (Module1.LOG_SESSION)
				{
					Module1.LogToBuffer(str1);
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Module1.LogToClientReport(exception.ToString());
				ProjectData.ClearProjectError();
			}
		}

		private static Void LogToBuffer(String message)
		{
			if (message != null)
			{
				if (Operators.CompareString(message, "", false) != 0)
				{
					Module1.SessionLog.Add(message);
				}
			}
		}

		public static Void LogToClientReport(String message)
		{
			Module1._Closureu0024__39u002d0 variable = null;
			try
			{
				ExamCookie.WinClient.ClientError clientError = Module1.ClientReport.Find(new Predicate<ExamCookie.WinClient.ClientError>(variable, (ExamCookie.WinClient.ClientError x) => Operators.CompareString(x.Message, this.u0024VBu0024Local_message, false) == 0));
				if (clientError != null)
				{
					ref Int32 count = ref clientError.Count;
					count = checked(count + 1);
				}
				else
				{
					Module1.ClientReport.Add(new ExamCookie.WinClient.ClientError(message));
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		public static Void LogToFile(String path, String text)
		{
			StreamWriter streamWriter = null;
			try
			{
				try
				{
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					streamWriter = new StreamWriter(String.Format("{0}\\{1}_{2}.log", path, executingAssembly.GetName().get_Name(), DateAndTime.get_DateString()), true);
					streamWriter.WriteLine(text);
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				if ((object)streamWriter != (object)null)
				{
					streamWriter.Close();
				}
			}
		}

		public static Int32 Neg(this Int32 value)
		{
			return checked(0 - Math.Abs(value));
		}

		public static Void OptimizeMemoryConsumption()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			Module1.SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().get_Handle(), -1, -1);
		}

		public static Int32 PeekDeserializedEncryptedFile(String filename, ref Byte[] data, Int32 offset, Int32 count)
		{
			Int32 num;
			try
			{
				if (!File.Exists(filename))
				{
					num = 1;
				}
				else
				{
					Rijndael rijndael = Rijndael.Create();
					try
					{
						FileStream fileStream = new FileStream(filename, 3);
						try
						{
							if (fileStream.get_Length() != (Int64)0)
							{
								Byte[] numArray = null;
								Byte[] numArray1 = null;
								Module1.GetCryptoKeyPair(ref numArray, ref numArray1);
								ICryptoTransform cryptoTransform = rijndael.CreateDecryptor(numArray, numArray1);
								CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoTransform, 0);
								try
								{
									MemoryStream memoryStream = new MemoryStream();
									try
									{
										cryptoStream.CopyTo(memoryStream);
										memoryStream.Seek((Int64)0, 0);
										data = new Byte[checked(checked(count - 1) + 1)];
										memoryStream.Read(data, offset, count);
										num = 0;
									}
									finally
									{
										if (memoryStream != null)
										{
											memoryStream.Dispose();
										}
									}
								}
								finally
								{
									if (cryptoStream != null)
									{
										cryptoStream.Dispose();
									}
								}
							}
							else
							{
								num = 2;
							}
						}
						finally
						{
							if (fileStream != null)
							{
								fileStream.Dispose();
							}
						}
					}
					finally
					{
						if (rijndael != null)
						{
							rijndael.Dispose();
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Object Pop(this List<Object> buffer, Int32 index = 0)
		{
			Object obj;
			try
			{
				if (buffer == null)
				{
					obj = null;
				}
				else if (buffer.get_Count() <= index)
				{
					obj = null;
				}
				else
				{
					Object objectValue = RuntimeHelpers.GetObjectValue(Enumerable.ToList<Object>(buffer).get_Item(index));
					buffer.RemoveAt(index);
					obj = objectValue;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				obj = null;
				ProjectData.ClearProjectError();
			}
			return obj;
		}

		public static Image Resize(this Image originalImage, Int32 newWidth, Int32 newHeight)
		{
			Image image;
			Image bitmap = new Bitmap(newWidth, newHeight);
			try
			{
				Graphics graphic = Graphics.FromImage(bitmap);
				try
				{
					graphic.set_SmoothingMode(2);
					graphic.set_InterpolationMode(7);
					graphic.set_PixelOffsetMode(2);
					graphic.DrawImage(originalImage, 0, 0, newWidth, newHeight);
				}
				finally
				{
					if (graphic != null)
					{
						graphic.Dispose();
					}
				}
				image = (Image)bitmap.Clone();
			}
			finally
			{
				if (bitmap != null)
				{
					bitmap.Dispose();
				}
			}
			return image;
		}

		public static Void RunAsCommand(String command, String arguments = "")
		{
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.set_Arguments(String.Format(" /C {0} {1}", command, arguments));
				processStartInfo.set_Verb("runas");
				processStartInfo.set_CreateNoWindow(true);
				processStartInfo.set_UseShellExecute(true);
				processStartInfo.set_RedirectStandardOutput(false);
				processStartInfo.set_FileName("cmd.exe");
				System.Diagnostics.Process.Start(processStartInfo);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		public static Void RunCommand(String command, String arguments, Boolean permanent)
		{
			try
			{
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				ProcessStartInfo processStartInfo1 = processStartInfo;
				String[] strArray = new String[] { " ", default(String), default(String), default(String), default(String), default(String) };
				strArray[1] = (permanent ? "/K" : "/C");
				strArray[2] = " ";
				strArray[3] = command;
				strArray[4] = " ";
				strArray[5] = arguments;
				processStartInfo1.set_Arguments(String.Concat(strArray));
				processStartInfo.set_FileName("cmd.exe");
				process.set_StartInfo(processStartInfo);
				process.Start();
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		public static String RunCommand(String command, String arguments = "")
		{
			String end;
			try
			{
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.set_Arguments(String.Format(" /C {0} {1}", command, arguments));
				processStartInfo.set_Verb("runas");
				processStartInfo.set_CreateNoWindow(true);
				processStartInfo.set_UseShellExecute(false);
				processStartInfo.set_RedirectStandardOutput(true);
				processStartInfo.set_FileName("cmd.exe");
				process.set_StartInfo(processStartInfo);
				process.Start();
				try
				{
					StreamReader standardOutput = process.get_StandardOutput();
					try
					{
						end = standardOutput.ReadToEnd();
					}
					finally
					{
						if (standardOutput != null)
						{
							standardOutput.Dispose();
						}
					}
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
					end = null;
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				Exception exception2 = exception3;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception2.ToString(), new Object[0]);
				end = null;
				ProjectData.ClearProjectError();
			}
			return end;
		}

		public static Void SaveLogBuffer()
		{
			try
			{
				if (Module1.SessionLog.get_Count() > 0)
				{
					String str = String.Format("{0}\\{1}", Module1.APP_DATA_PATH, "Log");
					if (!Directory.Exists(str))
					{
						try
						{
							Directory.CreateDirectory(str);
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							Module1.SessionLog.Clear();
							ProjectData.ClearProjectError();
						}
					}
					try
					{
						StreamWriter streamWriter = new StreamWriter(String.Format("{0}\\session-{1}.log", str, Module1.USER_SIGN_IN_TOKEN), true);
						try
						{
							while (Module1.SessionLog.get_Count() > 0)
							{
								try
								{
									streamWriter.WriteLine(Module1.SessionLog.get_Item(0));
								}
								catch (Exception exception1)
								{
									ProjectData.SetProjectError(exception1);
									ProjectData.ClearProjectError();
								}
								Module1.SessionLog.RemoveAt(0);
							}
						}
						finally
						{
							if (streamWriter != null)
							{
								streamWriter.Dispose();
							}
						}
					}
					catch (Exception exception2)
					{
						ProjectData.SetProjectError(exception2);
						Module1.SessionLog.Clear();
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				ProjectData.ClearProjectError();
			}
		}

		public static Int32 SerializeToFile(String filename, Object obj)
		{
			Int32 num;
			try
			{
				if ((object)obj != (object)null)
				{
					FileStream fileStream = new FileStream(filename, 2);
					try
					{
						(new BinaryFormatter()).Serialize(fileStream, RuntimeHelpers.GetObjectValue(obj));
					}
					finally
					{
						if (fileStream != null)
						{
							fileStream.Dispose();
						}
					}
					num = 0;
				}
				else
				{
					num = 1;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Int32 SerializeToFileEncrypted(String filename, Object obj)
		{
			Int32 num;
			try
			{
				if ((object)obj != (object)null)
				{
					Rijndael rijndael = Rijndael.Create();
					try
					{
						Byte[] numArray = null;
						Byte[] numArray1 = null;
						Module1.GetCryptoKeyPair(ref numArray, ref numArray1);
						ICryptoTransform cryptoTransform = rijndael.CreateEncryptor(numArray, numArray1);
						FileStream fileStream = new FileStream(filename, 2);
						try
						{
							BinaryFormatter binaryFormatter = new BinaryFormatter();
							CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoTransform, 1);
							try
							{
								binaryFormatter.Serialize(cryptoStream, RuntimeHelpers.GetObjectValue(obj));
							}
							finally
							{
								if (cryptoStream != null)
								{
									cryptoStream.Dispose();
								}
							}
						}
						finally
						{
							if (fileStream != null)
							{
								fileStream.Dispose();
							}
						}
					}
					finally
					{
						if (rijndael != null)
						{
							rijndael.Dispose();
						}
					}
					num = 0;
				}
				else
				{
					num = 1;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Int32 SerializeToXmlFile(String filename, Object obj, Boolean utf8encoding)
		{
			Int32 num;
			try
			{
				String xmlString = Module1.SerializeToXmlString(RuntimeHelpers.GetObjectValue(obj), utf8encoding);
				if ((object)xmlString == (object)null)
				{
					num = 1;
				}
				else
				{
					StreamWriter streamWriter = new StreamWriter(filename);
					try
					{
						streamWriter.Write(xmlString);
						num = 0;
					}
					finally
					{
						if (streamWriter != null)
						{
							streamWriter.Dispose();
						}
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static String SerializeToXmlString(Object obj, Boolean utf8encoding)
		{
			String str;
			try
			{
				if ((object)obj == (object)null)
				{
					str = null;
				}
				else if (!utf8encoding)
				{
					StringWriter stringWriter = new StringWriter();
					XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
					xmlSerializer.Serialize(stringWriter, RuntimeHelpers.GetObjectValue(obj));
					str = stringWriter.ToString();
				}
				else
				{
					XmlSerializerNamespaces xmlSerializerNamespace = new XmlSerializerNamespaces();
					xmlSerializerNamespace.Add("", "");
					Module1.Utf8StringWriter utf8StringWriter = new Module1.Utf8StringWriter();
					XmlSerializer xmlSerializer1 = new XmlSerializer(obj.GetType(), "");
					xmlSerializer1.Serialize(utf8StringWriter, RuntimeHelpers.GetObjectValue(obj), xmlSerializerNamespace);
					str = utf8StringWriter.ToString();
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				str = null;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static Void SessionLogToFile(String path)
		{
			if (Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag = false;
			try
			{
				Monitor.Enter(Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init, ref flag);
				if (Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init.State == 0)
				{
					Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init.State = 2;
					Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024last = DateAndTime.get_Now();
				}
				else if (Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024lastu0024Init);
				}
			}
			if (Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init, new StaticLocalInitFlag(), null);
			}
			Boolean flag1 = false;
			try
			{
				Monitor.Enter(Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init, ref flag1);
				if (Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init.State == 0)
				{
					Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init.State = 2;
					Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024index = 0;
				}
				else if (Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init.State = 1;
				if (flag1)
				{
					Monitor.Exit(Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024indexu0024Init);
				}
			}
			try
			{
				if (DateTime.Compare(DateAndTime.get_Now(), Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024last.AddSeconds(10)) > 0)
				{
					Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024last = DateAndTime.get_Now();
					if (Module1.SessionLog.get_Count() > Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024index)
					{
						Assembly executingAssembly = Assembly.GetExecutingAssembly();
						StreamWriter streamWriter = new StreamWriter(String.Format("{0}\\{1}_{2}.log", path, executingAssembly.GetName().get_Name(), DateAndTime.get_DateString()), true);
						try
						{
							Int32 num = Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024index;
							Int32 count = checked(Module1.SessionLog.get_Count() - 1);
							for (Int32 i = num; i <= count; i = checked(i + 1))
							{
								streamWriter.WriteLine(Module1.SessionLog.get_Item(i));
							}
						}
						finally
						{
							if (streamWriter != null)
							{
								streamWriter.Dispose();
							}
						}
						Module1.u0024STATICu0024SessionLogToFileu0024011Eu0024index = Module1.SessionLog.get_Count();
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		public static Void SetComputerClock()
		{
			Module1.SYSTEMTIME year = new Module1.SYSTEMTIME();
			try
			{
				DateTime minValue = DateTime.MinValue;
				if (Module1.GetNetworkTime(ref minValue) != 0)
				{
					Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), "Kan ikke hente internet server tid", new Object[0]);
				}
				else
				{
					minValue = minValue.ToLocalTime();
					year.year = checked((Int16)minValue.get_Year());
					year.month = checked((Int16)minValue.get_Month());
					year.dayOfWeek = checked((Int16)minValue.get_DayOfWeek());
					year.day = checked((Int16)minValue.get_Day());
					year.hour = checked((Int16)minValue.get_Hour());
					year.minute = checked((Int16)minValue.get_Minute());
					year.second = checked((Int16)minValue.get_Second());
					year.milliseconds = checked((Int16)minValue.get_Millisecond());
					if (!Module1.SetLocalTime(ref year))
					{
						Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), "Sæt computer ur fejlet", new Object[0]);
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				Module1.Log(Module1.LogType.ERROR, MethodBase.GetCurrentMethod(), exception.ToString(), new Object[0]);
				ProjectData.ClearProjectError();
			}
		}

		public static Void SetCredentials(ref ExamApiV3Client client)
		{
			client.get_ClientCredentials().get_UserName().set_UserName(Resources.WCF_USERNAME);
			client.get_ClientCredentials().get_UserName().set_Password(Resources.WCF_PASSWORD);
		}

		public static Void SetFolderHidden(String path, Boolean hide)
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				FileAttributes attributes = directoryInfo.get_Attributes();
				if (!hide)
				{
					attributes &= -3;
				}
				else
				{
					attributes |= 2;
				}
				directoryInfo.set_Attributes(attributes);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Debug.Print(exception.ToString());
				ProjectData.ClearProjectError();
			}
		}

		[DllImport("kernel32.dll", CharSet=1, ExactSpelling=false, SetLastError=true)]
		public static extern Boolean SetLocalTime(ref Module1.SYSTEMTIME time);

		[DllImport("kernel32.dll", CharSet=2, ExactSpelling=true, SetLastError=true)]
		public static extern Int32 SetProcessWorkingSetSize(IntPtr process, Int32 minimumWorkingSetSize, Int32 maximumWorkingSetSize);

		private static UInt32 SwapEndianness(UInt64 x)
		{
			UInt32 num = checked((UInt32)(checked(checked(checked((((Void*)(checked((Int64)x)) & (Int64)255) << 24) + (((Void*)(checked((Int64)x)) & (Int64)65280) << 8)) + (((Void*)(checked((Int64)x)) & (Int64)16711680) >> 8)) + (((Void*)(checked((Int64)x)) & (Int64)-16777216) >> 24))));
			return num;
		}

		public static String ToAsciiCtrl(String value)
		{
			String[] strArray = new String[] { "NUL", "SOH", "STX", "ETX", "EOT", "ENQ", "ACK", "BEL", "BS", "TAB", "LF", "VT", "FF", "CR", "SO", "SI", "DLE", "DC1", "DC2", "DC3", "DC4", "NAK", "SYN", "ETB", "CAN", "EM", "SUB", "ESC", "FS", "GS", "RS", "US" };
			Int32 length = checked((Int32)strArray.Length - 1);
			for (Int32 i = 0; i <= length; i = checked(i + 1))
			{
				value = Strings.Replace(value, Conversions.ToString(Strings.Chr(i)), String.Concat("<", strArray[i], ">"), 1, -1, 0);
			}
			return value;
		}

		public static String ToBase64(String value)
		{
			Byte[] bytes = Encoding.get_UTF8().GetBytes(value);
			return Convert.ToBase64String(bytes);
		}

		public static String ToDK(this DateTime datetime)
		{
			return Strings.Format(datetime, "dd-MM-yyyy HH:mm:ss");
		}

		public static String ToEN(this DateTime datetime)
		{
			return Strings.Format(datetime, "MM-dd-yyyy HH:mm:ss");
		}

		public static String ToMACAddress(Byte[] buffer)
		{
			String str;
			try
			{
				List<String> list = new List<String>();
				Byte[] numArray = buffer;
				for (Int32 i = 0; i < (Int32)numArray.Length; i = checked(i + 1))
				{
					list.Add(numArray[i].ToString("X2"));
				}
				str = Strings.Join(list.ToArray(), "-");
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = "";
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static String ToUri(this String value)
		{
			String str;
			if (value == null)
			{
				str = "";
			}
			else if (Operators.CompareString(value, "", false) != 0)
			{
				str = (value.ToLower().IndexOf("http") < 0 ? String.Concat("http://", value) : value);
			}
			else
			{
				str = "";
			}
			return str;
		}

		public static String UriEncode(String value)
		{
			return HttpUtility.UrlEncode(value);
		}

		public struct DEVMODE
		{
			private const Int32 CCHDEVICENAME = 32;

			private const Int32 CCHFORMNAME = 32;

			public String dmDeviceName;

			public Int16 dmSpecVersion;

			public Int16 dmDriverVersion;

			public Int16 dmSize;

			public Int16 dmDriverExtra;

			public Int32 dmFields;

			public Int32 dmPositionX;

			public Int32 dmPositionY;

			public ScreenOrientation dmDisplayOrientation;

			public Int32 dmDisplayFixedOutput;

			public Int16 dmColor;

			public Int16 dmDuplex;

			public Int16 dmYResolution;

			public Int16 dmTTOption;

			public Int16 dmCollate;

			public String dmFormName;

			public Int16 dmLogPixels;

			public Int32 dmBitsPerPel;

			public Int32 dmPelsWidth;

			public Int32 dmPelsHeight;

			public Int32 dmDisplayFlags;

			public Int32 dmDisplayFrequency;

			public Int32 dmICMMethod;

			public Int32 dmICMIntent;

			public Int32 dmMediaType;

			public Int32 dmDitherType;

			public Int32 dmReserved1;

			public Int32 dmReserved2;

			public Int32 dmPanningWidth;

			public Int32 dmPanningHeight;
		}

		public enum LogType
		{
			DEBUG = 1,
			INFO = 2,
			WARNING = 3,
			ERROR = 4
		}

		public enum NetConnectType
		{
			INTERNET_CONNECTION_ONLINE = 0,
			INTERNET_CONNECTION_MODEM = 1,
			INTERNET_CONNECTION_LAN = 2,
			INTERNET_CONNECTION_PROXY = 4,
			INTERNET_CONNECTION_MODEM_BUSY = 8,
			INTERNET_RAS_INSTALLED = 16,
			INTERNET_CONNECTION_OFFLINE = 32,
			INTERNET_CONNECTION_CONFIGURED = 64
		}

		public struct SYSTEMTIME
		{
			public Int16 year;

			public Int16 month;

			public Int16 dayOfWeek;

			public Int16 day;

			public Int16 hour;

			public Int16 minute;

			public Int16 second;

			public Int16 milliseconds;
		}

		public class Utf8StringWriter : StringWriter
		{
			public override Encoding Encoding
			{
				get
				{
					return Encoding.get_UTF8();
				}
			}

			public Utf8StringWriter()
			{
			}
		}
	}
}