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
            InitializeComponent();
            devLog = dev;
            dgvProjects.DataSource = AllocationRepository.FindPersonalsProjects(devLog);

            // Códigos para remover colunas que não pertencem à janela.
            dgvProjects.AutoGenerateColumns = false;
            dgvProjects.Columns.Remove("Id");
            dgvProjects.Columns.Remove("StartDate");
            dgvProjects.Columns.Remove("FinishDate");
            dgvProjects.Columns.Remove("AtuacionHoursPerWeek");
            dgvProjects.Columns.Remove("Remuneration");
            dgvProjects.Columns.Remove("Developer");

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

        private void lblYourProject_Click(object sender, EventArgs e)
        {

        }
    }
}
