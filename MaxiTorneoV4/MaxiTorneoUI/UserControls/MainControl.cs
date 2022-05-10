using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiTorneoUI.UserControls
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
            panelUsers.Controls.Add(new UserManagement());
        }

        private void buttonAddBDClick(object sender, EventArgs e)
        {

        }

        private void buttonComenzarClick(object sender, EventArgs e)
        {

        }
    }
}
