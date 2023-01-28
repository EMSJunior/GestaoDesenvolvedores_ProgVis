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
    internal partial class WindowAllocation : Form
    {
        private WindowAllocation()
        {
            InitializeComponent();

            dgvDevsList.DataSource = DeveloperRepository.FindAllWCredential();
            dgvProjectsList.DataSource = ProjectRepository.FindAll();

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
           
        }

        private static WindowAllocation instance;
        public static WindowAllocation GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowAllocation();
            }

            return instance;
        }

        private void txtLogo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFindProject_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProjectsList.DataSource = ProjectRepository.FindByPartialName(txtFindProject.Text);
            }
            catch 
            {
                throw;
            }
        }

        private void btnFindDev_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDevsList.DataSource = DeveloperRepository.FindByPartialNameWCredential(txtFindDev.Text);
            }
            catch
            {
                throw;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvProjectsList.SelectedRows.Count != 1) 
            {
                MessageBox.Show("Por favor selecione um projeto.", "Erro");
                return;
            }

            if (dgvDevsList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor selecione um desenvolvedor.", "Erro");
                return;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Data de início pós data final.", "Erro");
                return;
            }

            if (nudSemanalHours.Value <= 0)
            {
                MessageBox.Show("Horas semanais têm que ser maior que 0.", "Erro");
                return;
            }

            try
            {
                Convert.ToByte(nudSemanalHours.Value);
            }
            catch 
            {
                MessageBox.Show("Horas Inválidas.", "Erro");
                return;
            }

            try
            {
                Convert.ToDecimal(nudSemanalHours.Value);
            }
            catch
            {
                MessageBox.Show("Valor de remuneração inválida", "Erro");
                return;
            }

            MessageBox.Show((dgvProjectsList.SelectedRows[0].DataBoundItem as Project).ToString());
            Allocation aloc = new Allocation
                (
                dtpStartDate.Value.Date,
                dtpEndDate.Value.Date,
                Convert.ToByte(nudSemanalHours.Value),
                Convert.ToDecimal(txtRemuneration.Text),
                (dgvProjectsList.SelectedRows[0].DataBoundItem as Project),
                (dgvDevsList.SelectedRows[0].DataBoundItem as Developer)
                );
            AllocationRepository.Save(aloc);

            MessageBox.Show("Alocação adiocionada!", "Aviso");


        }
    }
}
