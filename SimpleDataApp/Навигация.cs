using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class Навигация : Form
    {
        public Навигация()
        {
            InitializeComponent();
        }

        private void BtnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }

        /// <summary>
        /// Opens the FillorCancel form as a dialog box. 
        /// </summary>
        private void BtnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        /// <summary>
        /// Closes the application (not just the Navigation form).
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
