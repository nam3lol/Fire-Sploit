namespace Fire_Sploit
{
    partial class Loader
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
            this.TopPnl = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.StatusLbl = new Siticone.UI.WinForms.SiticoneLabel();
            this.ProgressBar = new Siticone.UI.WinForms.SiticoneCircleProgressBar();
            this.DragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.QuoteLbl = new Siticone.UI.WinForms.SiticoneLabel();
            this.CloseBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.CornerRadius = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.TopPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.Controls.Add(this.CloseBtn);
            this.TopPnl.FillColor = System.Drawing.Color.Red;
            this.TopPnl.FillColor2 = System.Drawing.Color.Orange;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.ShadowDecoration.Parent = this.TopPnl;
            this.TopPnl.Size = new System.Drawing.Size(242, 58);
            this.TopPnl.TabIndex = 0;
            // 
            // StatusLbl
            // 
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.Location = new System.Drawing.Point(40, 75);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(107, 32);
            this.StatusLbl.TabIndex = 1;
            this.StatusLbl.Text = "Getting Files";
            this.StatusLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Animated = true;
            this.ProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ProgressBar.Location = new System.Drawing.Point(52, 122);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.Red;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.Orange;
            this.ProgressBar.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar.ShadowDecoration.Parent = this.ProgressBar;
            this.ProgressBar.Size = new System.Drawing.Size(130, 130);
            this.ProgressBar.TabIndex = 2;
            // 
            // DragCtrl
            // 
            this.DragCtrl.TargetControl = this.TopPnl;
            // 
            // QuoteLbl
            // 
            this.QuoteLbl.BackColor = System.Drawing.Color.Transparent;
            this.QuoteLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLbl.ForeColor = System.Drawing.Color.White;
            this.QuoteLbl.Location = new System.Drawing.Point(59, 264);
            this.QuoteLbl.Name = "QuoteLbl";
            this.QuoteLbl.Size = new System.Drawing.Size(82, 25);
            this.QuoteLbl.TabIndex = 3;
            this.QuoteLbl.Text = "Getting Files";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoveredState.Parent = this.CloseBtn;
            this.CloseBtn.Image = global::Fire_Sploit.Properties.Resources.multiply_96px;
            this.CloseBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.CloseBtn.Location = new System.Drawing.Point(184, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(56, 58);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CornerRadius
            // 
            this.CornerRadius.BorderRadius = 14;
            this.CornerRadius.TargetControl = this;
            // 
            // Loader
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(241, 301);
            this.Controls.Add(this.QuoteLbl);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.TopPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire-Sploit | Loading Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loader_Load);
            this.TopPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientPanel TopPnl;
        private Siticone.UI.WinForms.SiticoneGradientButton CloseBtn;
        private Siticone.UI.WinForms.SiticoneLabel StatusLbl;
        private Siticone.UI.WinForms.SiticoneCircleProgressBar ProgressBar;
        private Siticone.UI.WinForms.SiticoneDragControl DragCtrl;
        private Siticone.UI.WinForms.SiticoneLabel QuoteLbl;
        private Siticone.UI.WinForms.SiticoneElipse CornerRadius;
    }
}

