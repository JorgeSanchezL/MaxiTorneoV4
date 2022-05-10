namespace MaxiTorneoUI.UserControls
{
    partial class UserManagement
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.serviceExceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceExceptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.personBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(424, 195);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // serviceExceptionBindingSource
            // 
            this.serviceExceptionBindingSource.DataSource = typeof(MaxiTorneo.Services.ServiceException);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MaxiTorneo.Entities.Person);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(430, 0);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(120, 30);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Añadir jugador";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUserClick);
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Location = new System.Drawing.Point(430, 36);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(120, 30);
            this.buttonRemoveUser.TabIndex = 2;
            this.buttonRemoveUser.Text = "Eliminar jugador";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUserClick);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemoveUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(550, 195);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceExceptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource serviceExceptionBindingSource;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonRemoveUser;
    }
}
