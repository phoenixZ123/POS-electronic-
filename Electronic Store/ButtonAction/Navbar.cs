using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Store.ButtonAction
{
    internal class Navbar
    {
        List<UserControl> listitems = new List<UserControl>();
        Panel panel;

        public Navbar(List<UserControl> list, Panel panel)
        {
            this.listitems = list;
            this.panel = panel;
            AddUserControl();
        }
        private void AddUserControl()
        {
            for (int i = 0; i < listitems.Count(); i++)
            {
                listitems[i].Dock = DockStyle.Fill;
                panel.Controls.Add(listitems[i]);
            }
        }
        public void Display(int index)
        {
            if (index < listitems.Count())
            {
                listitems[index].BringToFront();
            }
        }


    }
}
