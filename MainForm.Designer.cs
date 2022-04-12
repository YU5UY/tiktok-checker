namespace FuckTiktok
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RandomLength = new FuckTiktok.CustomTrackBar();
            this.ThreadCounts = new FuckTiktok.CustomTrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelRandomLength = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelThreadCounts = new System.Windows.Forms.Label();
            this.Checked = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Unknown = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Valid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Bad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LengthUsers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultArea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainWorker = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadCounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 10);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 18);
            this.StatusLabel.TabIndex = 1;
            // 
            // Worker
            // 
            this.Worker.WorkerSupportsCancellation = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.RandomLength);
            this.MainPanel.Controls.Add(this.ThreadCounts);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.radioButton1);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.radioButton2);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.ResultArea);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(4, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(362, 524);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Visible = false;
            // 
            // RandomLength
            // 
            this.RandomLength.BackColor = System.Drawing.Color.Black;
            this.RandomLength.LargeChange = 1;
            this.RandomLength.Location = new System.Drawing.Point(130, 66);
            this.RandomLength.Minimum = 1;
            this.RandomLength.Name = "RandomLength";
            this.RandomLength.Size = new System.Drawing.Size(216, 45);
            this.RandomLength.TabIndex = 13;
            this.RandomLength.Value = 4;
            this.RandomLength.Scroll += new System.EventHandler(this.RandomLength_Scroll);
            // 
            // ThreadCounts
            // 
            this.ThreadCounts.BackColor = System.Drawing.Color.Black;
            this.ThreadCounts.LargeChange = 1;
            this.ThreadCounts.Location = new System.Drawing.Point(99, 15);
            this.ThreadCounts.Maximum = 50;
            this.ThreadCounts.Minimum = 1;
            this.ThreadCounts.Name = "ThreadCounts";
            this.ThreadCounts.Size = new System.Drawing.Size(262, 45);
            this.ThreadCounts.TabIndex = 12;
            this.ThreadCounts.Value = 5;
            this.ThreadCounts.Scroll += new System.EventHandler(this.customTrackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Random Lenght :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check type : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(142, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "From File";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelRandomLength);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LabelThreadCounts);
            this.groupBox1.Controls.Add(this.Checked);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Unknown);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Valid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Bad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LengthUsers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StateLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 166);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // LabelRandomLength
            // 
            this.LabelRandomLength.AutoSize = true;
            this.LabelRandomLength.ForeColor = System.Drawing.Color.Yellow;
            this.LabelRandomLength.Location = new System.Drawing.Point(271, 54);
            this.LabelRandomLength.Name = "LabelRandomLength";
            this.LabelRandomLength.Size = new System.Drawing.Size(16, 18);
            this.LabelRandomLength.TabIndex = 26;
            this.LabelRandomLength.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(195, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "RandLen : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(195, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Bots :";
            // 
            // LabelThreadCounts
            // 
            this.LabelThreadCounts.AutoSize = true;
            this.LabelThreadCounts.ForeColor = System.Drawing.Color.Yellow;
            this.LabelThreadCounts.Location = new System.Drawing.Point(248, 27);
            this.LabelThreadCounts.Name = "LabelThreadCounts";
            this.LabelThreadCounts.Size = new System.Drawing.Size(16, 18);
            this.LabelThreadCounts.TabIndex = 24;
            this.LabelThreadCounts.Text = "5";
            // 
            // Checked
            // 
            this.Checked.AutoSize = true;
            this.Checked.ForeColor = System.Drawing.Color.Fuchsia;
            this.Checked.Location = new System.Drawing.Point(135, 90);
            this.Checked.Name = "Checked";
            this.Checked.Size = new System.Drawing.Size(16, 18);
            this.Checked.TabIndex = 22;
            this.Checked.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Fuchsia;
            this.label13.Location = new System.Drawing.Point(56, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Checked : ";
            // 
            // Unknown
            // 
            this.Unknown.AutoSize = true;
            this.Unknown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Unknown.Location = new System.Drawing.Point(262, 120);
            this.Unknown.Name = "Unknown";
            this.Unknown.Size = new System.Drawing.Size(16, 18);
            this.Unknown.TabIndex = 20;
            this.Unknown.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(185, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Unknown : ";
            // 
            // Valid
            // 
            this.Valid.AutoSize = true;
            this.Valid.ForeColor = System.Drawing.Color.Lime;
            this.Valid.Location = new System.Drawing.Point(231, 90);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(16, 18);
            this.Valid.TabIndex = 16;
            this.Valid.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(185, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valid :";
            // 
            // Bad
            // 
            this.Bad.AutoSize = true;
            this.Bad.ForeColor = System.Drawing.Color.Red;
            this.Bad.Location = new System.Drawing.Point(99, 120);
            this.Bad.Name = "Bad";
            this.Bad.Size = new System.Drawing.Size(16, 18);
            this.Bad.TabIndex = 14;
            this.Bad.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(57, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bad :";
            // 
            // LengthUsers
            // 
            this.LengthUsers.AutoSize = true;
            this.LengthUsers.ForeColor = System.Drawing.Color.Yellow;
            this.LengthUsers.Location = new System.Drawing.Point(105, 54);
            this.LengthUsers.Name = "LengthUsers";
            this.LengthUsers.Size = new System.Drawing.Size(69, 18);
            this.LengthUsers.TabIndex = 12;
            this.LengthUsers.Text = "Unlimited";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(47, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status : ";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.ForeColor = System.Drawing.Color.Yellow;
            this.StateLabel.Location = new System.Drawing.Point(109, 27);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(63, 18);
            this.StateLabel.TabIndex = 10;
            this.StateLabel.Text = "Stopped";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(47, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Users : ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(237, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 22);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Random";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // ResultArea
            // 
            this.ResultArea.BackColor = System.Drawing.Color.Black;
            this.ResultArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultArea.ForeColor = System.Drawing.Color.Lime;
            this.ResultArea.Location = new System.Drawing.Point(0, 407);
            this.ResultArea.MaxLength = 0;
            this.ResultArea.Multiline = true;
            this.ResultArea.Name = "ResultArea";
            this.ResultArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultArea.Size = new System.Drawing.Size(362, 117);
            this.ResultArea.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(83, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bots count : ";
            // 
            // MainWorker
            // 
            this.MainWorker.WorkerSupportsCancellation = true;
            this.MainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainWorker_DoWork);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(331, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(375, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.StatusLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 593);
            this.MinimumSize = new System.Drawing.Size(391, 593);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiktokBomb - telegram @yu5uy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RandomLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadCounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatusLabel;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LengthUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Checked;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Unknown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Valid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Bad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker MainWorker;
        private CustomTrackBar ThreadCounts;
        private CustomTrackBar RandomLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelThreadCounts;
        private System.Windows.Forms.Label LabelRandomLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}

