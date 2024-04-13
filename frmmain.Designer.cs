namespace QUIZFORGE_HOMEPAGE
{
    partial class frmmain
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
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.cmdmenu = new System.Windows.Forms.Button();
            this.tp = new System.Windows.Forms.ToolTip(this.components);
            this.pnlsidebutton = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlsidebar.SuspendLayout();
            this.pnlsidebutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.BackColor = System.Drawing.Color.White;
            this.pnlsidebar.Controls.Add(this.pnlsidebutton);
            this.pnlsidebar.Controls.Add(this.cmdmenu);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(190, 450);
            this.pnlsidebar.TabIndex = 0;
            // 
            // cmdmenu
            // 
            this.cmdmenu.Location = new System.Drawing.Point(141, 12);
            this.cmdmenu.Name = "cmdmenu";
            this.cmdmenu.Size = new System.Drawing.Size(38, 34);
            this.cmdmenu.TabIndex = 2;
            this.tp.SetToolTip(this.cmdmenu, "MENU");
            this.cmdmenu.UseVisualStyleBackColor = true;
            this.cmdmenu.Click += new System.EventHandler(this.cmdmenu_Click);
            // 
            // tp
            // 
            this.tp.ToolTipTitle = "MENU";
            // 
            // pnlsidebutton
            // 
            this.pnlsidebutton.Controls.Add(this.button1);
            this.pnlsidebutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlsidebutton.Location = new System.Drawing.Point(0, 52);
            this.pnlsidebutton.Name = "pnlsidebutton";
            this.pnlsidebutton.Size = new System.Drawing.Size(190, 398);
            this.pnlsidebutton.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Image = global::QUIZFORGE_HOMEPAGE.Properties.Resources.icons8_info_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlsidebar);
            this.IsMdiContainer = true;
            this.Name = "frmmain";
            this.Text = "frmmain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.pnlsidebar.ResumeLayout(false);
            this.pnlsidebutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlsidebar;
        public System.Windows.Forms.ToolTip tp;
        public System.Windows.Forms.Button cmdmenu;
        public System.Windows.Forms.Panel pnlsidebutton;
        public System.Windows.Forms.Button button1;
    }
}