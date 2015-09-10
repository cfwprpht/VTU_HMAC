using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTU_HMAC
{
    public partial class VTU_HMAC : Form
    {
        #region vars
        private string unique;
        private string version = "-ver.xml";
        private string skpath = @"C:\vitakeys\title-hmac-100";
        private bool keychecked = false;
        private byte[] key = new byte[0];
        private byte[] sha1 = { 0x1D, 0x87, 0x0B, 0x6A, 0xD1, 0x9B, 0x1C, 0xC1, 0x9E, 0xDF, 0x5F, 0xC4, 0xDA, 0xB3, 0x79, 0x24, 0xE1, 0x15, 0xC3, 0xE0 };
        #endregion vars

        // Main entry point for the Form
        public VTU_HMAC()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(VTU_HMAC_DragEnter);
            this.DragDrop += new DragEventHandler(VTU_HMAC_DragDrop);
        }

        // On Load of Form do...
        private void VTU_HMAC_Load(object sender, EventArgs e)
        {
            buttonConfig.Enabled = false;
            string str = Directory.GetCurrentDirectory() + @"\config.txt";
            if (File.Exists(str))
            {
                checkConfig.Checked = true;
                string[] stra = File.ReadAllLines(str);
                if (stra.Length > 1)
                    MessageBox.Show("To many Lines in the config file\nPlease Check and remove unwanted Lines.");
                else
                    CheckForKey(stra[0]);
            }
            else
                CheckForKey(skpath);
        }

        // Check if Drop is valid
        private void VTU_HMAC_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // On valid Drop input...
        private void VTU_HMAC_DragDrop(object sender, DragEventArgs e)
        {
            string[] input = ((string[])e.Data.GetData(DataFormats.FileDrop));
            string message = "Key Loaded!\nShall i check the Key for you?";
            string caption = "An Error occurred";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (input.Length > 1)
                MessageBox.Show("Please Drop only one Key file into the GUI");
            else
            {
                FileInfo finfo = new FileInfo(input[0]);
                if (finfo.Length != 32)
                    MessageBox.Show("The Length of the Key file do not match!");
                else
                    using (BinaryReader br = new BinaryReader(File.Open(input[0], FileMode.Open)))
                        br.Read(key = new byte[32], 0, 32);
            }

            // Do we have a valid key input?
            if (key.Length == 32)
                if (result == DialogResult.Yes)  // Shall i Check the Key for you?
                    CheckKey();
        }

        /// <summary>
        /// Compare Byte by Byte or Array by Array
        /// </summary>
        /// <param name="bA1">Byte Array 1</param>
        /// <param name="bA2">Byte Array 2</param>
        /// <returns>True if both Byte Array's do match</returns>
        public static bool CompareBytes(byte[] bA1, byte[] bA2)
        {
            int s = 0;
            for (int z = 0; z < bA1.Length; z++)
            {
                if (bA1[z] != bA2[z])
                    s++;
            }

            if (s == 0)
                return true;
            return false;
        }

        // Convert Bytes to a Hex String
        public static string ByteToString(byte[] buffer)
        {
            string hexString = "";
            for (int i = 0; i < buffer.Length; i++)
            {
                hexString += buffer[i].ToString("x2");
            }
            return hexString;
        }

        // On CheckConfig Change
        private void checkConfig_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConfig.Checked)
                buttonConfig.Enabled = true;
            else
            {
                buttonConfig.Enabled = false;
                CheckForKey(skpath);
            }
        }

        // Check the Path for the Key
        private void CheckForKey(string str)
        {
            FileInfo finfo = new FileInfo(str);
            if (File.Exists(str))
                if (finfo.Length == 32)
                    using (BinaryReader br = new BinaryReader(File.Open(str, FileMode.Open)))
                        br.Read(key = new byte[32], 0, 32);
                else
                    MessageBox.Show("The Length of the Key file do not match!");
            else
                MessageBox.Show("Could not find the vita title-hmac-100 key!\nPlease check your path!");
            if (key.Length != 0)
                CheckKey();
        }

        // Check the Key if it is valid
        private void CheckKey()
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] compare = sha.ComputeHash(key);
            keychecked = false;
            if (!CompareBytes(compare, sha1))
            {
                labelKey.Text = "Key: Not Valid";
                labelKey.ForeColor = Color.Black;
            }
            else
            {
                keychecked = true;
                labelKey.Text = "Key: Valid";
                labelKey.ForeColor = Color.Blue;
            }
        }

        // Check if input is a Link
        private static bool IsStringLink(string str)
        {
            if (str.Contains("http://") | str.Contains("https://"))
                return true;
            return false;
        }

        // Check if string is Upper Case
        private static bool IsStringUpper(string str)
        {
            for (int i = 0; i < 3; i++)
            {
                if (char.IsLower(str[i]))
                    return false;
            }
            return true;
        }

        // Hashing a value using HMAC-256
        private void HMACHash()
        {
            ASCIIEncoding encode = new ASCIIEncoding();
            HMACSHA256 hmac256 = new HMACSHA256(key);
            byte[] uniqueAsByte = encode.GetBytes(unique);
            byte[] hashedUnique = hmac256.ComputeHash(uniqueAsByte);
            unique = null;
            unique = ByteToString(hashedUnique);
            hmac256.Clear();
        }

        // Configure Key Path
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            string str;
            string conf = Directory.GetCurrentDirectory() + @"\config.txt";
            FolderBrowserDialog selectPath = new FolderBrowserDialog();
            if (!File.Exists(conf))
                File.Create(conf).Close();

            if (selectPath.ShowDialog() == DialogResult.OK)
            {
                str = selectPath.SelectedPath;
                File.WriteAllText(conf, str);
            }

            CheckForKey(conf);
        }

        // Clear Text
        private void buttonClearText_Click(object sender, EventArgs e)
        {
            textLink.Text = "";
        }

        // Clear Hash
        private void buttonClearHash_Click(object sender, EventArgs e)
        {
            textHash.Text = "";
        }

        // Generate Text
        private void buttonHash_Click(object sender, EventArgs e)
        {
            if (!keychecked)
                CheckForKey(skpath);

            if (keychecked)
            {
                if (textLink.Text != "")
                    if (textTitleID.Text != "")
                        if (Regex.IsMatch(textTitleID.Text, @"\w{4}" + @"\d{5}", RegexOptions.None))
                        {
                            unique = null;
                            string title = textTitleID.Text;
                            if (!IsStringUpper(title))
                                title = title.ToUpper();

                            if (textHash.Text != "")
                                textHash.Text = "";

                            unique = "np_" + title;
                            HMACHash();
                            textHash.Text = textLink.Text + title + "/" + unique + "/" + title + version;
                        }
                        else
                            MessageBox.Show("Please Enter a valid TitleID!\nExample: PCSA00000");
                    else
                        MessageBox.Show("Please Enter a TitleID!");
                else
                    MessageBox.Show("Please Enter a Link!");
            }
            else
                MessageBox.Show("The Hash of your Key do not Match the knowen SHA1.\nPlease use the Vita title-hmac-100 key!");
        }
    }
}
