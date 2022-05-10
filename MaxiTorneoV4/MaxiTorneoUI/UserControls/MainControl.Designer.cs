namespace MaxiTorneoUI.UserControls
{
    partial class MainControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddBD = new System.Windows.Forms.Button();
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.comboBoxBD = new System.Windows.Forms.ComboBox();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.buttonAddBD, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonComenzar, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.comboBoxBD, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(250, 370);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(300, 60);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // buttonAddBD
            // 
            this.buttonAddBD.Location = new System.Drawing.Point(3, 33);
            this.buttonAddBD.Name = "buttonAddBD";
            this.buttonAddBD.Size = new System.Drawing.Size(144, 24);
            this.buttonAddBD.TabIndex = 0;
            this.buttonAddBD.Text = "Añadir base de datos";
            this.buttonAddBD.UseVisualStyleBackColor = true;
            this.buttonAddBD.Click += new System.EventHandler(this.buttonAddBDClick);
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.Location = new System.Drawing.Point(153, 33);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(144, 24);
            this.buttonComenzar.TabIndex = 1;
            this.buttonComenzar.Text = "Comenzar";
            this.buttonComenzar.UseVisualStyleBackColor = true;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzarClick);
            // 
            // comboBoxBD
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxBD, 2);
            this.comboBoxBD.FormattingEnabled = true;
            this.comboBoxBD.Location = new System.Drawing.Point(3, 3);
            this.comboBoxBD.Name = "comboBoxBD";
            this.comboBoxBD.Size = new System.Drawing.Size(294, 21);
            this.comboBoxBD.TabIndex = 2;
            // 
            // panelImagen
            // 
            this.panelImagen.Location = new System.Drawing.Point(100, 20);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(600, 125);
            this.panelImagen.TabIndex = 2;
            // 
            // panelUsers
            // 
            this.panelUsers.Location = new System.Drawing.Point(125, 160);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(550, 195);
            this.panelUsers.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelImagen);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonAddBD;
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.ComboBox comboBoxBD;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Panel panelUsers;
    }
}
