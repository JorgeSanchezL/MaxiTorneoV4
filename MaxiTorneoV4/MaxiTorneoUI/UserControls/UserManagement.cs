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
    public partial class UserManagement : UserControl
    {
        Form inputForm = new Form();
        public UserManagement()
        {
            InitializeComponent();
        }

        private void buttonAddUserClick(object sender, EventArgs e)
        {
            UserDataInput input = new UserDataInput(this);
            inputForm.Controls.Clear();
            inputForm.Controls.Add(input);
            inputForm.Size = new Size(input.Width + 16, input.Height + 39);
            inputForm.ShowDialog();
        }

        private void buttonRemoveUserClick(object sender, EventArgs e)
        {

        }

        public void AddUserToGrid(Person person)
        {
            personBindingSource.Add(person);
            inputForm.Close();
        }
    }
}
