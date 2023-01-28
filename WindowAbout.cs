using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDesenvolvedores
{
    public partial class WindowAbout : Form
    {
        private WindowAbout()
        {
            InitializeComponent();
        }
        private static WindowAbout instance;
        public static WindowAbout GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowAbout();
            }

            return instance;
        }
    }
}
