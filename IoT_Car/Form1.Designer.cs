namespace IoT_Car
{
    partial class IoT_Car_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UpPanel = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CopyrightPanel = new System.Windows.Forms.Panel();
            this.GithubButton = new System.Windows.Forms.Button();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.FormNamePanel = new System.Windows.Forms.Panel();
            this.FormNameLebal = new System.Windows.Forms.Label();
            this.DownPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GoBackButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TurnRightButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TurnLeftButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.AdvanceButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.QuitButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.StopRunButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SituRightButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SituLeftButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.AllStopButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.dragControl1 = new IoT_Car.DragControl();
            this.dragControl2 = new IoT_Car.DragControl();
            this.dragControl3 = new IoT_Car.DragControl();
            this.dragControl4 = new IoT_Car.DragControl();
            this.dragControl5 = new IoT_Car.DragControl();
            this.UpPanel.SuspendLayout();
            this.CopyrightPanel.SuspendLayout();
            this.FormNamePanel.SuspendLayout();
            this.DownPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.UpPanel.Controls.Add(this.HideButton);
            this.UpPanel.Controls.Add(this.CloseButton);
            this.UpPanel.Controls.Add(this.CopyrightPanel);
            this.UpPanel.Controls.Add(this.FormNamePanel);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(638, 45);
            this.UpPanel.TabIndex = 0;
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.Transparent;
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HideButton.ForeColor = System.Drawing.Color.White;
            this.HideButton.Location = new System.Drawing.Point(542, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(45, 45);
            this.HideButton.TabIndex = 13;
            this.HideButton.Text = "–";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(593, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "×";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // CopyrightPanel
            // 
            this.CopyrightPanel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightPanel.Controls.Add(this.GithubButton);
            this.CopyrightPanel.Controls.Add(this.CopyrightLabel);
            this.CopyrightPanel.Location = new System.Drawing.Point(214, 0);
            this.CopyrightPanel.Name = "CopyrightPanel";
            this.CopyrightPanel.Size = new System.Drawing.Size(323, 45);
            this.CopyrightPanel.TabIndex = 11;
            // 
            // GithubButton
            // 
            this.GithubButton.BackColor = System.Drawing.Color.Transparent;
            this.GithubButton.FlatAppearance.BorderSize = 0;
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GithubButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GithubButton.ForeColor = System.Drawing.Color.Black;
            this.GithubButton.Image = global::IoT_Car.Properties.Resources.Github_mark_24;
            this.GithubButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GithubButton.Location = new System.Drawing.Point(3, 8);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(124, 27);
            this.GithubButton.TabIndex = 8;
            this.GithubButton.Text = " K.J. Chen";
            this.GithubButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GithubButton.UseVisualStyleBackColor = false;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            this.GithubButton.MouseEnter += new System.EventHandler(this.GithubButton_MouseEnter);
            this.GithubButton.MouseLeave += new System.EventHandler(this.GithubButton_MouseLeave);
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(119, 12);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(203, 23);
            this.CopyrightLabel.TabIndex = 7;
            this.CopyrightLabel.Text = " © | All Rights Reserved";
            // 
            // FormNamePanel
            // 
            this.FormNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(75)))));
            this.FormNamePanel.Controls.Add(this.FormNameLebal);
            this.FormNamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FormNamePanel.Location = new System.Drawing.Point(0, 0);
            this.FormNamePanel.Name = "FormNamePanel";
            this.FormNamePanel.Size = new System.Drawing.Size(147, 45);
            this.FormNamePanel.TabIndex = 0;
            // 
            // FormNameLebal
            // 
            this.FormNameLebal.AutoSize = true;
            this.FormNameLebal.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNameLebal.ForeColor = System.Drawing.Color.White;
            this.FormNameLebal.Location = new System.Drawing.Point(23, 6);
            this.FormNameLebal.Name = "FormNameLebal";
            this.FormNameLebal.Size = new System.Drawing.Size(101, 33);
            this.FormNameLebal.TabIndex = 0;
            this.FormNameLebal.Text = "IoT Car";
            this.FormNameLebal.Click += new System.EventHandler(this.FormNameLebal_Click);
            // 
            // DownPanel
            // 
            this.DownPanel.BackColor = System.Drawing.SystemColors.Info;
            this.DownPanel.Controls.Add(this.tableLayoutPanel1);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownPanel.ForeColor = System.Drawing.Color.Black;
            this.DownPanel.Location = new System.Drawing.Point(0, 45);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(638, 453);
            this.DownPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.GoBackButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TurnRightButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TurnLeftButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdvanceButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.QuitButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StopRunButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SituRightButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SituLeftButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AllStopButton, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(119, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.color = System.Drawing.Color.Transparent;
            this.GoBackButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.Color.Black;
            this.GoBackButton.Image = global::IoT_Car.Properties.Resources.arrow_down_on_black_circular_background;
            this.GoBackButton.ImagePosition = 23;
            this.GoBackButton.ImageZoom = 40;
            this.GoBackButton.LabelPosition = 48;
            this.GoBackButton.LabelText = "Go Back";
            this.GoBackButton.Location = new System.Drawing.Point(139, 271);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(118, 118);
            this.GoBackButton.TabIndex = 15;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // TurnRightButton
            // 
            this.TurnRightButton.BackColor = System.Drawing.Color.Transparent;
            this.TurnRightButton.color = System.Drawing.Color.Transparent;
            this.TurnRightButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.TurnRightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnRightButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnRightButton.ForeColor = System.Drawing.Color.Black;
            this.TurnRightButton.Image = global::IoT_Car.Properties.Resources.arrow_pointing_right_in_a_circle;
            this.TurnRightButton.ImagePosition = 23;
            this.TurnRightButton.ImageZoom = 40;
            this.TurnRightButton.LabelPosition = 48;
            this.TurnRightButton.LabelText = "Turn Right";
            this.TurnRightButton.Location = new System.Drawing.Point(271, 139);
            this.TurnRightButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TurnRightButton.Name = "TurnRightButton";
            this.TurnRightButton.Size = new System.Drawing.Size(118, 118);
            this.TurnRightButton.TabIndex = 14;
            this.TurnRightButton.Click += new System.EventHandler(this.TurnRightButton_Click);
            // 
            // TurnLeftButton
            // 
            this.TurnLeftButton.BackColor = System.Drawing.Color.Transparent;
            this.TurnLeftButton.color = System.Drawing.Color.Transparent;
            this.TurnLeftButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.TurnLeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnLeftButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLeftButton.ForeColor = System.Drawing.Color.Black;
            this.TurnLeftButton.Image = global::IoT_Car.Properties.Resources.circle_with_an_arrow_pointing_to_left;
            this.TurnLeftButton.ImagePosition = 23;
            this.TurnLeftButton.ImageZoom = 40;
            this.TurnLeftButton.LabelPosition = 48;
            this.TurnLeftButton.LabelText = "Turn Left";
            this.TurnLeftButton.Location = new System.Drawing.Point(7, 139);
            this.TurnLeftButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TurnLeftButton.Name = "TurnLeftButton";
            this.TurnLeftButton.Size = new System.Drawing.Size(118, 118);
            this.TurnLeftButton.TabIndex = 13;
            this.TurnLeftButton.Click += new System.EventHandler(this.TurnLeftButton_Click);
            // 
            // AdvanceButton
            // 
            this.AdvanceButton.BackColor = System.Drawing.Color.Transparent;
            this.AdvanceButton.color = System.Drawing.Color.Transparent;
            this.AdvanceButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.AdvanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdvanceButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvanceButton.ForeColor = System.Drawing.Color.Black;
            this.AdvanceButton.Image = global::IoT_Car.Properties.Resources.arrow_up_on_a_black_circle_background;
            this.AdvanceButton.ImagePosition = 23;
            this.AdvanceButton.ImageZoom = 40;
            this.AdvanceButton.LabelPosition = 48;
            this.AdvanceButton.LabelText = "Advance";
            this.AdvanceButton.Location = new System.Drawing.Point(139, 7);
            this.AdvanceButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AdvanceButton.Name = "AdvanceButton";
            this.AdvanceButton.Size = new System.Drawing.Size(118, 118);
            this.AdvanceButton.TabIndex = 12;
            this.AdvanceButton.Click += new System.EventHandler(this.AdvanceButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.color = System.Drawing.Color.Transparent;
            this.QuitButton.colorActive = System.Drawing.Color.Red;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Black;
            this.QuitButton.Image = global::IoT_Car.Properties.Resources.remove;
            this.QuitButton.ImagePosition = 23;
            this.QuitButton.ImageZoom = 40;
            this.QuitButton.LabelPosition = 48;
            this.QuitButton.LabelText = "Quit";
            this.QuitButton.Location = new System.Drawing.Point(7, 271);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(118, 118);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // StopRunButton
            // 
            this.StopRunButton.BackColor = System.Drawing.Color.Transparent;
            this.StopRunButton.color = System.Drawing.Color.Transparent;
            this.StopRunButton.colorActive = System.Drawing.Color.Red;
            this.StopRunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopRunButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopRunButton.ForeColor = System.Drawing.Color.Black;
            this.StopRunButton.Image = global::IoT_Car.Properties.Resources.remove__1_;
            this.StopRunButton.ImagePosition = 23;
            this.StopRunButton.ImageZoom = 40;
            this.StopRunButton.LabelPosition = 48;
            this.StopRunButton.LabelText = "Stop Run";
            this.StopRunButton.Location = new System.Drawing.Point(139, 139);
            this.StopRunButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.StopRunButton.Name = "StopRunButton";
            this.StopRunButton.Size = new System.Drawing.Size(118, 118);
            this.StopRunButton.TabIndex = 10;
            this.StopRunButton.Click += new System.EventHandler(this.StopRunButton_Click);
            // 
            // SituRightButton
            // 
            this.SituRightButton.BackColor = System.Drawing.Color.Transparent;
            this.SituRightButton.color = System.Drawing.Color.Transparent;
            this.SituRightButton.colorActive = System.Drawing.Color.Aqua;
            this.SituRightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SituRightButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituRightButton.ForeColor = System.Drawing.Color.Black;
            this.SituRightButton.Image = global::IoT_Car.Properties.Resources.location_mark;
            this.SituRightButton.ImagePosition = 23;
            this.SituRightButton.ImageZoom = 50;
            this.SituRightButton.LabelPosition = 48;
            this.SituRightButton.LabelText = "Situ Right";
            this.SituRightButton.Location = new System.Drawing.Point(271, 7);
            this.SituRightButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SituRightButton.Name = "SituRightButton";
            this.SituRightButton.Size = new System.Drawing.Size(118, 118);
            this.SituRightButton.TabIndex = 9;
            this.SituRightButton.Click += new System.EventHandler(this.SituRightButton_Click);
            // 
            // SituLeftButton
            // 
            this.SituLeftButton.BackColor = System.Drawing.Color.Transparent;
            this.SituLeftButton.color = System.Drawing.Color.Transparent;
            this.SituLeftButton.colorActive = System.Drawing.Color.Aqua;
            this.SituLeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SituLeftButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituLeftButton.ForeColor = System.Drawing.Color.Black;
            this.SituLeftButton.Image = global::IoT_Car.Properties.Resources.location_mark;
            this.SituLeftButton.ImagePosition = 23;
            this.SituLeftButton.ImageZoom = 50;
            this.SituLeftButton.LabelPosition = 48;
            this.SituLeftButton.LabelText = "Situ Left";
            this.SituLeftButton.Location = new System.Drawing.Point(7, 7);
            this.SituLeftButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SituLeftButton.Name = "SituLeftButton";
            this.SituLeftButton.Size = new System.Drawing.Size(118, 118);
            this.SituLeftButton.TabIndex = 0;
            this.SituLeftButton.Click += new System.EventHandler(this.SituLeftButton_Click);
            this.SituLeftButton.MouseEnter += new System.EventHandler(this.SituLeftButton_MouseEnter);
            this.SituLeftButton.MouseLeave += new System.EventHandler(this.SituLeftButton_MouseLeave);
            // 
            // AllStopButton
            // 
            this.AllStopButton.BackColor = System.Drawing.Color.Transparent;
            this.AllStopButton.color = System.Drawing.Color.Transparent;
            this.AllStopButton.colorActive = System.Drawing.Color.Red;
            this.AllStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllStopButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStopButton.ForeColor = System.Drawing.Color.Black;
            this.AllStopButton.Image = global::IoT_Car.Properties.Resources.stop__1_;
            this.AllStopButton.ImagePosition = 23;
            this.AllStopButton.ImageZoom = 42;
            this.AllStopButton.LabelPosition = 48;
            this.AllStopButton.LabelText = "All Stop";
            this.AllStopButton.Location = new System.Drawing.Point(271, 271);
            this.AllStopButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AllStopButton.Name = "AllStopButton";
            this.AllStopButton.Size = new System.Drawing.Size(120, 122);
            this.AllStopButton.TabIndex = 8;
            this.AllStopButton.Click += new System.EventHandler(this.AllStopButton_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.FormNamePanel;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.FormNameLebal;
            // 
            // dragControl3
            // 
            this.dragControl3.SelectControl = this.UpPanel;
            // 
            // dragControl4
            // 
            this.dragControl4.SelectControl = this.CopyrightPanel;
            // 
            // dragControl5
            // 
            this.dragControl5.SelectControl = this.CopyrightLabel;
            // 
            // IoT_Car_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(638, 498);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IoT_Car_Form";
            this.Text = "冠儒智能小車操控面板";
            this.Load += new System.EventHandler(this.IoT_Car_Form_Load);
            this.UpPanel.ResumeLayout(false);
            this.CopyrightPanel.ResumeLayout(false);
            this.CopyrightPanel.PerformLayout();
            this.FormNamePanel.ResumeLayout(false);
            this.FormNamePanel.PerformLayout();
            this.DownPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel FormNamePanel;
        private System.Windows.Forms.Label FormNameLebal;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel CopyrightPanel;
        private System.Windows.Forms.Button GithubButton;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Panel DownPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuTileButton SituLeftButton;
        private Bunifu.Framework.UI.BunifuTileButton AllStopButton;
        private Bunifu.Framework.UI.BunifuTileButton SituRightButton;
        private Bunifu.Framework.UI.BunifuTileButton StopRunButton;
        private Bunifu.Framework.UI.BunifuTileButton QuitButton;
        private Bunifu.Framework.UI.BunifuTileButton AdvanceButton;
        private Bunifu.Framework.UI.BunifuTileButton GoBackButton;
        private Bunifu.Framework.UI.BunifuTileButton TurnRightButton;
        private Bunifu.Framework.UI.BunifuTileButton TurnLeftButton;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private DragControl dragControl3;
        private DragControl dragControl4;
        private DragControl dragControl5;
    }
}

