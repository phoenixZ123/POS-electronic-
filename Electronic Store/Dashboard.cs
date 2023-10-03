using Electronic_Store.ButtonAction;
using Electronic_Store.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Electronic_Store
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            InitializeNavControl();
            Initializebtn();
        }
        Navbar navbar;
        NavbarButtons navbtns;

        //change the color if u want
        Color btndefaultColor = Color.FromKnownColor(KnownColor.DarkGray);
        //if select
        Color btnselectedColor = Color.FromKnownColor(KnownColor.Gray);

        private void InitializeNavControl()
        {
            List<UserControl> list = new List<UserControl>()
            {new AddProducts(),new SoldProducts()};

            navbar = new Navbar(list, panel2);
            navbar.Display(0);//as default
        }
        private void Initializebtn()
        {
            List<Button> button = new List<Button>()
            {button1,button2};

            navbtns = new NavbarButtons(button, btndefaultColor, btnselectedColor);
            navbtns.Highlight(button1);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            navbar.Display(0);
            navbtns.Highlight(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navbar.Display(1);
            navbtns.Highlight(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //navbar.Display(2);
            //navbtns.Highlight(button3);

        }
        public string Username { get; set; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbluser.Text = Username;
                     
        }

        private void btnItems_Click(object sender, EventArgs e)
        {

        }

        private void btnSoldItems_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           
        }
    }
}
