using MetroFramework.Forms;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using aLib.Microsoft;
using MetroFramework;

namespace WindowsFormsApp2
{
    public partial class License : MetroForm
    {

        public License()
        {
            InitializeComponent();
            tBox_Id.Text = mm_Encryptions.License.GetUHId();
        }


        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string key = metroTextBoxKey.Text;

            if (CheckKey(key))
            {
                Microsoft.Win32.RegistryKey RegKey = Microsoft.Win32.Registry.CurrentUser;
                RegKey.CreateSubKey("Software\\notGram\\License");

                Microsoft.Win32.RegistryKey Key =
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\notGram\\License", true);
                Key.SetValue("key", key);
                Application.Restart();
            }
            else
            {
                metroTextBoxKey.Clear();
                metroTextBoxKey.WaterMark = "Неверный код активации";
            }
        }


        private bool CheckKey(string key)
        {
            try
            {
                string id = DeShifrovka(key, "notGramOxybes");
                if (id.Equals(mm_Encryptions.License.GetUHId()))
                    return true;
            }
            catch { }
            return false;
        }

        public  static bool CheckLicense()
        {
            Microsoft.Win32.RegistryKey RegKey =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey
                    ("Software\\notGram\\License", true);
            try
            {
                string keyRegedit = RegKey.GetValue("key").ToString();
                keyRegedit = DeShifrovka(keyRegedit, "notGramOxybes");
                if (keyRegedit.Equals(mm_Encryptions.License.GetUHId()))
                    return true;
            }
            catch { }
            return false;
        }

        public static string DeShifrovka(string ciphText, string pass,
            string sol = "tiPidor", string cryptographicAlgorithm = "SHA1",
            int passIter = 2, string initVec = "b7upQyNlALx5nJl#",
            int keySize = 256)
        {
            if (string.IsNullOrEmpty(ciphText))
                return "";

            byte[] initVecB = Encoding.ASCII.GetBytes(initVec);
            byte[] solB = Encoding.ASCII.GetBytes(sol);
            byte[] cipherTextBytes = Convert.FromBase64String(ciphText);

            PasswordDeriveBytes derivPass = new PasswordDeriveBytes(pass, solB, cryptographicAlgorithm, passIter);
            byte[] keyBytes = derivPass.GetBytes(keySize / 8);

            RijndaelManaged symmK = new RijndaelManaged();
            symmK.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmK.CreateDecryptor(keyBytes, initVecB))
            {
                using (MemoryStream mSt = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(mSt, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        mSt.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmK.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }

    }
}
