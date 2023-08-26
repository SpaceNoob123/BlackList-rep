namespace BlackList
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExistingProcesses = new System.Windows.Forms.ListBox();
            this.ProcessesWithRules = new System.Windows.Forms.ListBox();
            this.Block_btn = new System.Windows.Forms.Button();
            this.Unblock_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeAllowed_nud = new System.Windows.Forms.NumericUpDown();
            this.MaxLifeTime_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftLifeTime_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessName_lb = new System.Windows.Forms.Label();
            this.ProcessName_tb = new System.Windows.Forms.TextBox();
            this.Run_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeAllowed_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // ExistingProcesses
            // 
            this.ExistingProcesses.FormattingEnabled = true;
            this.ExistingProcesses.ItemHeight = 15;
            this.ExistingProcesses.Location = new System.Drawing.Point(12, 14);
            this.ExistingProcesses.Name = "ExistingProcesses";
            this.ExistingProcesses.Size = new System.Drawing.Size(243, 424);
            this.ExistingProcesses.TabIndex = 0;
            // 
            // ProcessesWithRules
            // 
            this.ProcessesWithRules.FormattingEnabled = true;
            this.ProcessesWithRules.ItemHeight = 15;
            this.ProcessesWithRules.Location = new System.Drawing.Point(432, 14);
            this.ProcessesWithRules.Name = "ProcessesWithRules";
            this.ProcessesWithRules.Size = new System.Drawing.Size(243, 154);
            this.ProcessesWithRules.TabIndex = 1;
            ProcessesWithRules.SelectedIndexChanged += AllowedTimeSelectedChanged;
            // 
            // Block_btn
            // 
            this.Block_btn.Location = new System.Drawing.Point(261, 12);
            this.Block_btn.Name = "Block_btn";
            this.Block_btn.Size = new System.Drawing.Size(165, 44);
            this.Block_btn.TabIndex = 2;
            this.Block_btn.Text = "Block process";
            this.Block_btn.UseVisualStyleBackColor = true;
            Block_btn.Click += BlockProcessClick;
            // 
            // Unblock_btn
            // 
            this.Unblock_btn.Location = new System.Drawing.Point(455, 404);
            this.Unblock_btn.Name = "Unblock_btn";
            this.Unblock_btn.Size = new System.Drawing.Size(165, 44);
            this.Unblock_btn.TabIndex = 3;
            this.Unblock_btn.Text = "Unblock process";
            this.Unblock_btn.UseVisualStyleBackColor = true;
            Unblock_btn.Click += UnblockProcessClick;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Block process .exe";
            this.button1.UseVisualStyleBackColor = true;
            button1.Click += BlockProcessExeClick;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Set time";
            this.button2.UseVisualStyleBackColor = true;
            button2.Click += SetAllowedTimeClick;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "time(min)";
            // 
            // TimeAllowed_nud
            // 
            this.TimeAllowed_nud.Location = new System.Drawing.Point(455, 325);
            this.TimeAllowed_nud.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.TimeAllowed_nud.Name = "TimeAllowed_nud";
            this.TimeAllowed_nud.Size = new System.Drawing.Size(120, 23);
            this.TimeAllowed_nud.TabIndex = 8;
            this.TimeAllowed_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxLifeTime_tb
            // 
            this.MaxLifeTime_tb.Location = new System.Drawing.Point(455, 234);
            this.MaxLifeTime_tb.Name = "MaxLifeTime_tb";
            this.MaxLifeTime_tb.ReadOnly = true;
            this.MaxLifeTime_tb.Size = new System.Drawing.Size(100, 23);
            this.MaxLifeTime_tb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max life time allowed";
            // 
            // LeftLifeTime_tb
            // 
            this.LeftLifeTime_tb.Location = new System.Drawing.Point(455, 278);
            this.LeftLifeTime_tb.Name = "LeftLifeTime_tb";
            this.LeftLifeTime_tb.ReadOnly = true;
            this.LeftLifeTime_tb.Size = new System.Drawing.Size(100, 23);
            this.LeftLifeTime_tb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Life time left today";
            // 
            // ProcessName_lb
            // 
            this.ProcessName_lb.AutoSize = true;
            this.ProcessName_lb.Location = new System.Drawing.Point(455, 171);
            this.ProcessName_lb.Name = "ProcessName_lb";
            this.ProcessName_lb.Size = new System.Drawing.Size(80, 15);
            this.ProcessName_lb.TabIndex = 14;
            this.ProcessName_lb.Text = "Process name";
            // 
            // ProcessName_tb
            // 
            this.ProcessName_tb.Location = new System.Drawing.Point(455, 190);
            this.ProcessName_tb.Name = "ProcessName_tb";
            this.ProcessName_tb.ReadOnly = true;
            this.ProcessName_tb.Size = new System.Drawing.Size(100, 23);
            this.ProcessName_tb.TabIndex = 13;
            // 
            // Run_btn
            // 
            this.Run_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Run_btn.Location = new System.Drawing.Point(261, 394);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(165, 44);
            this.Run_btn.TabIndex = 15;
            this.Run_btn.Text = "Start";
            this.Run_btn.UseVisualStyleBackColor = true;
            Run_btn.Click += RunClick;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.Run_btn);
            this.Controls.Add(this.ProcessName_lb);
            this.Controls.Add(this.ProcessName_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LeftLifeTime_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxLifeTime_tb);
            this.Controls.Add(this.TimeAllowed_nud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Unblock_btn);
            this.Controls.Add(this.Block_btn);
            this.Controls.Add(this.ProcessesWithRules);
            this.Controls.Add(this.ExistingProcesses);
            this.Name = "Admin";
            this.Text = "Admininstraitor";
            ((System.ComponentModel.ISupportInitialize)(this.TimeAllowed_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ExistingProcesses;
        private ListBox ProcessesWithRules;
        private Button Block_btn;
        private Button Unblock_btn;
        private Button button1;
        private Button button2;
        private Label label1;
        private NumericUpDown TimeAllowed_nud;
        private TextBox MaxLifeTime_tb;
        private Label label2;
        private TextBox LeftLifeTime_tb;
        private Label label3;
        private Label ProcessName_lb;
        private TextBox ProcessName_tb;
        private Button Run_btn;
    }
}