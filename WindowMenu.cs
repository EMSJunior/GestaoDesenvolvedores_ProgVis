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
    internal partial class WindowMenu : Form
    {
        public static List<Level> levels = new List<Level>();
        private WindowMenu()
        {
            levels = LevelsRepository.GetLevels(); 
            InitializeComponent();
            this.Show();
        }
        private static WindowMenu instance;
        public static WindowMenu GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowMenu();
            }

            return instance;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            WindowLogIn.GetInstance().Show();
            this.Hide();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            
            WindowSignUp.GetInstance(levels).Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
