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
    internal partial class WindowAllocationsList : Form
    {
        private WindowAllocationsList(Developer dev)
        {
            InitializeComponent();

            dgvAllocation.DataSource = AllocationRepository.FindPersonalsProjects(dev);


        }
        private static WindowAllocationsList instance;
        public static WindowAllocationsList GetInstance(Developer dev)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowAllocationsList(dev);
            }

            return instance;
        }
    }
}
