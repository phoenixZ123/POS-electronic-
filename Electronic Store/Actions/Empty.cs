using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Store.Actions
{
    public partial class Empty : Form
    {
        public Empty()
        {
            InitializeComponent();
        }
        public string type { get; set; }
        public string model { get; set; }
        private void Empty_Load(object sender, EventArgs e)
        {
            lblmodel.Text = model;
            lblEmptyType.Text = type;
        }
    }
}
