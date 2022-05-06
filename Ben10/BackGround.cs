using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ben10
{
    public partial class BackGround : Form
    {
        public BackGround()
        {
            InitializeComponent();
        }

        private void BackGround_Load(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.ShowDialog();
            this.Close();
        }
    }
}
