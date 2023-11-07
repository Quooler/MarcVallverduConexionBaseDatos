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
            this.labConexion.Location = new System.Drawing.Point(46, 397);
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
            this.butCloseApp.Location = new System.Drawing.Point(691, 435);
            this.butCloseApp.Name = "butCloseApp";
            this.butCloseApp.Size = new System.Drawing.Size(156, 48);
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
            this.butNewJob.Location = new System.Drawing.Point(661, 348);
            this.butNewJob.Name = "butNewJob";
            this.butNewJob.Size = new System.Drawing.Size(186, 65);
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
            this.ltbListaJobs.Size = new System.Drawing.Size(573, 308);
            this.ltbListaJobs.TabIndex = 6;
            // 
            // labJobsList
            // 
            this.labJobsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labJobsList.AutoSize = true;
            this.labJobsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJobsList.Location = new System.Drawing.Point(240, 43);
            this.labJobsList.Name = "labJobsList";
            this.labJobsList.Size = new System.Drawing.Size(81, 20);
            this.labJobsList.TabIndex = 7;
            this.labJobsList.Text = "Jobs list";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(859, 495);
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
    }
}

