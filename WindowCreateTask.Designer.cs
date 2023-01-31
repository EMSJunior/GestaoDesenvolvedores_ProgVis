namespace GestaoDesenvolvedores
{
    partial class WindowCreateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowCreateTask));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTasksList = new System.Windows.Forms.DataGridView();
            this.dgvAllocList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblAlloc = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindAlloc = new System.Windows.Forms.Button();
            this.txtProjectOrDev = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTasksList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAllocList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAlloc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTasks, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 454);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvTasksList
            // 
            this.dgvTasksList.AllowUserToAddRows = false;
            this.dgvTasksList.AllowUserToDeleteRows = false;
            this.dgvTasksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasksList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTasksList.Location = new System.Drawing.Point(430, 103);
            this.dgvTasksList.MultiSelect = false;
            this.dgvTasksList.Name = "dgvTasksList";
            this.dgvTasksList.ReadOnly = true;
            this.dgvTasksList.RowHeadersVisible = false;
            this.dgvTasksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasksList.ShowCellErrors = false;
            this.dgvTasksList.ShowCellToolTips = false;
            this.dgvTasksList.ShowEditingIcon = false;
            this.dgvTasksList.ShowRowErrors = false;
            this.dgvTasksList.Size = new System.Drawing.Size(421, 348);
            this.dgvTasksList.TabIndex = 6;
            // 
            // dgvAllocList
            // 
            this.dgvAllocList.AllowUserToAddRows = false;
            this.dgvAllocList.AllowUserToDeleteRows = false;
            this.dgvAllocList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllocList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllocList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllocList.Location = new System.Drawing.Point(3, 103);
            this.dgvAllocList.MultiSelect = false;
            this.dgvAllocList.Name = "dgvAllocList";
            this.dgvAllocList.ReadOnly = true;
            this.dgvAllocList.RowHeadersVisible = false;
            this.dgvAllocList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllocList.ShowCellErrors = false;
            this.dgvAllocList.ShowCellToolTips = false;
            this.dgvAllocList.ShowEditingIcon = false;
            this.dgvAllocList.ShowRowErrors = false;
            this.dgvAllocList.Size = new System.Drawing.Size(421, 348);
            this.dgvAllocList.TabIndex = 5;
            this.dgvAllocList.SelectionChanged += new System.EventHandler(this.dgvAllocList_SelectionChanged);
            this.dgvAllocList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAllocList_MouseClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.92638F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.07362F));
            this.tableLayoutPanel3.Controls.Add(this.txtTask, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddTask, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(430, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(421, 44);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.Location = new System.Drawing.Point(3, 9);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(305, 26);
            this.txtTask.TabIndex = 13;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTask.AutoSize = true;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.Location = new System.Drawing.Point(330, 9);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(72, 25);
            this.btnAddTask.TabIndex = 12;
            this.btnAddTask.Text = "Adicionar";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblAlloc
            // 
            this.lblAlloc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlloc.AutoSize = true;
            this.lblAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlloc.ForeColor = System.Drawing.Color.Aqua;
            this.lblAlloc.Location = new System.Drawing.Point(3, 0);
            this.lblAlloc.Name = "lblAlloc";
            this.lblAlloc.Size = new System.Drawing.Size(421, 50);
            this.lblAlloc.TabIndex = 1;
            this.lblAlloc.Text = "Alocação:";
            this.lblAlloc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTasks
            // 
            this.lblTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.ForeColor = System.Drawing.Color.Aqua;
            this.lblTasks.Location = new System.Drawing.Point(430, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(421, 50);
            this.lblTasks.TabIndex = 2;
            this.lblTasks.Text = "Tarefas:";
            this.lblTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.66859F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.33141F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFindAlloc, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtProjectOrDev, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 44);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "Projeto/Dev:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindAlloc
            // 
            this.btnFindAlloc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindAlloc.AutoSize = true;
            this.btnFindAlloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnFindAlloc.Location = new System.Drawing.Point(355, 9);
            this.btnFindAlloc.Name = "btnFindAlloc";
            this.btnFindAlloc.Size = new System.Drawing.Size(58, 25);
            this.btnFindAlloc.TabIndex = 12;
            this.btnFindAlloc.Text = "Buscar";
            this.btnFindAlloc.UseVisualStyleBackColor = true;
            this.btnFindAlloc.Click += new System.EventHandler(this.btnFindAlloc_Click);
            // 
            // txtProjectOrDev
            // 
            this.txtProjectOrDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectOrDev.Location = new System.Drawing.Point(158, 9);
            this.txtProjectOrDev.Name = "txtProjectOrDev";
            this.txtProjectOrDev.Size = new System.Drawing.Size(186, 26);
            this.txtProjectOrDev.TabIndex = 13;
            // 
            // WindowCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(869, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WindowCreateTask";
            this.Text = "WindowCreateTask";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvTasksList;
        private System.Windows.Forms.DataGridView dgvAllocList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblAlloc;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindAlloc;
        private System.Windows.Forms.TextBox txtProjectOrDev;
    }
}