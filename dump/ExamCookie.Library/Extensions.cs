using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace ExamCookie.Library
{
	public static class Extensions
	{
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
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						obj = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(fileStream));
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
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = -1;
				ProjectData.ClearProjectError();
			}
			return num;
		}

		public static Int32 DeserializeFromXmlFile(String filename, ref Object obj)
		{
			Int32 num;
			num = ((object)obj != (object)null ? Extensions.DeserializeFromXmlFile(filename, obj.GetType(), ref obj) : 1);
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
							obj = RuntimeHelpers.GetObjectValue(Extensions.DeSerializeFromXmlString(streamReader.ReadToEnd(), type));
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
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
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
				if (Operators.CompareString(obj, "", false) != 0)
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
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				obj1 = null;
				ProjectData.ClearProjectError();
			}
			return obj1;
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

		public static Int32 SerializeToFile(String filename, Object obj)
		{
			Int32 num;
			try
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
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
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
				String xmlString = Extensions.SerializeToXmlString(RuntimeHelpers.GetObjectValue(obj), utf8encoding);
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
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
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
				if (!utf8encoding)
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
					Extensions.Utf8StringWriter utf8StringWriter = new Extensions.Utf8StringWriter();
					XmlSerializer xmlSerializer1 = new XmlSerializer(obj.GetType(), "");
					xmlSerializer1.Serialize(utf8StringWriter, RuntimeHelpers.GetObjectValue(obj), xmlSerializerNamespace);
					str = utf8StringWriter.ToString();
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = null;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static Int32 ToInt(this String value)
		{
			Int32 num;
			try
			{
				if (value == null)
				{
					num = 0;
				}
				else if (value.get_Length() != 0)
				{
					String str = "";
					value = value.Split(new Char[] { ',' })[0];
					Int32 length = checked(value.get_Length() - 1);
					for (Int32 i = 0; i <= length; i = checked(i + 1))
					{
						if (Versioned.IsNumeric(value.Substring(i, 1)))
						{
							str = String.Concat(str, value.Substring(i, 1));
						}
					}
					num = checked((Int32)Math.Round(Conversion.Val(str)));
				}
				else
				{
					num = 0;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num = 0;
				ProjectData.ClearProjectError();
			}
			return num;
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