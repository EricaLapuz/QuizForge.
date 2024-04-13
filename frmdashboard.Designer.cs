namespace QUIZFORGE_HOMEPAGE
{
    partial class frmdashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlcontrolbox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.cmdminimize = new System.Windows.Forms.Button();
            this.cmdexit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlcontrolbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlcontrolbox
            // 
            this.pnlcontrolbox.Controls.Add(this.cmdexit);
            this.pnlcontrolbox.Controls.Add(this.cmdminimize);
            this.pnlcontrolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrolbox.Location = new System.Drawing.Point(0, 0);
            this.pnlcontrolbox.Name = "pnlcontrolbox";
            this.pnlcontrolbox.Size = new System.Drawing.Size(800, 32);
            this.pnlcontrolbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 1;
            // 
            // pnlmain
            // 
            this.pnlmain.AutoScroll = true;
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 64);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(800, 386);
            this.pnlmain.TabIndex = 2;
            // 
            // cmdminimize
            // 
            this.cmdminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdminimize.BackColor = System.Drawing.Color.Yellow;
            this.cmdminimize.FlatAppearance.BorderSize = 0;
            this.cmdminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdminimize.ForeColor = System.Drawing.Color.White;
            this.cmdminimize.Location = new System.Drawing.Point(707, 3);
            this.cmdminimize.Name = "cmdminimize";
            this.cmdminimize.Size = new System.Drawing.Size(42, 23);
            this.cmdminimize.TabIndex = 0;
            this.cmdminimize.Text = "-";
            this.cmdminimize.UseVisualStyleBackColor = false;
            this.cmdminimize.Click += new System.EventHandler(this.cmdminimize_Click);
            // 
            // cmdexit
            // 
            this.cmdexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdexit.BackColor = System.Drawing.Color.Red;
            this.cmdexit.FlatAppearance.BorderSize = 0;
            this.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexit.ForeColor = System.Drawing.Color.White;
            this.cmdexit.Location = new System.Drawing.Point(755, 3);
            this.cmdexit.Name = "cmdexit";
            this.cmdexit.Size = new System.Drawing.Size(42, 23);
            this.cmdexit.TabIndex = 1;
            this.cmdexit.Text = "x";
            this.cmdexit.UseVisualStyleBackColor = false;
            this.cmdexit.Click += new System.EventHandler(this.cmdexit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlcontrolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdashboard";
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.frmdashboard_Load);
            this.pnlcontrolbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel pnlcontrolbox;
        private System.Windows.Forms.Button cmdminimize;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Button cmdexit;
        private System.Windows.Forms.Button button2;
    }
}