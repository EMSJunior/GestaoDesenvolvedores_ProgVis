using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDesenvolvedores
{
    internal partial class WindowCreateTask : Form
    {
        private WindowCreateTask(Allocation aloc = null)
        {
            InitializeComponent();
            if(aloc != null)
            {
                List<Allocation> list = new List<Allocation>
                {
                    AllocationRepository.GetAllocationWTasksById(aloc.Id)
                };
                dgvAllocList.DataSource = list;

            }
        }

        private static WindowCreateTask instance;
        public static WindowCreateTask GetInstance(Allocation aloc = null)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowCreateTask(aloc);
            }

            return instance;
        }

        private void btnFindAlloc_Click(object sender, EventArgs e)
        {
            dgvAllocList.DataSource = AllocationRepository.GetAllocationPerDeveloperOrProjectsWTask(txtProjectOrDev.Text);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task task = new Task(txtTask.Text);

            AllocationRepository.AddTask(dgvAllocList.SelectedRows[0].DataBoundItem as Allocation, task);

            Allocation selectedAloc = dgvAllocList.SelectedRows[0].DataBoundItem as Allocation;

            dgvTasksList.DataSource = AllocationRepository.GetAllocationWTasksById(selectedAloc.Id).Tasks;
        }

        private void dgvAllocList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvAllocList_MouseClick(object sender, MouseEventArgs e)
        {
            Allocation selectedAloc = dgvAllocList.SelectedRows[0].DataBoundItem as Allocation;

            dgvTasksList.DataSource = AllocationRepository.GetAllocationWTasksById(selectedAloc.Id).Tasks;
        }
    }
}
