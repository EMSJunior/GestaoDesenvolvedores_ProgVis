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
        private WindowCreateTask(Project proj= null, Developer dev = null)
        {
            InitializeComponent();
            if(proj != null && dev != null)
            {
                lstProject.DataSource = new List<Project>{ proj };
                lstDev.DataSource = new List<Developer> { dev };

                lstDev_SelectedIndexChanged(null, null);
            }
        }

        private static WindowCreateTask instance;
        public static WindowCreateTask GetInstance(Project proj = null, Developer dev = null)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowCreateTask(proj, dev);
            }

            return instance;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Allocation aloc = AllocationRepository.GetByProjectAndDev((Project)lstProject.SelectedItem, (Developer)lstDev.SelectedItem);
            Task task = new Task(txtTask.Text);

            AllocationRepository.AddTask(aloc, task);

            MessageBox.Show("Tarefa adicionada!", "Aviso");
            txtTask.Text = "";

            lstTask.DataSource = AllocationRepository.GetTask((Project)lstProject.SelectedItem, (Developer)lstDev.SelectedItem);

        }

        private void btnFindDev_Click(object sender, EventArgs e)
        {

        }

        private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
        {
                lstDev.DataSource = ProjectRepository.GetDevs((Project)lstProject.SelectedItem);
        }

        private void txtProjectOrDev_TextChanged(object sender, EventArgs e)
        {
            lstProject.DataSource = ProjectRepository.FindByPartialName(txtProjectOrDev.Text);
        }

        private void txtDev_TextChanged(object sender, EventArgs e)
        {
            lstDev.DataSource = ProjectRepository.GetDevsPerName((Project)lstProject.SelectedItem, txtDev.Text);
        }

        private void lstDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTask.DataSource = AllocationRepository.GetTask((Project)lstProject.SelectedItem, (Developer)lstDev.SelectedItem);
        }
    }
}
