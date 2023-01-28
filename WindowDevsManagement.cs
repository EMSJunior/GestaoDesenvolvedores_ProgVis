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
    internal partial class WindowDevsManagement : Form
    {
        private WindowDevsManagement()
        {
            InitializeComponent();
            dgvDevsList.DataSource = DeveloperRepository.FindAllWCredential();
            cbxLevel.DataSource = LevelsRepository.GetLevels();

        }
        private static WindowDevsManagement instance;
        public static WindowDevsManagement GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowDevsManagement();
            }

            return instance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja modificar o desenvolvedor '" + lblDevName.Text+"' ?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Developer selectedDev = DeveloperRepository.FindByIdWCredential((dgvDevsList.SelectedRows[0].DataBoundItem as Developer).Id);

                selectedDev.Credential.IsActive = rbtActiveYes.Checked;
                selectedDev.Credential.IsAdmin = rbtAdminYes.Checked;
                //selectedDev.Level = LevelsRepository.GetLevel((Levels)cbxLevel.SelectedItem);

                DeveloperRepository.Save(selectedDev);
            }
            else if (dialogResult == DialogResult.No)
            {
                UpdateDev();
            }
        }
        private void UpdateDev()
        {
            try
            {
                Developer selectedDev = DeveloperRepository.FindByIdWCredential((dgvDevsList.SelectedRows[0].DataBoundItem as Developer).Id);

                lblDevName.Text = selectedDev.Name;
                if (selectedDev.Credential.IsActive)
                {
                    rbtActiveYes.Checked = true;
                }
                else
                {
                    rbtActiveNo.Checked = true;
                }
                if (selectedDev.Credential.IsAdmin)
                {
                    rbtAdminYes.Checked = true;
                }
                else
                {
                    rbtAdminNo.Checked = true;
                }
                cbxLevel.SelectedIndex = selectedDev.Level.Id - 1;



            }
            catch
            {
                throw;
            }
        }
        private void dgvDevsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDev();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvDevsList.DataSource = DeveloperRepository.FindByPartialName(txtFind.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
