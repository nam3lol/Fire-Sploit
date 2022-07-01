namespace Fire_Sploit
{
    partial class ExecutorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutorForm));
            this.TopPnl = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.AttachBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.MiniBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.CloseBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.ScriptBox = new System.Windows.Forms.TreeView();
            this.TreeImg = new System.Windows.Forms.ImageList(this.components);
            this.DragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.ExecBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.ClrBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.OpenBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.SaveBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.ExecFileBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.CornerRadius = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.Editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.RefreshBtn = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.Controls.Add(this.AttachBtn);
            this.TopPnl.Controls.Add(this.MiniBtn);
            this.TopPnl.Controls.Add(this.CloseBtn);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.FillColor = System.Drawing.Color.Red;
            this.TopPnl.FillColor2 = System.Drawing.Color.Orange;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.ShadowDecoration.Parent = this.TopPnl;
            this.TopPnl.Size = new System.Drawing.Size(674, 58);
            this.TopPnl.TabIndex = 1;
            // 
            // AttachBtn
            // 
            this.AttachBtn.BackColor = System.Drawing.Color.Transparent;
            this.AttachBtn.CheckedState.Parent = this.AttachBtn;
            this.AttachBtn.CustomImages.Parent = this.AttachBtn;
            this.AttachBtn.FillColor = System.Drawing.Color.Transparent;
            this.AttachBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttachBtn.ForeColor = System.Drawing.Color.White;
            this.AttachBtn.HoveredState.Parent = this.AttachBtn;
            this.AttachBtn.Image = global::Fire_Sploit.Properties.Resources.syringe_96px;
            this.AttachBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.AttachBtn.Location = new System.Drawing.Point(506, 0);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.ShadowDecoration.Parent = this.AttachBtn;
            this.AttachBtn.Size = new System.Drawing.Size(56, 58);
            this.AttachBtn.TabIndex = 2;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.BackColor = System.Drawing.Color.Transparent;
            this.MiniBtn.CheckedState.Parent = this.MiniBtn;
            this.MiniBtn.CustomImages.Parent = this.MiniBtn;
            this.MiniBtn.FillColor = System.Drawing.Color.Transparent;
            this.MiniBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.MiniBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.HoveredState.Parent = this.MiniBtn;
            this.MiniBtn.Image = global::Fire_Sploit.Properties.Resources.subtract_96px;
            this.MiniBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.MiniBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.MiniBtn.Location = new System.Drawing.Point(562, 0);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.ShadowDecoration.Parent = this.MiniBtn;
            this.MiniBtn.Size = new System.Drawing.Size(56, 58);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
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
            this.CloseBtn.Location = new System.Drawing.Point(618, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(56, 58);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ScriptBox
            // 
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.ImageIndex = 0;
            this.ScriptBox.ImageList = this.TreeImg;
            this.ScriptBox.Location = new System.Drawing.Point(513, 65);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.SelectedImageIndex = 0;
            this.ScriptBox.Size = new System.Drawing.Size(154, 275);
            this.ScriptBox.TabIndex = 3;
            this.ScriptBox.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ScriptBox_NodeMouseDoubleClick);
            // 
            // TreeImg
            // 
            this.TreeImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImg.ImageStream")));
            this.TreeImg.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImg.Images.SetKeyName(0, "folder.png");
            this.TreeImg.Images.SetKeyName(1, "document.png");
            // 
            // DragCtrl
            // 
            this.DragCtrl.TargetControl = this.TopPnl;
            // 
            // ExecBtn
            // 
            this.ExecBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExecBtn.CheckedState.Parent = this.ExecBtn;
            this.ExecBtn.CustomImages.Parent = this.ExecBtn;
            this.ExecBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExecBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.ExecBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecBtn.ForeColor = System.Drawing.Color.White;
            this.ExecBtn.HoveredState.Parent = this.ExecBtn;
            this.ExecBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.ExecBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.ExecBtn.Location = new System.Drawing.Point(7, 346);
            this.ExecBtn.Name = "ExecBtn";
            this.ExecBtn.ShadowDecoration.Parent = this.ExecBtn;
            this.ExecBtn.Size = new System.Drawing.Size(88, 39);
            this.ExecBtn.TabIndex = 2;
            this.ExecBtn.Text = "Execute";
            this.ExecBtn.Click += new System.EventHandler(this.ExecBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClrBtn.CheckedState.Parent = this.ClrBtn;
            this.ClrBtn.CustomImages.Parent = this.ClrBtn;
            this.ClrBtn.FillColor = System.Drawing.Color.Transparent;
            this.ClrBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.ClrBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.ForeColor = System.Drawing.Color.White;
            this.ClrBtn.HoveredState.Parent = this.ClrBtn;
            this.ClrBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.ClrBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.ClrBtn.Location = new System.Drawing.Point(101, 346);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.ShadowDecoration.Parent = this.ClrBtn;
            this.ClrBtn.Size = new System.Drawing.Size(66, 39);
            this.ClrBtn.TabIndex = 4;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpenBtn.CheckedState.Parent = this.OpenBtn;
            this.OpenBtn.CustomImages.Parent = this.OpenBtn;
            this.OpenBtn.FillColor = System.Drawing.Color.Transparent;
            this.OpenBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.OpenBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.HoveredState.Parent = this.OpenBtn;
            this.OpenBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.OpenBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.OpenBtn.Location = new System.Drawing.Point(173, 346);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.ShadowDecoration.Parent = this.OpenBtn;
            this.OpenBtn.Size = new System.Drawing.Size(104, 39);
            this.OpenBtn.TabIndex = 5;
            this.OpenBtn.Text = "Open Script";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.Transparent;
            this.SaveBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.SaveBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoveredState.Parent = this.SaveBtn;
            this.SaveBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.SaveBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.SaveBtn.Location = new System.Drawing.Point(283, 346);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(104, 39);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save Script";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExecFileBtn
            // 
            this.ExecFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExecFileBtn.CheckedState.Parent = this.ExecFileBtn;
            this.ExecFileBtn.CustomImages.Parent = this.ExecFileBtn;
            this.ExecFileBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExecFileBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.ExecFileBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecFileBtn.ForeColor = System.Drawing.Color.White;
            this.ExecFileBtn.HoveredState.Parent = this.ExecFileBtn;
            this.ExecFileBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.ExecFileBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.ExecFileBtn.Location = new System.Drawing.Point(393, 346);
            this.ExecFileBtn.Name = "ExecFileBtn";
            this.ExecFileBtn.ShadowDecoration.Parent = this.ExecFileBtn;
            this.ExecFileBtn.Size = new System.Drawing.Size(114, 39);
            this.ExecFileBtn.TabIndex = 7;
            this.ExecFileBtn.Text = "Execute Script";
            this.ExecFileBtn.Click += new System.EventHandler(this.ExecFileBtn_Click);
            // 
            // CornerRadius
            // 
            this.CornerRadius.BorderRadius = 14;
            this.CornerRadius.TargetControl = this;
            // 
            // Editor
            // 
            this.Editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Editor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.Editor.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.Editor.BackBrush = null;
            this.Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Editor.CharHeight = 14;
            this.Editor.CharWidth = 8;
            this.Editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Editor.ForeColor = System.Drawing.Color.White;
            this.Editor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Editor.IsReplaceMode = false;
            this.Editor.LineNumberColor = System.Drawing.Color.Orange;
            this.Editor.Location = new System.Drawing.Point(7, 65);
            this.Editor.Name = "Editor";
            this.Editor.Paddings = new System.Windows.Forms.Padding(0);
            this.Editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Editor.ServiceColors")));
            this.Editor.Size = new System.Drawing.Size(500, 275);
            this.Editor.TabIndex = 8;
            this.Editor.Zoom = 100;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshBtn.CheckedState.Parent = this.RefreshBtn;
            this.RefreshBtn.CustomImages.Parent = this.RefreshBtn;
            this.RefreshBtn.FillColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.RefreshBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.HoveredState.Parent = this.RefreshBtn;
            this.RefreshBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.RefreshBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.RefreshBtn.Location = new System.Drawing.Point(513, 346);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ShadowDecoration.Parent = this.RefreshBtn;
            this.RefreshBtn.Size = new System.Drawing.Size(154, 39);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(674, 393);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.ExecFileBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.ExecBtn);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.TopPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExecutorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire-Sploit | Main Executor";
            this.Load += new System.EventHandler(this.ExecutorForm_Load);
            this.TopPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientPanel TopPnl;
        private Siticone.UI.WinForms.SiticoneGradientButton CloseBtn;
        private Siticone.UI.WinForms.SiticoneGradientButton MiniBtn;
        private System.Windows.Forms.TreeView ScriptBox;
        private Siticone.UI.WinForms.SiticoneDragControl DragCtrl;
        private Siticone.UI.WinForms.SiticoneGradientButton ExecBtn;
        private Siticone.UI.WinForms.SiticoneGradientButton ClrBtn;
        private Siticone.UI.WinForms.SiticoneGradientButton OpenBtn;
        private Siticone.UI.WinForms.SiticoneGradientButton SaveBtn;
        private Siticone.UI.WinForms.SiticoneGradientButton AttachBtn;
        private Siticone.UI.WinForms.SiticoneGradientButton ExecFileBtn;
        private Siticone.UI.WinForms.SiticoneElipse CornerRadius;
        private FastColoredTextBoxNS.FastColoredTextBox Editor;
        private System.Windows.Forms.ImageList TreeImg;
        private Siticone.UI.WinForms.SiticoneGradientButton RefreshBtn;
    }
}