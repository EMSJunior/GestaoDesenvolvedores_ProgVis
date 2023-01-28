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
    internal partial class WindowProjectList : Form
    {
        public Developer devLog { get; set; }
        private WindowProjectList(Developer dev)
        {
            devLog = dev;
            InitializeComponent();
            dgvProjects.DataSource = ProjectRepository.FindAll();
        }
        private static WindowProjectList instance;
        public static WindowProjectList GetInstance(Developer devLog)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowProjectList(devLog);
            }

            return instance;
        }
    }
}
