using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Hasher
{
    //TODO formatting of lbl_or when in compare mode
    //TODO be less stupid with hashfiles / Check if file actually contains an actual sum
    public partial class Form1 : Form
    {
        private bool _compare;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open the file dialog and set the value of the textbox to the filepath of the selected file
            var result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_file.Text = fd.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_md5.Select();
        }

        private static Stream GenerateStreamFromString(string s)
        {
            //Write String into a new Stream using a StreamWriter
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /**
        * type = 0 | File
        * type = 1 | String
        */
        private string CalculateHash(string s, int type)
        {
            HashAlgorithm hash;

            //Determine HashAlgorithm by looking at what radio button is selected
            if (rb_md5.Checked) hash = MD5.Create();
            else if (rb_sha256.Checked) hash = SHA256.Create();
            else if (rb_sha512.Checked) hash = SHA512.Create();
            else
            {
                MessageBox.Show(@"Invalid state", @"You have selected an invalid hash algorithm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }

            using (var stream = type == 0 ? File.OpenRead(s) : GenerateStreamFromString(s))
            {
                var calcedhash = hash.ComputeHash(stream);
                return BitConverter.ToString(calcedhash).Replace("-", "").ToLowerInvariant();
            }

        }

        
        private static bool IsHash(string hash)
        {
            const int threshNumStart = '0';
            const int threshNumEnd = '9';
            const int threshCharStart = 'a';
            const int threshCharEnd = 'f';

            //Loop through the String and check every character
            foreach (var c in hash)
            {
                //Check if all characters in the hash are base16
                if (c >= threshNumStart && c <= threshNumEnd || c >= threshCharStart && c <= threshCharEnd)
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static string GetHashType(string hash)
        {
            if (!IsHash(hash)) return "Not a Hash";
            switch (hash.Length)
            {
                case 32:
                    return "MD5";
                case 64:
                    return "SHA-256";
                case 128:
                    return "SHA-512";
            }

            return "Unknown";

        }

        private void btn_hash_Click(object sender, EventArgs e)
        {
            //Check if compare mode is on
            if (!_compare)
            {
                //Check if all needed textboxes are filled / have legal values
                string hash;
                if (tb_file.Text == "")
                {
                    if (tb_string.Text == "")
                    {
                        MessageBox.Show(@"You need to select a file or enter a String", @"Input missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    hash = CalculateHash(tb_string.Text, 1);
                }
                else
                {
                    //Calculate Hash if input file exists
                    if (File.Exists(tb_file.Text))
                    {
                        hash = CalculateHash(tb_file.Text, 0);
                    }
                    else
                    {
                        MessageBox.Show(@"The selected file doesn't exist!", @"File not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                tb_hash.Text = hash;
            }
            else
            {
                //Check if both textboxes are not empty
                if (tb_file.Text == "" || tb_string.Text == "")
                {
                    MessageBox.Show(@"Both Textboxes need to contain a value to compare", @"Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists(tb_file.Text))
                {
                    MessageBox.Show(@"The selected file doesn't exist!", @"File not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Make sure that the value of the second textbox is either a file or a hash (Can be made more precise)
                if ((!File.Exists(tb_string.Text) && (tb_string.Text.Length != 32 && tb_string.Text.Length != 64 && tb_string.Text.Length != 128)) || !IsHash(tb_string.Text) && !File.Exists(tb_string.Text))
                {
                    MessageBox.Show(@"Input is neither a file nor a hash, please check input!", @"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (File.Exists(tb_string.Text))
                {
                    try
                    {
                        //Read sum from file. Most sum files have the layout "hashsum filename"
                        //So we want to isolate the hashsum from the filename
                        var sr = new StreamReader(tb_string.Text);
                        var hashfromfile = sr.ReadLine()?.Split(' ')[0];
                        sr.Close();

                        //Hash from the first field / The file to test for integrity
                        var filehash = CalculateHash(tb_file.Text, 0);
                        //Just compare both hashes
                        if (filehash.Equals(hashfromfile))
                        {
                            tb_hash.Text = @"hashes ARE the same";
                        }
                        else
                        {
                            tb_hash.Text = @"hahses are NOT the same";

                            if (hashfromfile == null)
                            {
                                MessageBox.Show(@"An error occured while getting the hash from the hashsum file",
                                    @"An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (filehash.Length != hashfromfile.Length)
                            {
                                MessageBox.Show(@"You hashed the input file as " + GetHashType(filehash) + @" but the second hash is " + GetHashType(hashfromfile) + @". You may want to switch to " + GetHashType(hashfromfile), @"Unequal hash length", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show(@"Error while reading file", @"Can't read file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var filehash = CalculateHash(tb_file.Text, 0);
                    var secondhash = tb_string.Text;

                    //Just compare both hashes
                    if (filehash.Equals(secondhash))
                    {
                        tb_hash.Text = @"hashes ARE the same";
                    }
                    else
                    {
                        tb_hash.Text = @"hashes are NOT the same";

                        if (filehash.Length != secondhash.Length)
                        {
                            MessageBox.Show(@"You hashed the input file as " + GetHashType(filehash) + @" but the second hash is " + GetHashType(secondhash) + @". You may want to switch to " + GetHashType(secondhash), @"Unequal hash length", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void cb_compare_CheckedChanged(object sender, EventArgs e)
        {
            //Change button and label values to make it clear that compare mode is turned on
            if (cb_compare.Checked)
            {
                btn_browse2.Visible = true;
                btn_browse2.Enabled = true;
                lbl_or.Text = @"and enter a Hash / browse a hash file to compare to";
                _compare = true;
                btn_hash.Text = @"Compare";
            }
            else
            {
                btn_browse2.Visible = false;
                btn_browse2.Enabled = false;
                lbl_or.Text = @"or enter a String";
                _compare = false;
                btn_hash.Text = @"Calculate";
            }
        }

        private void btn_browse2_Click(object sender, EventArgs e)
        {
            //Open the file dialog and set the value of the textbox to the filepath of the selected file
            DialogResult result = fd2.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_string.Text = fd2.FileName;
            }
        }
    }
}
