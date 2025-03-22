namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Time_now = new System.Windows.Forms.Label();
            this.Date_now = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Reset = new Guna.UI2.WinForms.Guna2Button();
            this.Start = new Guna.UI2.WinForms.Guna2Button();
            this.Alarm_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Picker_Time_Alarm = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Picker_Time_now = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Reset_Timer = new Guna.UI2.WinForms.Guna2Button();
            this.Stop_Timer = new Guna.UI2.WinForms.Guna2Button();
            this.StartTimer = new Guna.UI2.WinForms.Guna2Button();
            this.Seconds = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Minutes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Hours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Progress_Par = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.Progress_Par.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(280, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-6, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.Time_now);
            this.tabPage1.Controls.Add(this.Date_now);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       Time Now        ";
            // 
            // Time_now
            // 
            this.Time_now.AutoSize = true;
            this.Time_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_now.ForeColor = System.Drawing.Color.Aqua;
            this.Time_now.Location = new System.Drawing.Point(99, 97);
            this.Time_now.Name = "Time_now";
            this.Time_now.Size = new System.Drawing.Size(105, 24);
            this.Time_now.TabIndex = 4;
            this.Time_now.Text = "     00:00:00";
            // 
            // Date_now
            // 
            this.Date_now.AutoSize = true;
            this.Date_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_now.ForeColor = System.Drawing.Color.Azure;
            this.Date_now.Location = new System.Drawing.Point(108, 147);
            this.Date_now.Name = "Date_now";
            this.Date_now.Size = new System.Drawing.Size(110, 24);
            this.Date_now.TabIndex = 3;
            this.Date_now.Text = "dd/mm/yyyy";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.Reset);
            this.tabPage2.Controls.Add(this.Start);
            this.tabPage2.Controls.Add(this.Alarm_time);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Picker_Time_Alarm);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Picker_Time_now);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "           Alarm            ";
            // 
            // Reset
            // 
            this.Reset.AutoRoundedCorners = true;
            this.Reset.BorderRadius = 21;
            this.Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(206, 269);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(102, 45);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Start
            // 
            this.Start.AutoRoundedCorners = true;
            this.Start.BorderRadius = 21;
            this.Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(19, 269);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(102, 45);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Alarm_time
            // 
            this.Alarm_time.AutoSize = true;
            this.Alarm_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm_time.ForeColor = System.Drawing.SystemColors.Control;
            this.Alarm_time.Location = new System.Drawing.Point(110, 222);
            this.Alarm_time.Name = "Alarm_time";
            this.Alarm_time.Size = new System.Drawing.Size(96, 25);
            this.Alarm_time.TabIndex = 5;
            this.Alarm_time.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(80, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Remaining Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alarm : ";
            // 
            // Picker_Time_Alarm
            // 
            this.Picker_Time_Alarm.AutoRoundedCorners = true;
            this.Picker_Time_Alarm.BorderRadius = 17;
            this.Picker_Time_Alarm.Checked = true;
            this.Picker_Time_Alarm.FillColor = System.Drawing.Color.Cyan;
            this.Picker_Time_Alarm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Picker_Time_Alarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Picker_Time_Alarm.Location = new System.Drawing.Point(170, 98);
            this.Picker_Time_Alarm.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Picker_Time_Alarm.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Picker_Time_Alarm.Name = "Picker_Time_Alarm";
            this.Picker_Time_Alarm.ShowUpDown = true;
            this.Picker_Time_Alarm.Size = new System.Drawing.Size(147, 36);
            this.Picker_Time_Alarm.TabIndex = 2;
            this.Picker_Time_Alarm.Value = new System.DateTime(2024, 11, 6, 19, 49, 24, 9);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Now : ";
            // 
            // Picker_Time_now
            // 
            this.Picker_Time_now.AutoRoundedCorners = true;
            this.Picker_Time_now.BorderRadius = 17;
            this.Picker_Time_now.Checked = true;
            this.Picker_Time_now.FillColor = System.Drawing.Color.Cyan;
            this.Picker_Time_now.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Picker_Time_now.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Picker_Time_now.Location = new System.Drawing.Point(170, 24);
            this.Picker_Time_now.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Picker_Time_now.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Picker_Time_now.Name = "Picker_Time_now";
            this.Picker_Time_now.ShowUpDown = true;
            this.Picker_Time_now.Size = new System.Drawing.Size(147, 36);
            this.Picker_Time_now.TabIndex = 0;
            this.Picker_Time_now.Value = new System.DateTime(2024, 11, 6, 19, 49, 24, 9);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.Reset_Timer);
            this.tabPage3.Controls.Add(this.Stop_Timer);
            this.tabPage3.Controls.Add(this.StartTimer);
            this.tabPage3.Controls.Add(this.Seconds);
            this.tabPage3.Controls.Add(this.Minutes);
            this.tabPage3.Controls.Add(this.Hours);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.Progress_Par);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(347, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "            Timer                      ";
            // 
            // Reset_Timer
            // 
            this.Reset_Timer.AutoRoundedCorners = true;
            this.Reset_Timer.BorderRadius = 21;
            this.Reset_Timer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reset_Timer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reset_Timer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset_Timer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reset_Timer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Reset_Timer.ForeColor = System.Drawing.Color.White;
            this.Reset_Timer.Location = new System.Drawing.Point(243, 290);
            this.Reset_Timer.Name = "Reset_Timer";
            this.Reset_Timer.Size = new System.Drawing.Size(83, 45);
            this.Reset_Timer.TabIndex = 11;
            this.Reset_Timer.Text = "Reset";
            this.Reset_Timer.Click += new System.EventHandler(this.Reset_Timer_Click);
            // 
            // Stop_Timer
            // 
            this.Stop_Timer.AutoRoundedCorners = true;
            this.Stop_Timer.BorderRadius = 21;
            this.Stop_Timer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Stop_Timer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Stop_Timer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Stop_Timer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Stop_Timer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Stop_Timer.ForeColor = System.Drawing.Color.White;
            this.Stop_Timer.Location = new System.Drawing.Point(116, 290);
            this.Stop_Timer.Name = "Stop_Timer";
            this.Stop_Timer.Size = new System.Drawing.Size(90, 45);
            this.Stop_Timer.TabIndex = 10;
            this.Stop_Timer.Tag = "1";
            this.Stop_Timer.Text = "Stop";
            this.Stop_Timer.Click += new System.EventHandler(this.Stop_Timer_Click);
            // 
            // StartTimer
            // 
            this.StartTimer.AutoRoundedCorners = true;
            this.StartTimer.BorderRadius = 21;
            this.StartTimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartTimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartTimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartTimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartTimer.ForeColor = System.Drawing.Color.White;
            this.StartTimer.Location = new System.Drawing.Point(6, 290);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(85, 45);
            this.StartTimer.TabIndex = 9;
            this.StartTimer.Text = "Start";
            this.StartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // Seconds
            // 
            this.Seconds.AutoRoundedCorners = true;
            this.Seconds.BackColor = System.Drawing.Color.Transparent;
            this.Seconds.BorderRadius = 17;
            this.Seconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Seconds.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Seconds.Location = new System.Drawing.Point(251, 49);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(66, 36);
            this.Seconds.TabIndex = 8;
            this.Seconds.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // Minutes
            // 
            this.Minutes.AutoRoundedCorners = true;
            this.Minutes.BackColor = System.Drawing.Color.Transparent;
            this.Minutes.BorderRadius = 17;
            this.Minutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Minutes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minutes.Location = new System.Drawing.Point(139, 49);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(66, 36);
            this.Minutes.TabIndex = 7;
            this.Minutes.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // Hours
            // 
            this.Hours.AutoRoundedCorners = true;
            this.Hours.BackColor = System.Drawing.Color.Transparent;
            this.Hours.BorderRadius = 17;
            this.Hours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Hours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Hours.Location = new System.Drawing.Point(25, 49);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(66, 36);
            this.Hours.TabIndex = 6;
            this.Hours.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(237, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(122, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hours";
            // 
            // Progress_Par
            // 
            this.Progress_Par.Controls.Add(this.Timer);
            this.Progress_Par.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Progress_Par.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Progress_Par.ForeColor = System.Drawing.Color.White;
            this.Progress_Par.Location = new System.Drawing.Point(83, 108);
            this.Progress_Par.Minimum = 0;
            this.Progress_Par.Name = "Progress_Par";
            this.Progress_Par.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Progress_Par.ProgressColor2 = System.Drawing.Color.Cyan;
            this.Progress_Par.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Progress_Par.Size = new System.Drawing.Size(167, 167);
            this.Progress_Par.TabIndex = 0;
            this.Progress_Par.Text = "guna2CircleProgressBar1";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.Aqua;
            this.Timer.Location = new System.Drawing.Point(42, 72);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(80, 24);
            this.Timer.TabIndex = 5;
            this.Timer.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(104, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timer";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(222, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(158, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(327, 498);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.Progress_Par.ResumeLayout(false);
            this.Progress_Par.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time_now;
        private System.Windows.Forms.Label Date_now;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Picker_Time_now;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker Picker_Time_Alarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Alarm_time;
        private Guna.UI2.WinForms.Guna2Button Reset;
        private Guna.UI2.WinForms.Guna2Button Start;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Progress_Par;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown Hours;
        private Guna.UI2.WinForms.Guna2NumericUpDown Seconds;
        private Guna.UI2.WinForms.Guna2NumericUpDown Minutes;
        private Guna.UI2.WinForms.Guna2Button StartTimer;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2Button Reset_Timer;
        private Guna.UI2.WinForms.Guna2Button Stop_Timer;
        private System.Windows.Forms.Timer timer3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}

