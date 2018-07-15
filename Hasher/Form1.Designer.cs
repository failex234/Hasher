namespace Hasher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_selectfile = new System.Windows.Forms.Label();
            this.tb_string = new System.Windows.Forms.TextBox();
            this.lbl_or = new System.Windows.Forms.Label();
            this.rb_md5 = new System.Windows.Forms.RadioButton();
            this.rb_sha256 = new System.Windows.Forms.RadioButton();
            this.rb_sha512 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hash = new System.Windows.Forms.Button();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.btn_browse2 = new System.Windows.Forms.Button();
            this.cb_compare = new System.Windows.Forms.CheckBox();
            this.fd2 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(12, 29);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(535, 20);
            this.tb_file.TabIndex = 0;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(554, 28);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(30, 20);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_selectfile
            // 
            this.lbl_selectfile.AutoSize = true;
            this.lbl_selectfile.Location = new System.Drawing.Point(250, 9);
            this.lbl_selectfile.Name = "lbl_selectfile";
            this.lbl_selectfile.Size = new System.Drawing.Size(56, 13);
            this.lbl_selectfile.TabIndex = 2;
            this.lbl_selectfile.Text = "Select File";
            // 
            // tb_string
            // 
            this.tb_string.Location = new System.Drawing.Point(12, 72);
            this.tb_string.Name = "tb_string";
            this.tb_string.Size = new System.Drawing.Size(535, 20);
            this.tb_string.TabIndex = 3;
            // 
            // lbl_or
            // 
            this.lbl_or.AutoSize = true;
            this.lbl_or.Location = new System.Drawing.Point(238, 56);
            this.lbl_or.Name = "lbl_or";
            this.lbl_or.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_or.Size = new System.Drawing.Size(82, 13);
            this.lbl_or.TabIndex = 4;
            this.lbl_or.Text = "or enter a String";
            this.lbl_or.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_md5
            // 
            this.rb_md5.AutoSize = true;
            this.rb_md5.Location = new System.Drawing.Point(183, 138);
            this.rb_md5.Name = "rb_md5";
            this.rb_md5.Size = new System.Drawing.Size(48, 17);
            this.rb_md5.TabIndex = 5;
            this.rb_md5.TabStop = true;
            this.rb_md5.Text = "MD5";
            this.rb_md5.UseVisualStyleBackColor = true;
            // 
            // rb_sha256
            // 
            this.rb_sha256.AutoSize = true;
            this.rb_sha256.Location = new System.Drawing.Point(237, 138);
            this.rb_sha256.Name = "rb_sha256";
            this.rb_sha256.Size = new System.Drawing.Size(68, 17);
            this.rb_sha256.TabIndex = 6;
            this.rb_sha256.TabStop = true;
            this.rb_sha256.Text = "SHA-256";
            this.rb_sha256.UseVisualStyleBackColor = true;
            // 
            // rb_sha512
            // 
            this.rb_sha512.AutoSize = true;
            this.rb_sha512.Location = new System.Drawing.Point(311, 138);
            this.rb_sha512.Name = "rb_sha512";
            this.rb_sha512.Size = new System.Drawing.Size(68, 17);
            this.rb_sha512.TabIndex = 7;
            this.rb_sha512.TabStop = true;
            this.rb_sha512.Text = "SHA-512";
            this.rb_sha512.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Algorithm";
            // 
            // btn_hash
            // 
            this.btn_hash.Location = new System.Drawing.Point(224, 161);
            this.btn_hash.Name = "btn_hash";
            this.btn_hash.Size = new System.Drawing.Size(96, 31);
            this.btn_hash.TabIndex = 10;
            this.btn_hash.Text = "Calculate";
            this.btn_hash.UseVisualStyleBackColor = true;
            this.btn_hash.Click += new System.EventHandler(this.btn_hash_Click);
            // 
            // tb_hash
            // 
            this.tb_hash.Location = new System.Drawing.Point(12, 222);
            this.tb_hash.Name = "tb_hash";
            this.tb_hash.Size = new System.Drawing.Size(534, 20);
            this.tb_hash.TabIndex = 11;
            // 
            // btn_browse2
            // 
            this.btn_browse2.Enabled = false;
            this.btn_browse2.Location = new System.Drawing.Point(554, 72);
            this.btn_browse2.Name = "btn_browse2";
            this.btn_browse2.Size = new System.Drawing.Size(30, 20);
            this.btn_browse2.TabIndex = 12;
            this.btn_browse2.Text = "...";
            this.btn_browse2.UseVisualStyleBackColor = true;
            this.btn_browse2.Visible = false;
            this.btn_browse2.Click += new System.EventHandler(this.btn_browse2_Click);
            // 
            // cb_compare
            // 
            this.cb_compare.AutoSize = true;
            this.cb_compare.Location = new System.Drawing.Point(13, 99);
            this.cb_compare.Name = "cb_compare";
            this.cb_compare.Size = new System.Drawing.Size(68, 17);
            this.cb_compare.TabIndex = 13;
            this.cb_compare.Text = "Compare";
            this.cb_compare.UseVisualStyleBackColor = true;
            this.cb_compare.CheckedChanged += new System.EventHandler(this.cb_compare_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_compare);
            this.Controls.Add(this.btn_browse2);
            this.Controls.Add(this.tb_hash);
            this.Controls.Add(this.btn_hash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_sha512);
            this.Controls.Add(this.rb_sha256);
            this.Controls.Add(this.rb_md5);
            this.Controls.Add(this.lbl_or);
            this.Controls.Add(this.tb_string);
            this.Controls.Add(this.lbl_selectfile);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fd;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_selectfile;
        private System.Windows.Forms.TextBox tb_string;
        private System.Windows.Forms.Label lbl_or;
        private System.Windows.Forms.RadioButton rb_md5;
        private System.Windows.Forms.RadioButton rb_sha256;
        private System.Windows.Forms.RadioButton rb_sha512;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hash;
        private System.Windows.Forms.TextBox tb_hash;
        private System.Windows.Forms.Button btn_browse2;
        private System.Windows.Forms.CheckBox cb_compare;
        private System.Windows.Forms.OpenFileDialog fd2;
        private System.Windows.Forms.Label label2;
    }
}

