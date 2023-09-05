using Electronic_Store.ButtonAction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            {  new AddProducts(),new SoldProducts(),new LastProducts()};

            navbar = new Navbar(list, panel1);
            navbar.Display(0);//as default
        }
        private void Initializebtn()
        {
            List<Button> button = new List<Button>()
            { btnItems,btnSoldItems,btnLast};

            navbtns = new NavbarButtons(button, btndefaultColor, btnselectedColor);
            navbtns.Highlight(btnItems);


        }

        public string Username { get; set; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbluser.Text = Username;
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            navbar.Display(0);
            navbtns.Highlight(btnItems);
        }

        private void btnSoldItems_Click(object sender, EventArgs e)
        {
            navbar.Display(0);
            navbtns.Highlight(btnSoldItems);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            navbar.Display(0);
            navbtns.Highlight(btnLast);
        }
    }
}
