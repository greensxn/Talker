namespace FormSayNumber
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
            if (disposing && (components != null)) {
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
            this.Area = new System.Windows.Forms.TextBox();
            this.btnSay = new System.Windows.Forms.Button();
            this.lbSubtext = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lineB1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lineB2 = new System.Windows.Forms.Panel();
            this.btnSayBtwn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.tb2b = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.tb1b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lineDelay = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.ForeColor = System.Drawing.Color.MediumBlue;
            this.Area.Location = new System.Drawing.Point(22, 36);
            this.Area.MaxLength = 18;
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(415, 22);
            this.Area.TabIndex = 0;
            this.Area.TabStop = false;
            this.Area.Text = "150";
            this.Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSay
            // 
            this.btnSay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSay.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSay.Location = new System.Drawing.Point(360, 131);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(114, 28);
            this.btnSay.TabIndex = 1;
            this.btnSay.TabStop = false;
            this.btnSay.Text = "Say";
            this.btnSay.UseCompatibleTextRendering = true;
            this.btnSay.UseVisualStyleBackColor = false;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // lbSubtext
            // 
            this.lbSubtext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbSubtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtext.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbSubtext.Location = new System.Drawing.Point(22, 62);
            this.lbSubtext.Name = "lbSubtext";
            this.lbSubtext.Size = new System.Drawing.Size(415, 23);
            this.lbSubtext.TabIndex = 3;
            this.lbSubtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineNum
            // 
            this.lineNum.BackColor = System.Drawing.Color.MediumBlue;
            this.lineNum.Location = new System.Drawing.Point(22, 60);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(415, 1);
            this.lineNum.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBox1.Location = new System.Drawing.Point(433, 63);
            this.comboBox1.MaxDropDownItems = 3;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voice:";
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioMan.Checked = true;
            this.radioMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMan.ForeColor = System.Drawing.Color.MediumBlue;
            this.radioMan.Location = new System.Drawing.Point(28, 37);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(54, 20);
            this.radioMan.TabIndex = 5;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "Man";
            this.radioMan.UseVisualStyleBackColor = false;
            this.radioMan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioWoman
            // 
            this.radioWoman.AutoSize = true;
            this.radioWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWoman.Location = new System.Drawing.Point(28, 61);
            this.radioWoman.Name = "radioWoman";
            this.radioWoman.Size = new System.Drawing.Size(77, 20);
            this.radioWoman.TabIndex = 5;
            this.radioWoman.Text = "Woman";
            this.radioWoman.UseVisualStyleBackColor = true;
            this.radioWoman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Between:";
            // 
            // lineB1
            // 
            this.lineB1.BackColor = System.Drawing.Color.MediumBlue;
            this.lineB1.Location = new System.Drawing.Point(31, 249);
            this.lineB1.Name = "lineB1";
            this.lineB1.Size = new System.Drawing.Size(415, 1);
            this.lineB1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "and";
            // 
            // lineB2
            // 
            this.lineB2.BackColor = System.Drawing.Color.MediumBlue;
            this.lineB2.Location = new System.Drawing.Point(31, 313);
            this.lineB2.Name = "lineB2";
            this.lineB2.Size = new System.Drawing.Size(415, 1);
            this.lineB2.TabIndex = 4;
            // 
            // btnSayBtwn
            // 
            this.btnSayBtwn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSayBtwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayBtwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayBtwn.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSayBtwn.Location = new System.Drawing.Point(360, 399);
            this.btnSayBtwn.Name = "btnSayBtwn";
            this.btnSayBtwn.Size = new System.Drawing.Size(114, 28);
            this.btnSayBtwn.TabIndex = 1;
            this.btnSayBtwn.TabStop = false;
            this.btnSayBtwn.Text = "Say";
            this.btnSayBtwn.UseCompatibleTextRendering = true;
            this.btnSayBtwn.UseVisualStyleBackColor = false;
            this.btnSayBtwn.Click += new System.EventHandler(this.btnSayBtwn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbDelay);
            this.panel3.Controls.Add(this.tb2b);
            this.panel3.Controls.Add(this.lbError);
            this.panel3.Controls.Add(this.tb1b);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lineDelay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(8, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 213);
            this.panel3.TabIndex = 8;
            // 
            // tbDelay
            // 
            this.tbDelay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDelay.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbDelay.Location = new System.Drawing.Point(109, 172);
            this.tbDelay.MaxLength = 4;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(80, 22);
            this.tbDelay.TabIndex = 0;
            this.tbDelay.TabStop = false;
            this.tbDelay.Text = "0";
            this.tbDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDelay.TextChanged += new System.EventHandler(this.tbDelay_TextChanged);
            this.tbDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDelay_KeyPress);
            // 
            // tb2b
            // 
            this.tb2b.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb2b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2b.ForeColor = System.Drawing.Color.MediumBlue;
            this.tb2b.Location = new System.Drawing.Point(23, 108);
            this.tb2b.MaxLength = 18;
            this.tb2b.Name = "tb2b";
            this.tb2b.Size = new System.Drawing.Size(415, 22);
            this.tb2b.TabIndex = 0;
            this.tb2b.TabStop = false;
            this.tb2b.Text = "10";
            this.tb2b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Maroon;
            this.lbError.Location = new System.Drawing.Point(367, 176);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(70, 21);
            this.lbError.TabIndex = 6;
            this.lbError.Text = "Error";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbError.UseCompatibleTextRendering = true;
            this.lbError.Visible = false;
            // 
            // tb1b
            // 
            this.tb1b.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb1b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1b.ForeColor = System.Drawing.Color.MediumBlue;
            this.tb1b.Location = new System.Drawing.Point(23, 44);
            this.tb1b.MaxLength = 18;
            this.tb1b.Name = "tb1b";
            this.tb1b.Size = new System.Drawing.Size(415, 22);
            this.tb1b.TabIndex = 0;
            this.tb1b.TabStop = false;
            this.tb1b.Text = "1";
            this.tb1b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Delay:";
            // 
            // lineDelay
            // 
            this.lineDelay.BackColor = System.Drawing.Color.MediumBlue;
            this.lineDelay.Location = new System.Drawing.Point(109, 196);
            this.lineDelay.Name = "lineDelay";
            this.lineDelay.Size = new System.Drawing.Size(80, 1);
            this.lineDelay.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbSubtext);
            this.panel4.Controls.Add(this.Area);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lineNum);
            this.panel4.Location = new System.Drawing.Point(8, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 92);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.radioMan);
            this.panel5.Controls.Add(this.radioWoman);
            this.panel5.Location = new System.Drawing.Point(522, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 92);
            this.panel5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 460);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.btnSayBtwn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineB2);
            this.Controls.Add(this.lineB1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Label lbSubtext;
        private System.Windows.Forms.Panel lineNum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lineB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel lineB2;
        private System.Windows.Forms.Button btnSayBtwn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb2b;
        private System.Windows.Forms.TextBox tb1b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel lineDelay;
        private System.Windows.Forms.Label lbError;
    }
}

