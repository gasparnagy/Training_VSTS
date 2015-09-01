using System.Linq;
using System;

namespace T100
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.origMessageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.decrButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rotor1Selector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rotor2Selector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rotor3Selector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rotor1Position = new System.Windows.Forms.ComboBox();
            this.rotor2Position = new System.Windows.Forms.ComboBox();
            this.rotor3Position = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // origMessageTextBox
            // 
            this.origMessageTextBox.Location = new System.Drawing.Point(15, 322);
            this.origMessageTextBox.Multiline = true;
            this.origMessageTextBox.Name = "origMessageTextBox";
            this.origMessageTextBox.ReadOnly = true;
            this.origMessageTextBox.Size = new System.Drawing.Size(256, 61);
            this.origMessageTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Decrypted message";
            // 
            // encButton
            // 
            this.encButton.Location = new System.Drawing.Point(277, 154);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(100, 61);
            this.encButton.TabIndex = 18;
            this.encButton.Text = "Encrypt";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(15, 238);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(256, 61);
            this.resultTextBox.TabIndex = 17;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(15, 154);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(256, 61);
            this.messageTextBox.TabIndex = 16;
            this.messageTextBox.Text = "Welcome to Microsoft University";
            // 
            // decrButton
            // 
            this.decrButton.Location = new System.Drawing.Point(277, 238);
            this.decrButton.Name = "decrButton";
            this.decrButton.Size = new System.Drawing.Size(100, 61);
            this.decrButton.TabIndex = 15;
            this.decrButton.Text = "Decrypt";
            this.decrButton.UseVisualStyleBackColor = true;
            this.decrButton.Click += new System.EventHandler(this.decrButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Encrypted message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Message to encrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Key";
            // 
            // rotor1Selector
            // 
            this.rotor1Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotor1Selector.FormattingEnabled = true;
            this.rotor1Selector.Items.AddRange(new object[] {
            "n/a",
            "Shift",
            "Mod",
            "TE"});
            this.rotor1Selector.Location = new System.Drawing.Point(49, 33);
            this.rotor1Selector.Name = "rotor1Selector";
            this.rotor1Selector.Size = new System.Drawing.Size(130, 21);
            this.rotor1Selector.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "rotor I";
            // 
            // rotor2Selector
            // 
            this.rotor2Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotor2Selector.FormattingEnabled = true;
            this.rotor2Selector.Items.AddRange(new object[] {
            "n/a",
            "Shift",
            "Mod",
            "TE"});
            this.rotor2Selector.Location = new System.Drawing.Point(49, 60);
            this.rotor2Selector.Name = "rotor2Selector";
            this.rotor2Selector.Size = new System.Drawing.Size(130, 21);
            this.rotor2Selector.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "rotor II";
            // 
            // rotor3Selector
            // 
            this.rotor3Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotor3Selector.FormattingEnabled = true;
            this.rotor3Selector.Items.AddRange(new object[] {
            "n/a",
            "Shift",
            "Mod",
            "TE"});
            this.rotor3Selector.Location = new System.Drawing.Point(50, 87);
            this.rotor3Selector.Name = "rotor3Selector";
            this.rotor3Selector.Size = new System.Drawing.Size(129, 21);
            this.rotor3Selector.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "rotor III";
            // 
            // rotor1Position
            // 
            this.rotor1Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotor1Position.FormattingEnabled = true;
            this.rotor1Position.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.rotor1Position.Location = new System.Drawing.Point(185, 33);
            this.rotor1Position.Name = "rotor1Position";
            this.rotor1Position.Size = new System.Drawing.Size(63, 21);
            this.rotor1Position.TabIndex = 35;
            // 
            // rotor2Position
            // 
            this.rotor2Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotor2Position.FormattingEnabled = true;
            this.rotor2Position.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.rotor2Position.Location = new System.Drawing.Point(185, 60);
            this.rotor2Position.Name = "rotor2Position";
            this.rotor2Position.Size = new System.Drawing.Size(63, 21);
            this.rotor2Position.TabIndex = 34;
            // 
            // rotor3Position
            // 
            this.rotor3Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rotor3Position.FormattingEnabled = true;
            this.rotor3Position.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.rotor3Position.Location = new System.Drawing.Point(185, 87);
            this.rotor3Position.Name = "rotor3Position";
            this.rotor3Position.Size = new System.Drawing.Size(63, 21);
            this.rotor3Position.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rotor3Position);
            this.groupBox1.Controls.Add(this.rotor2Position);
            this.groupBox1.Controls.Add(this.rotor1Position);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rotor3Selector);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rotor2Selector);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rotor1Selector);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 117);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.origMessageTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.encButton);
            this.panel1.Controls.Add(this.resultTextBox);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(this.decrButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 420);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 420);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "T100 Console";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox origMessageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button decrButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rotor1Selector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rotor2Selector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rotor3Selector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rotor1Position;
        private System.Windows.Forms.ComboBox rotor2Position;
        private System.Windows.Forms.ComboBox rotor3Position;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

