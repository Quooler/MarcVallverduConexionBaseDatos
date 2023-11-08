namespace MarcVallverduConexionBaseDatos
{
    partial class FormMenuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butAbrirConexion = new System.Windows.Forms.Button();
            this.pgbConnection = new System.Windows.Forms.ProgressBar();
            this.labConexion = new System.Windows.Forms.Label();
            this.butCloseConnection = new System.Windows.Forms.Button();
            this.butCloseApp = new System.Windows.Forms.Button();
            this.butNewJob = new System.Windows.Forms.Button();
            this.ltbListaJobs = new System.Windows.Forms.ListBox();
            this.labJobsList = new System.Windows.Forms.Label();
            this.labEmployeesList = new System.Windows.Forms.Label();
            this.butNewEmployee = new System.Windows.Forms.Button();
            this.cbbCiudad = new System.Windows.Forms.ComboBox();
            this.butFiltrarEmployees = new System.Windows.Forms.Button();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.ltbListaEmployees = new System.Windows.Forms.ListBox();
            this.labCiudad = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butAbrirConexion
            // 
            this.butAbrirConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butAbrirConexion.BackColor = System.Drawing.Color.Gold;
            this.butAbrirConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAbrirConexion.Location = new System.Drawing.Point(12, 457);
            this.butAbrirConexion.Name = "butAbrirConexion";
            this.butAbrirConexion.Size = new System.Drawing.Size(186, 26);
            this.butAbrirConexion.TabIndex = 0;
            this.butAbrirConexion.Text = "OPEN CONNECTION";
            this.butAbrirConexion.UseVisualStyleBackColor = false;
            this.butAbrirConexion.Click += new System.EventHandler(this.butAbrirConexion_Click);
            // 
            // pgbConnection
            // 
            this.pgbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pgbConnection.Location = new System.Drawing.Point(12, 426);
            this.pgbConnection.Name = "pgbConnection";
            this.pgbConnection.Size = new System.Drawing.Size(186, 25);
            this.pgbConnection.Step = 100;
            this.pgbConnection.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbConnection.TabIndex = 1;
            // 
            // labConexion
            // 
            this.labConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labConexion.AutoSize = true;
            this.labConexion.Location = new System.Drawing.Point(239, 435);
            this.labConexion.Name = "labConexion";
            this.labConexion.Size = new System.Drawing.Size(121, 16);
            this.labConexion.TabIndex = 2;
            this.labConexion.Text = "¡Conexión correcta!";
            this.labConexion.Visible = false;
            // 
            // butCloseConnection
            // 
            this.butCloseConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butCloseConnection.BackColor = System.Drawing.Color.Tomato;
            this.butCloseConnection.Enabled = false;
            this.butCloseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseConnection.Location = new System.Drawing.Point(204, 458);
            this.butCloseConnection.Name = "butCloseConnection";
            this.butCloseConnection.Size = new System.Drawing.Size(186, 25);
            this.butCloseConnection.TabIndex = 3;
            this.butCloseConnection.Text = "CLOSE CONNECTION";
            this.butCloseConnection.UseVisualStyleBackColor = false;
            this.butCloseConnection.Click += new System.EventHandler(this.butCloseConnection_Click);
            // 
            // butCloseApp
            // 
            this.butCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCloseApp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.butCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseApp.Location = new System.Drawing.Point(808, 459);
            this.butCloseApp.Name = "butCloseApp";
            this.butCloseApp.Size = new System.Drawing.Size(182, 24);
            this.butCloseApp.TabIndex = 4;
            this.butCloseApp.Text = "CLOSE APP";
            this.butCloseApp.UseVisualStyleBackColor = false;
            this.butCloseApp.Click += new System.EventHandler(this.butCloseApp_Click);
            // 
            // butNewJob
            // 
            this.butNewJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butNewJob.BackColor = System.Drawing.Color.YellowGreen;
            this.butNewJob.Enabled = false;
            this.butNewJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNewJob.Location = new System.Drawing.Point(620, 459);
            this.butNewJob.Name = "butNewJob";
            this.butNewJob.Size = new System.Drawing.Size(182, 24);
            this.butNewJob.TabIndex = 5;
            this.butNewJob.Text = "CREATE JOB";
            this.butNewJob.UseVisualStyleBackColor = false;
            this.butNewJob.Click += new System.EventHandler(this.butNewJob_Click);
            // 
            // ltbListaJobs
            // 
            this.ltbListaJobs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ltbListaJobs.FormattingEnabled = true;
            this.ltbListaJobs.ItemHeight = 16;
            this.ltbListaJobs.Location = new System.Drawing.Point(12, 66);
            this.ltbListaJobs.Name = "ltbListaJobs";
            this.ltbListaJobs.Size = new System.Drawing.Size(378, 308);
            this.ltbListaJobs.TabIndex = 6;
            // 
            // labJobsList
            // 
            this.labJobsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labJobsList.AutoSize = true;
            this.labJobsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJobsList.Location = new System.Drawing.Point(12, 43);
            this.labJobsList.Name = "labJobsList";
            this.labJobsList.Size = new System.Drawing.Size(81, 20);
            this.labJobsList.TabIndex = 7;
            this.labJobsList.Text = "Jobs list";
            // 
            // labEmployeesList
            // 
            this.labEmployeesList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labEmployeesList.AutoSize = true;
            this.labEmployeesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeesList.Location = new System.Drawing.Point(428, 43);
            this.labEmployeesList.Name = "labEmployeesList";
            this.labEmployeesList.Size = new System.Drawing.Size(138, 20);
            this.labEmployeesList.TabIndex = 9;
            this.labEmployeesList.Text = "Employees List";
            // 
            // butNewEmployee
            // 
            this.butNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butNewEmployee.BackColor = System.Drawing.Color.YellowGreen;
            this.butNewEmployee.Enabled = false;
            this.butNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNewEmployee.Location = new System.Drawing.Point(428, 458);
            this.butNewEmployee.Name = "butNewEmployee";
            this.butNewEmployee.Size = new System.Drawing.Size(186, 25);
            this.butNewEmployee.TabIndex = 10;
            this.butNewEmployee.Text = "CREATE EMPLOYEE";
            this.butNewEmployee.UseVisualStyleBackColor = false;
            // 
            // cbbCiudad
            // 
            this.cbbCiudad.FormattingEnabled = true;
            this.cbbCiudad.Items.AddRange(new object[] {
            "Southlake",
            "South San Francisco",
            "Seattle",
            "Toronto",
            "London",
            "Oxford",
            "Munich"});
            this.cbbCiudad.Location = new System.Drawing.Point(723, 380);
            this.cbbCiudad.Name = "cbbCiudad";
            this.cbbCiudad.Size = new System.Drawing.Size(121, 24);
            this.cbbCiudad.TabIndex = 13;
            this.cbbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbbCiudad_SelectedIndexChanged);
            // 
            // butFiltrarEmployees
            // 
            this.butFiltrarEmployees.Location = new System.Drawing.Point(869, 380);
            this.butFiltrarEmployees.Name = "butFiltrarEmployees";
            this.butFiltrarEmployees.Size = new System.Drawing.Size(121, 24);
            this.butFiltrarEmployees.TabIndex = 14;
            this.butFiltrarEmployees.Text = "Filtrar";
            this.butFiltrarEmployees.UseVisualStyleBackColor = true;
            this.butFiltrarEmployees.Click += new System.EventHandler(this.butFiltrarEmployees_Click);
            // 
            // labNombre
            // 
            this.labNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(462, 407);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(56, 16);
            this.labNombre.TabIndex = 15;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(607, 407);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(57, 16);
            this.labApellido.TabIndex = 16;
            this.labApellido.Text = "Apellido";
            // 
            // ltbListaEmployees
            // 
            this.ltbListaEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ltbListaEmployees.FormattingEnabled = true;
            this.ltbListaEmployees.ItemHeight = 16;
            this.ltbListaEmployees.Location = new System.Drawing.Point(428, 66);
            this.ltbListaEmployees.Name = "ltbListaEmployees";
            this.ltbListaEmployees.Size = new System.Drawing.Size(563, 308);
            this.ltbListaEmployees.TabIndex = 17;
            // 
            // labCiudad
            // 
            this.labCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labCiudad.AutoSize = true;
            this.labCiudad.Location = new System.Drawing.Point(755, 407);
            this.labCiudad.Name = "labCiudad";
            this.labCiudad.Size = new System.Drawing.Size(50, 16);
            this.labCiudad.TabIndex = 18;
            this.labCiudad.Text = "Ciudad";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(428, 380);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(121, 22);
            this.txbNombre.TabIndex = 19;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(575, 380);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(121, 22);
            this.txbApellido.TabIndex = 20;
            this.txbApellido.TextChanged += new System.EventHandler(this.txbApellido_TextChanged);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1003, 495);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.labCiudad);
            this.Controls.Add(this.ltbListaEmployees);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.butFiltrarEmployees);
            this.Controls.Add(this.cbbCiudad);
            this.Controls.Add(this.butNewEmployee);
            this.Controls.Add(this.labEmployeesList);
            this.Controls.Add(this.labJobsList);
            this.Controls.Add(this.ltbListaJobs);
            this.Controls.Add(this.butNewJob);
            this.Controls.Add(this.butCloseApp);
            this.Controls.Add(this.butCloseConnection);
            this.Controls.Add(this.labConexion);
            this.Controls.Add(this.pgbConnection);
            this.Controls.Add(this.butAbrirConexion);
            this.Name = "FormMenuPrincipal";
            this.Text = "Database connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAbrirConexion;
        private System.Windows.Forms.ProgressBar pgbConnection;
        private System.Windows.Forms.Label labConexion;
        private System.Windows.Forms.Button butCloseConnection;
        private System.Windows.Forms.Button butCloseApp;
        private System.Windows.Forms.Button butNewJob;
        private System.Windows.Forms.ListBox ltbListaJobs;
        private System.Windows.Forms.Label labJobsList;
        private System.Windows.Forms.Label labEmployeesList;
        private System.Windows.Forms.Button butNewEmployee;
        private System.Windows.Forms.ComboBox cbbCiudad;
        private System.Windows.Forms.Button butFiltrarEmployees;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ListBox ltbListaEmployees;
        private System.Windows.Forms.Label labCiudad;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
    }
}

