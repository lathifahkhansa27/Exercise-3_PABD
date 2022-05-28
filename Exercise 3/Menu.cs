using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonBnavigasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DataBinding().Show();
        }

        private void buttonDGview_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GridData().Show();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
