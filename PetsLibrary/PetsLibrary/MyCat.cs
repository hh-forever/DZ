using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsLibrary
{
    public class MyCat : Cat
    {
        public MyCat()
        {
            Name = "Bagira";
        }
        public override string Meow()
        {
            MessageBox.Show("Мяу!");
            return Name;
        }

    }

}
