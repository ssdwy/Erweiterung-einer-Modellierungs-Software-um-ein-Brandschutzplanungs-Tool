using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IIB1_UE1_Gruppe12_
{
    class Program
    {
        static void Main()
        {
            Form MainGui = new MAINGUI();
            MainGui.ShowDialog();

            List<Raum> Raumliste = new List<Raum>();
        }
    }
}
