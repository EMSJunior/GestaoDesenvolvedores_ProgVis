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
    internal partial class WindowHome : Form
    {
        public Developer devLog;
        private WindowHome(Developer dev)
        {
            InitializeComponent();
            this.devLog = dev;
            this.IsMdiContainer= true;
            this.Text = this.Text + " - Wellcome " + devLog.Name + "!";
            if (devLog.Credential.IsAdmin)
            {
                tmiProjectNew.Visible= true;
                tsmDev.Visible= true;
                tmiTaskNew.Visible= true;
                tmiAllocationCreate.Visible= true;
                
            }
        }
        private static WindowHome instance;
        public static WindowHome GetInstance(Developer devLog)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowHome(devLog);
            }

            return instance;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestaoDesenvolvedores.WindowMenu.GetInstance().Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void tmiProgramAbout_Click(object sender, EventArgs e)
        {
            var j = WindowAbout.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiProgramLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmiProgramExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmiDevManagement_Click(object sender, EventArgs e)
        {
            var j = WindowDevsManagement.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiProjectNew_Click(object sender, EventArgs e)
        {
            var j = WindowCreateProject.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiProjectList_Click(object sender, EventArgs e)
        {
            var j = WindowProjectList.GetInstance(devLog);
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiDevAlocatte_Click(object sender, EventArgs e)
        {
            var j = WindowAllocation.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
            
        }

        private void tmiAllocationCreate_Click(object sender, EventArgs e)
        {
            var j = WindowAllocation.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiAllocationList_Click(object sender, EventArgs e)
        {
            

        }

        private void tmiMyAlloc_Click(object sender, EventArgs e)
        {
            var j = WindowAllocationsList.GetInstance(devLog);
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiTaskList_Click(object sender, EventArgs e)
        {
            var j = WindowMyTasks.GetInstance(devLog);
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiTaskNew_Click(object sender, EventArgs e)
        {
            var j = WindowCreateTask.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }

        private void tmiCadastroDev_Click(object sender, EventArgs e)
        {
            var j = WindowSignUp.GetInstance();
            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }
            else
            {
                j.WindowState = FormWindowState.Normal;
            }
            j.Activate();
        }
    }
}
