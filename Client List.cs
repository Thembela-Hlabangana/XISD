using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TABA_FMIS
{
    public partial class Client_List : Form
    {
        public Client_List()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Driver_Menu dm = new Driver_Menu();
           dm.Show();
            this.Hide();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            Driver_Menu dr = new Driver_Menu();
            dr.Show();
            this.Hide();
        }
    }
}
