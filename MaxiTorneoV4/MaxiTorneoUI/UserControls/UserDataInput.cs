using MaxiTorneo.Entities;
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
    public partial class UserDataInput : UserControl
    {
        UserManagement UserManagement;

        public UserDataInput(UserManagement userManagement)
        {
            InitializeComponent();
            UserManagement = userManagement;
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            UserManagement.AddUserToGrid(new Person(textBoxName.Text, textBoxTeam.Text));
        }
    }
}
