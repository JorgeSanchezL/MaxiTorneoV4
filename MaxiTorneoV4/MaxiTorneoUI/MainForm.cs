using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxiTorneoUI.UserControls;

namespace MaxiTorneoUI
{
    public partial class MainForm : Form
    {

        private static MainForm instance;

        private MainForm()
        {
            InitializeComponent();
            panelBackground.Controls.Add(new MainControl());
        }

        public static MainForm GetInstance()
        {
            if (instance == null)
            {
                instance = new MainForm();
            }
            return instance;
        }
    }
}
