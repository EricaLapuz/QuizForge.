using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZFORGE_HOMEPAGE
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void cmdmenu_Click(object sender, EventArgs e)
        {
            SidebarFunctions.clickMenu();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            MainLoad.frmmain_Load();
        }
    }
}
