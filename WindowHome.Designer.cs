namespace GestaoDesenvolvedores
{
    partial class WindowHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiProgramAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiProgramLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiProgramExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiProjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiProjectNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiTaskNew = new System.Windows.Forms.ToolStripMenuItem();
            this.alocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiAllocationCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiAllocationList = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiMyAlloc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDev = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDevAlocatte = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDevManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProgram,
            this.tsmProject,
            this.tsmTask,
            this.alocaçõesToolStripMenuItem,
            this.tsmDev});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmProgram
            // 
            this.tsmProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiProgramAbout,
            this.tmiProgramLogOut,
            this.tmiProgramExit});
            this.tsmProgram.Name = "tsmProgram";
            this.tsmProgram.Size = new System.Drawing.Size(71, 20);
            this.tsmProgram.Text = "Programa";
            // 
            // tmiProgramAbout
            // 
            this.tmiProgramAbout.Name = "tmiProgramAbout";
            this.tmiProgramAbout.Size = new System.Drawing.Size(117, 22);
            this.tmiProgramAbout.Text = "Sobre";
            this.tmiProgramAbout.Click += new System.EventHandler(this.tmiProgramAbout_Click);
            // 
            // tmiProgramLogOut
            // 
            this.tmiProgramLogOut.Name = "tmiProgramLogOut";
            this.tmiProgramLogOut.Size = new System.Drawing.Size(117, 22);
            this.tmiProgramLogOut.Text = "Log Out";
            this.tmiProgramLogOut.Click += new System.EventHandler(this.tmiProgramLogOut_Click);
            // 
            // tmiProgramExit
            // 
            this.tmiProgramExit.Name = "tmiProgramExit";
            this.tmiProgramExit.Size = new System.Drawing.Size(117, 22);
            this.tmiProgramExit.Text = "Sair";
            this.tmiProgramExit.Click += new System.EventHandler(this.tmiProgramExit_Click);
            // 
            // tsmProject
            // 
            this.tsmProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiProjectList,
            this.tmiProjectNew});
            this.tsmProject.Name = "tsmProject";
            this.tsmProject.Size = new System.Drawing.Size(62, 20);
            this.tsmProject.Text = "Projetos";
            // 
            // tmiProjectList
            // 
            this.tmiProjectList.Name = "tmiProjectList";
            this.tmiProjectList.Size = new System.Drawing.Size(140, 22);
            this.tmiProjectList.Text = "Lista";
            this.tmiProjectList.Click += new System.EventHandler(this.tmiProjectList_Click);
            // 
            // tmiProjectNew
            // 
            this.tmiProjectNew.Name = "tmiProjectNew";
            this.tmiProjectNew.Size = new System.Drawing.Size(140, 22);
            this.tmiProjectNew.Text = "Criar Projeto";
            this.tmiProjectNew.Visible = false;
            this.tmiProjectNew.Click += new System.EventHandler(this.tmiProjectNew_Click);
            // 
            // tsmTask
            // 
            this.tsmTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiTaskList,
            this.tmiTaskNew});
            this.tsmTask.Name = "tsmTask";
            this.tsmTask.Size = new System.Drawing.Size(55, 20);
            this.tsmTask.Text = "Tarefas";
            // 
            // tmiTaskList
            // 
            this.tmiTaskList.Name = "tmiTaskList";
            this.tmiTaskList.Size = new System.Drawing.Size(99, 22);
            this.tmiTaskList.Text = "Lista";
            // 
            // tmiTaskNew
            // 
            this.tmiTaskNew.Name = "tmiTaskNew";
            this.tmiTaskNew.Size = new System.Drawing.Size(99, 22);
            this.tmiTaskNew.Text = "Criar";
            this.tmiTaskNew.Visible = false;
            // 
            // alocaçõesToolStripMenuItem
            // 
            this.alocaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiAllocationCreate,
            this.tmiAllocationList,
            this.tmiMyAlloc});
            this.alocaçõesToolStripMenuItem.Name = "alocaçõesToolStripMenuItem";
            this.alocaçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.alocaçõesToolStripMenuItem.Text = "Alocações";
            // 
            // tmiAllocationCreate
            // 
            this.tmiAllocationCreate.Name = "tmiAllocationCreate";
            this.tmiAllocationCreate.Size = new System.Drawing.Size(180, 22);
            this.tmiAllocationCreate.Text = "Criar alocação";
            this.tmiAllocationCreate.Visible = false;
            this.tmiAllocationCreate.Click += new System.EventHandler(this.tmiAllocationCreate_Click);
            // 
            // tmiAllocationList
            // 
            this.tmiAllocationList.Name = "tmiAllocationList";
            this.tmiAllocationList.Size = new System.Drawing.Size(180, 22);
            this.tmiAllocationList.Text = "Lista de alocações";
            this.tmiAllocationList.Visible = false;
            this.tmiAllocationList.Click += new System.EventHandler(this.tmiAllocationList_Click);
            // 
            // tmiMyAlloc
            // 
            this.tmiMyAlloc.Name = "tmiMyAlloc";
            this.tmiMyAlloc.Size = new System.Drawing.Size(180, 22);
            this.tmiMyAlloc.Text = "Minhas alocações";
            this.tmiMyAlloc.Click += new System.EventHandler(this.tmiMyAlloc_Click);
            // 
            // tsmDev
            // 
            this.tsmDev.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiDevAlocatte,
            this.tmiDevManagement});
            this.tsmDev.Name = "tsmDev";
            this.tsmDev.Size = new System.Drawing.Size(97, 20);
            this.tsmDev.Text = "Desenvolvedor";
            this.tsmDev.Visible = false;
            // 
            // tmiDevAlocatte
            // 
            this.tmiDevAlocatte.Name = "tmiDevAlocatte";
            this.tmiDevAlocatte.Size = new System.Drawing.Size(124, 22);
            this.tmiDevAlocatte.Text = "Alocar";
            this.tmiDevAlocatte.Click += new System.EventHandler(this.tmiDevAlocatte_Click);
            // 
            // tmiDevManagement
            // 
            this.tmiDevManagement.Name = "tmiDevManagement";
            this.tmiDevManagement.Size = new System.Drawing.Size(124, 22);
            this.tmiDevManagement.Text = "Gerenciar";
            this.tmiDevManagement.Click += new System.EventHandler(this.tmiDevManagement_Click);
            // 
            // WindowHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1216, 655);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "WindowHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmProgram;
        private System.Windows.Forms.ToolStripMenuItem tmiProgramAbout;
        private System.Windows.Forms.ToolStripMenuItem tmiProgramLogOut;
        private System.Windows.Forms.ToolStripMenuItem tmiProgramExit;
        private System.Windows.Forms.ToolStripMenuItem tsmProject;
        private System.Windows.Forms.ToolStripMenuItem tmiProjectList;
        private System.Windows.Forms.ToolStripMenuItem tmiProjectNew;
        private System.Windows.Forms.ToolStripMenuItem tsmTask;
        private System.Windows.Forms.ToolStripMenuItem tmiTaskList;
        private System.Windows.Forms.ToolStripMenuItem tmiTaskNew;
        private System.Windows.Forms.ToolStripMenuItem tsmDev;
        private System.Windows.Forms.ToolStripMenuItem tmiDevAlocatte;
        private System.Windows.Forms.ToolStripMenuItem tmiDevManagement;
        private System.Windows.Forms.ToolStripMenuItem alocaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiAllocationCreate;
        private System.Windows.Forms.ToolStripMenuItem tmiAllocationList;
        private System.Windows.Forms.ToolStripMenuItem tmiMyAlloc;
    }
}