using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZFORGE_HOMEPAGE
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel quizPanel = new Panel();
            quizPanel.BorderStyle = BorderStyle.FixedSingle;
            quizPanel.Width = this.pnlmain.Width;
            quizPanel.Name = CreateQuiz.generateQuestionName(this.pnlmain).ToString();
            //quizPanel.Dock = DockStyle.Bottom;
            quizPanel.Height = 250;

            if (quizPanel.Name.Replace("question", "") == "1")
            {
                quizPanel.Location = new Point(0, 0);
            }
            else
            {
                int yAxis = (Convert.ToInt32(quizPanel.Name.Replace("question", "")) - 1) * quizPanel.Height;
                quizPanel.Location = new Point(0, yAxis + 1);
            }

            this.pnlmain.Controls.Add(quizPanel);


            Button cmdremove = new Button();
            cmdremove.FlatStyle = FlatStyle.Flat;
            cmdremove.Size = new Size(24, 24);
            cmdremove.BackColor = Color.Red;
            cmdremove.ForeColor = Color.White;
            cmdremove.Text = "x";
            cmdremove.Tag = quizPanel.Name;
            cmdremove.Click += new System.EventHandler(CreateQuiz.removeQuestionPanel);
            quizPanel.Controls.Add(cmdremove);

            TextBox txtquestion = new TextBox();
            txtquestion.Name = "txt" + quizPanel.Name;

            txtquestion.Text = txtquestion.Name; // "";
            txtquestion.Width = quizPanel.Width;
            txtquestion.Location = new Point(cmdremove.Width, 5);
            



            quizPanel.Controls.Add(txtquestion);

            
        }

        private void Txtquestion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {

        }

        private void cmdexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmdminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int countTextBox = 0;
            foreach (Panel pnl in this.pnlmain.Controls)
            {
                countTextBox++;
            }
            foreach (Panel pnl in this.pnlmain.Controls)
            {
                foreach (Control txt in pnl.Controls)
                {
                    
                    txt.Text = "txtquestion" + (countTextBox).ToString();
                }
                countTextBox--;
            }
            
        }
    }
}
