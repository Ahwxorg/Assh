
namespace Assh
{
    partial class MainWindow
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new GhostButton();
            this.closeBtn = new GhostButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.host7Label = new System.Windows.Forms.Label();
            this.host6Label = new System.Windows.Forms.Label();
            this.host5Label = new System.Windows.Forms.Label();
            this.host4Label = new System.Windows.Forms.Label();
            this.host3Label = new System.Windows.Forms.Label();
            this.host2Label = new System.Windows.Forms.Label();
            this.editBtn = new GhostButton();
            this.host1Label = new System.Windows.Forms.Label();
            this.sshBtn_6 = new GhostButton();
            this.sshBtn_7 = new GhostButton();
            this.sshBtn_5 = new GhostButton();
            this.sshBtn_4 = new GhostButton();
            this.sshBtn_3 = new GhostButton();
            this.sshBtn_2 = new GhostButton();
            this.sshBtn = new GhostButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Location = new System.Drawing.Point(-2, -3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(8000, 45);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.minimizeBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 32.25F);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.minimizeBtn.Location = new System.Drawing.Point(986, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.RippleSpeed = 10;
            this.minimizeBtn.RoundRadius = 3;
            this.minimizeBtn.Size = new System.Drawing.Size(45, 45);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.closeBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1031, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RippleSpeed = 10;
            this.closeBtn.RoundRadius = 3;
            this.closeBtn.Size = new System.Drawing.Size(45, 45);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(14, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 30);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Assh";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.leftPanel.Controls.Add(this.host7Label);
            this.leftPanel.Controls.Add(this.host6Label);
            this.leftPanel.Controls.Add(this.host5Label);
            this.leftPanel.Controls.Add(this.host4Label);
            this.leftPanel.Controls.Add(this.host3Label);
            this.leftPanel.Controls.Add(this.host2Label);
            this.leftPanel.Controls.Add(this.editBtn);
            this.leftPanel.Controls.Add(this.host1Label);
            this.leftPanel.Controls.Add(this.sshBtn_6);
            this.leftPanel.Controls.Add(this.sshBtn_7);
            this.leftPanel.Controls.Add(this.nameLabel);
            this.leftPanel.Controls.Add(this.sshBtn_5);
            this.leftPanel.Controls.Add(this.sshBtn_4);
            this.leftPanel.Controls.Add(this.sshBtn_3);
            this.leftPanel.Controls.Add(this.sshBtn_2);
            this.leftPanel.Controls.Add(this.sshBtn);
            this.leftPanel.Location = new System.Drawing.Point(-2, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(329, 50000);
            this.leftPanel.TabIndex = 2;
            // 
            // host7Label
            // 
            this.host7Label.AutoSize = true;
            this.host7Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host7Label.ForeColor = System.Drawing.Color.White;
            this.host7Label.Location = new System.Drawing.Point(175, 357);
            this.host7Label.Name = "host7Label";
            this.host7Label.Size = new System.Drawing.Size(38, 19);
            this.host7Label.TabIndex = 4;
            this.host7Label.Text = "Assh";
            // 
            // host6Label
            // 
            this.host6Label.AutoSize = true;
            this.host6Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host6Label.ForeColor = System.Drawing.Color.White;
            this.host6Label.Location = new System.Drawing.Point(175, 308);
            this.host6Label.Name = "host6Label";
            this.host6Label.Size = new System.Drawing.Size(38, 19);
            this.host6Label.TabIndex = 5;
            this.host6Label.Text = "Assh";
            // 
            // host5Label
            // 
            this.host5Label.AutoSize = true;
            this.host5Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host5Label.ForeColor = System.Drawing.Color.White;
            this.host5Label.Location = new System.Drawing.Point(175, 259);
            this.host5Label.Name = "host5Label";
            this.host5Label.Size = new System.Drawing.Size(38, 19);
            this.host5Label.TabIndex = 5;
            this.host5Label.Text = "Assh";
            // 
            // host4Label
            // 
            this.host4Label.AutoSize = true;
            this.host4Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host4Label.ForeColor = System.Drawing.Color.White;
            this.host4Label.Location = new System.Drawing.Point(175, 210);
            this.host4Label.Name = "host4Label";
            this.host4Label.Size = new System.Drawing.Size(38, 19);
            this.host4Label.TabIndex = 6;
            this.host4Label.Text = "Assh";
            // 
            // host3Label
            // 
            this.host3Label.AutoSize = true;
            this.host3Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host3Label.ForeColor = System.Drawing.Color.White;
            this.host3Label.Location = new System.Drawing.Point(175, 161);
            this.host3Label.Name = "host3Label";
            this.host3Label.Size = new System.Drawing.Size(38, 19);
            this.host3Label.TabIndex = 4;
            this.host3Label.Text = "Assh";
            // 
            // host2Label
            // 
            this.host2Label.AutoSize = true;
            this.host2Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host2Label.ForeColor = System.Drawing.Color.White;
            this.host2Label.Location = new System.Drawing.Point(175, 112);
            this.host2Label.Name = "host2Label";
            this.host2Label.Size = new System.Drawing.Size(38, 19);
            this.host2Label.TabIndex = 4;
            this.host2Label.Text = "Assh";
            // 
            // editBtn
            // 
            this.editBtn.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.editBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.editBtn.Location = new System.Drawing.Point(16, 612);
            this.editBtn.Name = "editBtn";
            this.editBtn.RippleSpeed = 10;
            this.editBtn.RoundRadius = 3;
            this.editBtn.Size = new System.Drawing.Size(138, 45);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit hosts";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // host1Label
            // 
            this.host1Label.AutoSize = true;
            this.host1Label.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.host1Label.ForeColor = System.Drawing.Color.White;
            this.host1Label.Location = new System.Drawing.Point(175, 63);
            this.host1Label.Name = "host1Label";
            this.host1Label.Size = new System.Drawing.Size(38, 19);
            this.host1Label.TabIndex = 3;
            this.host1Label.Text = "Assh";
            // 
            // sshBtn_6
            // 
            this.sshBtn_6.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_6.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn_6.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn_6.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn_6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn_6.ForeColor = System.Drawing.Color.White;
            this.sshBtn_6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn_6.Location = new System.Drawing.Point(15, 295);
            this.sshBtn_6.Name = "sshBtn_6";
            this.sshBtn_6.RippleSpeed = 10;
            this.sshBtn_6.RoundRadius = 3;
            this.sshBtn_6.Size = new System.Drawing.Size(138, 45);
            this.sshBtn_6.TabIndex = 7;
            this.sshBtn_6.Text = "SSH Host 6";
            this.sshBtn_6.UseVisualStyleBackColor = false;
            this.sshBtn_6.Click += new System.EventHandler(this.sshBtn_6_Click);
            // 
            // sshBtn_7
            // 
            this.sshBtn_7.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_7.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn_7.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn_7.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn_7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn_7.ForeColor = System.Drawing.Color.White;
            this.sshBtn_7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn_7.Location = new System.Drawing.Point(16, 344);
            this.sshBtn_7.Name = "sshBtn_7";
            this.sshBtn_7.RippleSpeed = 10;
            this.sshBtn_7.RoundRadius = 3;
            this.sshBtn_7.Size = new System.Drawing.Size(138, 45);
            this.sshBtn_7.TabIndex = 8;
            this.sshBtn_7.Text = "SSH Host 7";
            this.sshBtn_7.UseVisualStyleBackColor = false;
            this.sshBtn_7.Click += new System.EventHandler(this.sshBtn_7_Click);
            // 
            // sshBtn_5
            // 
            this.sshBtn_5.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_5.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn_5.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn_5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn_5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn_5.ForeColor = System.Drawing.Color.White;
            this.sshBtn_5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn_5.Location = new System.Drawing.Point(15, 246);
            this.sshBtn_5.Name = "sshBtn_5";
            this.sshBtn_5.RippleSpeed = 10;
            this.sshBtn_5.RoundRadius = 3;
            this.sshBtn_5.Size = new System.Drawing.Size(138, 45);
            this.sshBtn_5.TabIndex = 6;
            this.sshBtn_5.Text = "SSH Host 5";
            this.sshBtn_5.UseVisualStyleBackColor = false;
            this.sshBtn_5.Click += new System.EventHandler(this.sshBtn_5_Click);
            // 
            // sshBtn_4
            // 
            this.sshBtn_4.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_4.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn_4.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn_4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn_4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn_4.ForeColor = System.Drawing.Color.White;
            this.sshBtn_4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn_4.Location = new System.Drawing.Point(15, 197);
            this.sshBtn_4.Name = "sshBtn_4";
            this.sshBtn_4.RippleSpeed = 10;
            this.sshBtn_4.RoundRadius = 3;
            this.sshBtn_4.Size = new System.Drawing.Size(138, 45);
            this.sshBtn_4.TabIndex = 5;
            this.sshBtn_4.Text = "SSH Host 4";
            this.sshBtn_4.UseVisualStyleBackColor = false;
            this.sshBtn_4.Click += new System.EventHandler(this.sshBtn_4_Click);
            // 
            // sshBtn_3
            // 
            this.sshBtn_3.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_3.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn_3.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn_3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn_3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn_3.ForeColor = System.Drawing.Color.White;
            this.sshBtn_3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn_3.Location = new System.Drawing.Point(15, 148);
            this.sshBtn_3.Name = "sshBtn_3";
            this.sshBtn_3.RippleSpeed = 10;
            this.sshBtn_3.RoundRadius = 3;
            this.sshBtn_3.Size = new System.Drawing.Size(138, 45);
            this.sshBtn_3.TabIndex = 4;
            this.sshBtn_3.Text = "SSH Host 3";
            this.sshBtn_3.UseVisualStyleBackColor = false;
            this.sshBtn_3.Click += new System.EventHandler(this.sshBtn_3_Click);
            // 
            // sshBtn_2
            // 
            this.sshBtn_2.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_2.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn_2.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn_2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn_2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn_2.ForeColor = System.Drawing.Color.White;
            this.sshBtn_2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn_2.Location = new System.Drawing.Point(15, 99);
            this.sshBtn_2.Name = "sshBtn_2";
            this.sshBtn_2.RippleSpeed = 10;
            this.sshBtn_2.RoundRadius = 3;
            this.sshBtn_2.Size = new System.Drawing.Size(138, 45);
            this.sshBtn_2.TabIndex = 3;
            this.sshBtn_2.Text = "SSH Host 2";
            this.sshBtn_2.UseVisualStyleBackColor = false;
            this.sshBtn_2.Click += new System.EventHandler(this.sshBtn_2_Click);
            // 
            // sshBtn
            // 
            this.sshBtn.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn.BackColor = System.Drawing.Color.Transparent;
            this.sshBtn.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.sshBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sshBtn.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.sshBtn.ForeColor = System.Drawing.Color.White;
            this.sshBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sshBtn.Location = new System.Drawing.Point(16, 50);
            this.sshBtn.Name = "sshBtn";
            this.sshBtn.RippleSpeed = 10;
            this.sshBtn.RoundRadius = 3;
            this.sshBtn.Size = new System.Drawing.Size(138, 45);
            this.sshBtn.TabIndex = 2;
            this.sshBtn.Text = "SSH Host 1";
            this.sshBtn.UseVisualStyleBackColor = false;
            this.sshBtn.Click += new System.EventHandler(this.sshBtn_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.Location = new System.Drawing.Point(334, 50);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(740, 607);
            this.txtOutput.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 669);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Assh";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.topPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private GhostButton closeBtn;
        private GhostButton minimizeBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel leftPanel;
        private GhostButton sshBtn;
        private GhostButton sshBtn_7;
        private GhostButton sshBtn_6;
        private GhostButton sshBtn_5;
        private GhostButton sshBtn_4;
        private GhostButton sshBtn_3;
        private GhostButton sshBtn_2;
        private GhostButton editBtn;
        private System.Windows.Forms.Label host7Label;
        private System.Windows.Forms.Label host6Label;
        private System.Windows.Forms.Label host5Label;
        private System.Windows.Forms.Label host4Label;
        private System.Windows.Forms.Label host3Label;
        private System.Windows.Forms.Label host2Label;
        private System.Windows.Forms.Label host1Label;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

