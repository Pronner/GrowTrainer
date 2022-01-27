
namespace GrowTrainer
{
    partial class GrowTrainer
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnConnect = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAntiRespawn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModFly = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbFastFall = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbGrowz = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbGhost = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnConnect.BorderRadius = 9;
            this.btnConnect.BorderThickness = 1;
            this.btnConnect.CheckedState.Parent = this.btnConnect;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.CustomImages.Parent = this.btnConnect;
            this.btnConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnect.DisabledState.Parent = this.btnConnect;
            this.btnConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConnect.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.HoverState.Parent = this.btnConnect;
            this.btnConnect.Image = global::GrowTrainer.Properties.Resources._3_31942_crown_tx_mom_crown_growtopia;
            this.btnConnect.ImageSize = new System.Drawing.Size(27, 20);
            this.btnConnect.Location = new System.Drawing.Point(22, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.ShadowDecoration.Parent = this.btnConnect;
            this.btnConnect.Size = new System.Drawing.Size(203, 45);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Growtopia";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "GrowTrainer Dashboard";
            // 
            // cbAntiRespawn
            // 
            this.cbAntiRespawn.Animated = true;
            this.cbAntiRespawn.AutoSize = true;
            this.cbAntiRespawn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbAntiRespawn.CheckedState.BorderRadius = 3;
            this.cbAntiRespawn.CheckedState.BorderThickness = 1;
            this.cbAntiRespawn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbAntiRespawn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAntiRespawn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAntiRespawn.ForeColor = System.Drawing.Color.White;
            this.cbAntiRespawn.Location = new System.Drawing.Point(25, 105);
            this.cbAntiRespawn.Name = "cbAntiRespawn";
            this.cbAntiRespawn.Size = new System.Drawing.Size(99, 20);
            this.cbAntiRespawn.TabIndex = 2;
            this.cbAntiRespawn.Text = "Anti Respawn";
            this.cbAntiRespawn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbAntiRespawn.UncheckedState.BorderRadius = 3;
            this.cbAntiRespawn.UncheckedState.BorderThickness = 1;
            this.cbAntiRespawn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbAntiRespawn.CheckedChanged += new System.EventHandler(this.cbAntiRespawn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOTE: Ban Bypass is automatically enabled when connecting to Growtopia.";
            // 
            // cbModFly
            // 
            this.cbModFly.Animated = true;
            this.cbModFly.AutoSize = true;
            this.cbModFly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbModFly.CheckedState.BorderRadius = 3;
            this.cbModFly.CheckedState.BorderThickness = 1;
            this.cbModFly.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbModFly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbModFly.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F);
            this.cbModFly.ForeColor = System.Drawing.Color.White;
            this.cbModFly.Location = new System.Drawing.Point(25, 131);
            this.cbModFly.Name = "cbModFly";
            this.cbModFly.Size = new System.Drawing.Size(67, 20);
            this.cbModFly.TabIndex = 5;
            this.cbModFly.Text = "ModFly";
            this.cbModFly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbModFly.UncheckedState.BorderRadius = 3;
            this.cbModFly.UncheckedState.BorderThickness = 1;
            this.cbModFly.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbModFly.CheckedChanged += new System.EventHandler(this.cbModFly_CheckedChanged);
            // 
            // cbFastFall
            // 
            this.cbFastFall.Animated = true;
            this.cbFastFall.AutoSize = true;
            this.cbFastFall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbFastFall.CheckedState.BorderRadius = 3;
            this.cbFastFall.CheckedState.BorderThickness = 1;
            this.cbFastFall.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbFastFall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFastFall.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F);
            this.cbFastFall.ForeColor = System.Drawing.Color.White;
            this.cbFastFall.Location = new System.Drawing.Point(25, 157);
            this.cbFastFall.Name = "cbFastFall";
            this.cbFastFall.Size = new System.Drawing.Size(66, 20);
            this.cbFastFall.TabIndex = 6;
            this.cbFastFall.Text = "FastFall";
            this.cbFastFall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbFastFall.UncheckedState.BorderRadius = 3;
            this.cbFastFall.UncheckedState.BorderThickness = 1;
            this.cbFastFall.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbFastFall.CheckedChanged += new System.EventHandler(this.cbFastFall_CheckedChanged);
            // 
            // cbGrowz
            // 
            this.cbGrowz.Animated = true;
            this.cbGrowz.AutoSize = true;
            this.cbGrowz.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbGrowz.CheckedState.BorderRadius = 3;
            this.cbGrowz.CheckedState.BorderThickness = 1;
            this.cbGrowz.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbGrowz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGrowz.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F);
            this.cbGrowz.ForeColor = System.Drawing.Color.White;
            this.cbGrowz.Location = new System.Drawing.Point(25, 183);
            this.cbGrowz.Name = "cbGrowz";
            this.cbGrowz.Size = new System.Drawing.Size(60, 20);
            this.cbGrowz.TabIndex = 7;
            this.cbGrowz.Text = "Growz";
            this.cbGrowz.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbGrowz.UncheckedState.BorderRadius = 3;
            this.cbGrowz.UncheckedState.BorderThickness = 1;
            this.cbGrowz.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbGrowz.CheckedChanged += new System.EventHandler(this.cbGrowz_CheckedChanged);
            // 
            // cbGhost
            // 
            this.cbGhost.Animated = true;
            this.cbGhost.AutoSize = true;
            this.cbGhost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbGhost.CheckedState.BorderRadius = 3;
            this.cbGhost.CheckedState.BorderThickness = 1;
            this.cbGhost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbGhost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGhost.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F);
            this.cbGhost.ForeColor = System.Drawing.Color.White;
            this.cbGhost.Location = new System.Drawing.Point(25, 209);
            this.cbGhost.Name = "cbGhost";
            this.cbGhost.Size = new System.Drawing.Size(58, 20);
            this.cbGhost.TabIndex = 8;
            this.cbGhost.Text = "Ghost";
            this.cbGhost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbGhost.UncheckedState.BorderRadius = 3;
            this.cbGhost.UncheckedState.BorderThickness = 1;
            this.cbGhost.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbGhost.CheckedChanged += new System.EventHandler(this.cbGhost_CheckedChanged);
            // 
            // GrowTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(915, 535);
            this.Controls.Add(this.cbGhost);
            this.Controls.Add(this.cbGrowz);
            this.Controls.Add(this.cbFastFall);
            this.Controls.Add(this.cbModFly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAntiRespawn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GrowTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrowTrainer";
            this.Load += new System.EventHandler(this.GrowTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2Button btnConnect;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox cbAntiRespawn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox cbModFly;
        private Guna.UI2.WinForms.Guna2CheckBox cbFastFall;
        private Guna.UI2.WinForms.Guna2CheckBox cbGrowz;
        private Guna.UI2.WinForms.Guna2CheckBox cbGhost;
    }
}

