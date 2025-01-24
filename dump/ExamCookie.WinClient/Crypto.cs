using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ExamCookie.WinClient
{
	public class Crypto
	{
		private static TripleDESCryptoServiceProvider DES;

		private static MD5CryptoServiceProvider MD5;

		static Crypto()
		{
			Crypto.DES = new TripleDESCryptoServiceProvider();
			Crypto.MD5 = new MD5CryptoServiceProvider();
		}

		public Crypto()
		{
		}

		public static String Decrypt(String encryptedString, String key)
		{
			String str;
			try
			{
				Crypto.DES.set_Key(Crypto.MD5Hash(key));
				Crypto.DES.set_Mode(2);
				Byte[] numArray = Convert.FromBase64String(encryptedString);
				str = Encoding.get_ASCII().GetString(Crypto.DES.CreateDecryptor().TransformFinalBlock(numArray, 0, (Int32)numArray.Length));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show("Invalid Key", "Decryption Failed", 0, 48);
				str = null;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		public static String Encrypt(String stringToEncrypt, String key)
		{
			String base64String;
			try
			{
				Crypto.DES.set_Key(Crypto.MD5Hash(key));
				Crypto.DES.set_Mode(2);
				Byte[] bytes = Encoding.get_ASCII().GetBytes(stringToEncrypt);
				base64String = Convert.ToBase64String(Crypto.DES.CreateEncryptor().TransformFinalBlock(bytes, 0, (Int32)bytes.Length));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show("Invalid Key", "Decryption Failed", 0, 48);
				base64String = null;
				ProjectData.ClearProjectError();
			}
			return base64String;
		}

		public static Byte[] MD5Hash(String value)
		{
			Byte[] numArray = Crypto.MD5.ComputeHash(Encoding.get_ASCII().GetBytes(value));
			return numArray;
		}
	}
}