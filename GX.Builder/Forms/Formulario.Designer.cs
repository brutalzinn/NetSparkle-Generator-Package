namespace Update.Maker.Forms
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.releasenote_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.link_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.version_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shortversion_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.criticalupdate_textbox = new System.Windows.Forms.ComboBox();
            this.type_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.system_combobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.changelogfile_textbox = new System.Windows.Forms.TextBox();
            this.changelog_url_textbox = new System.Windows.Forms.TextBox();
            this.Chang9999 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PrefixVersion_checkbox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.androidversion_textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.androidmaximum_textbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.androidminimum_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // file_textbox
            // 
            this.file_textbox.Location = new System.Drawing.Point(105, 52);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.Size = new System.Drawing.Size(211, 20);
            this.file_textbox.TabIndex = 1;
            // 
            // releasenote_textbox
            // 
            this.releasenote_textbox.Location = new System.Drawing.Point(105, 78);
            this.releasenote_textbox.Name = "releasenote_textbox";
            this.releasenote_textbox.Size = new System.Drawing.Size(211, 20);
            this.releasenote_textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ReleaseNote";
            // 
            // link_textbox
            // 
            this.link_textbox.Location = new System.Drawing.Point(105, 115);
            this.link_textbox.Name = "link_textbox";
            this.link_textbox.Size = new System.Drawing.Size(211, 20);
            this.link_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Link";
            // 
            // version_textbox
            // 
            this.version_textbox.Location = new System.Drawing.Point(105, 151);
            this.version_textbox.Name = "version_textbox";
            this.version_textbox.Size = new System.Drawing.Size(211, 20);
            this.version_textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ShortVersion";
            // 
            // shortversion_textbox
            // 
            this.shortversion_textbox.Location = new System.Drawing.Point(105, 183);
            this.shortversion_textbox.Name = "shortversion_textbox";
            this.shortversion_textbox.Size = new System.Drawing.Size(211, 20);
            this.shortversion_textbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "System:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Type:";
            // 
            // criticalupdate_textbox
            // 
            this.criticalupdate_textbox.FormattingEnabled = true;
            this.criticalupdate_textbox.Items.AddRange(new object[] {
            "1",
            "0"});
            this.criticalupdate_textbox.Location = new System.Drawing.Point(105, 294);
            this.criticalupdate_textbox.Name = "criticalupdate_textbox";
            this.criticalupdate_textbox.Size = new System.Drawing.Size(211, 21);
            this.criticalupdate_textbox.TabIndex = 13;
            // 
            // type_textbox
            // 
            this.type_textbox.Location = new System.Drawing.Point(105, 257);
            this.type_textbox.Name = "type_textbox";
            this.type_textbox.Size = new System.Drawing.Size(211, 20);
            this.type_textbox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Critical update:";
            // 
            // system_combobox
            // 
            this.system_combobox.FormattingEnabled = true;
            this.system_combobox.Items.AddRange(new object[] {
            "windows",
            "linux"});
            this.system_combobox.Location = new System.Drawing.Point(109, 221);
            this.system_combobox.Name = "system_combobox";
            this.system_combobox.Size = new System.Drawing.Size(206, 21);
            this.system_combobox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "File:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 52);
            this.button2.TabIndex = 20;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // changelogfile_textbox
            // 
            this.changelogfile_textbox.Location = new System.Drawing.Point(105, 341);
            this.changelogfile_textbox.Name = "changelogfile_textbox";
            this.changelogfile_textbox.Size = new System.Drawing.Size(211, 20);
            this.changelogfile_textbox.TabIndex = 21;
            // 
            // changelog_url_textbox
            // 
            this.changelog_url_textbox.Location = new System.Drawing.Point(104, 378);
            this.changelog_url_textbox.Name = "changelog_url_textbox";
            this.changelog_url_textbox.Size = new System.Drawing.Size(211, 20);
            this.changelog_url_textbox.TabIndex = 22;
            // 
            // Chang9999
            // 
            this.Chang9999.AutoSize = true;
            this.Chang9999.Location = new System.Drawing.Point(15, 341);
            this.Chang9999.Name = "Chang9999";
            this.Chang9999.Size = new System.Drawing.Size(84, 13);
            this.Chang9999.TabIndex = 23;
            this.Chang9999.Text = "ChangeLog File:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Changelog URL:";
            // 
            // PrefixVersion_checkbox
            // 
            this.PrefixVersion_checkbox.AutoSize = true;
            this.PrefixVersion_checkbox.Location = new System.Drawing.Point(125, 525);
            this.PrefixVersion_checkbox.Name = "PrefixVersion_checkbox";
            this.PrefixVersion_checkbox.Size = new System.Drawing.Size(140, 17);
            this.PrefixVersion_checkbox.TabIndex = 25;
            this.PrefixVersion_checkbox.Text = "PrefixVersion_checkbox";
            this.PrefixVersion_checkbox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "PrefixVersion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Android Version:";
            // 
            // androidversion_textbox
            // 
            this.androidversion_textbox.Location = new System.Drawing.Point(104, 414);
            this.androidversion_textbox.Name = "androidversion_textbox";
            this.androidversion_textbox.Size = new System.Drawing.Size(211, 20);
            this.androidversion_textbox.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Android Maximum:";
            // 
            // androidmaximum_textbox
            // 
            this.androidmaximum_textbox.Location = new System.Drawing.Point(104, 450);
            this.androidmaximum_textbox.Name = "androidmaximum_textbox";
            this.androidmaximum_textbox.Size = new System.Drawing.Size(211, 20);
            this.androidmaximum_textbox.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Android Minimum:";
            // 
            // androidminimum_textbox
            // 
            this.androidminimum_textbox.Location = new System.Drawing.Point(105, 487);
            this.androidminimum_textbox.Name = "androidminimum_textbox";
            this.androidminimum_textbox.Size = new System.Drawing.Size(211, 20);
            this.androidminimum_textbox.TabIndex = 31;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 622);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.androidminimum_textbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.androidmaximum_textbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.androidversion_textbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PrefixVersion_checkbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Chang9999);
            this.Controls.Add(this.changelog_url_textbox);
            this.Controls.Add(this.changelogfile_textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.system_combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.type_textbox);
            this.Controls.Add(this.criticalupdate_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shortversion_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.version_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.releasenote_textbox);
            this.Controls.Add(this.file_textbox);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox file_textbox;
        private System.Windows.Forms.TextBox releasenote_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox link_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox version_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shortversion_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox criticalupdate_textbox;
        private System.Windows.Forms.TextBox type_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox system_combobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox changelogfile_textbox;
        private System.Windows.Forms.TextBox changelog_url_textbox;
        private System.Windows.Forms.Label Chang9999;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox PrefixVersion_checkbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox androidversion_textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox androidmaximum_textbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox androidminimum_textbox;
    }
}