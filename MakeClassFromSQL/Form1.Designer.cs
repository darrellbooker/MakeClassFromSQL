namespace MakeClassFromSQL
{
    partial class Form1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmdGenerateClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.chkQuickProperties = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 154);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(682, 71);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 276);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(682, 267);
            this.textBox3.TabIndex = 2;
            // 
            // cmdGenerateClass
            // 
            this.cmdGenerateClass.Location = new System.Drawing.Point(566, 245);
            this.cmdGenerateClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdGenerateClass.Name = "cmdGenerateClass";
            this.cmdGenerateClass.Size = new System.Drawing.Size(124, 19);
            this.cmdGenerateClass.TabIndex = 3;
            this.cmdGenerateClass.Text = "Generate Class";
            this.cmdGenerateClass.UseVisualStyleBackColor = true;
            this.cmdGenerateClass.Click += new System.EventHandler(this.cmdGenerateClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVB);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Location = new System.Drawing.Point(9, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(96, 41);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // rbVB
            // 
            this.rbVB.AutoSize = true;
            this.rbVB.Location = new System.Drawing.Point(54, 17);
            this.rbVB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVB.Name = "rbVB";
            this.rbVB.Size = new System.Drawing.Size(39, 17);
            this.rbVB.TabIndex = 1;
            this.rbVB.Text = "VB";
            this.rbVB.UseVisualStyleBackColor = true;
            this.rbVB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Checked = true;
            this.rbC.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbC.Location = new System.Drawing.Point(15, 17);
            this.rbC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(39, 17);
            this.rbC.TabIndex = 0;
            this.rbC.TabStop = true;
            this.rbC.Text = "C#";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // chkQuickProperties
            // 
            this.chkQuickProperties.AutoSize = true;
            this.chkQuickProperties.Location = new System.Drawing.Point(118, 247);
            this.chkQuickProperties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkQuickProperties.Name = "chkQuickProperties";
            this.chkQuickProperties.Size = new System.Drawing.Size(126, 17);
            this.chkQuickProperties.TabIndex = 5;
            this.chkQuickProperties.Text = "Use Quick Properties";
            this.chkQuickProperties.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.txtDB);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtUserID);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Configuration";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(255, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Database";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(314, 25);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(154, 20);
            this.txtDB.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(255, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(314, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 66);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Username";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(68, 59);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(154, 20);
            this.txtUserID.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Host";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(68, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 20);
            this.txtIP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkQuickProperties);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdGenerateClass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MakeClassFromSQL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cmdGenerateClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.CheckBox chkQuickProperties;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtDB;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtIP;
    }
}

