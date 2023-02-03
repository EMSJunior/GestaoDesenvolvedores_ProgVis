using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GestaoDesenvolvedores
{
    internal partial class WindowMyTasks : Form
    {
        private static Developer _devlog { get; set; }
        private WindowMyTasks(Developer devlog)
        {
            InitializeComponent();

            _devlog = devlog;
            btnRefresh_Click(null, null);

        }
        private static WindowMyTasks instance;
        public static WindowMyTasks GetInstance(Developer devlog)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowMyTasks(devlog);
            }
            return instance;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<String> tasks = new List<String>();
            List<Allocation> alocs = AllocationRepository.FindPersonalsProjects(_devlog);

            foreach (var aloc in alocs)
            {
                foreach (Task task in aloc.Tasks)
                {
                    tasks.Add($"{aloc.Project.Name} -> {task.Description}");
                }
            }
            lstTasks.DataSource = tasks;
        }
    }
}
