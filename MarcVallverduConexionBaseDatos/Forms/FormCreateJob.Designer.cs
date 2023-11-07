namespace MarcVallverduConexionBaseDatos
{
    partial class FormCreateJob
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
            this.txbJobTitle = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labMinSalary = new System.Windows.Forms.Label();
            this.txbMinSalary = new System.Windows.Forms.TextBox();
            this.labMaxSalary = new System.Windows.Forms.Label();
            this.txbMaxSalary = new System.Windows.Forms.TextBox();
            this.butCloseConnection = new System.Windows.Forms.Button();
            this.butSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbJobTitle
            // 
            this.txbJobTitle.Location = new System.Drawing.Point(33, 50);
            this.txbJobTitle.Name = "txbJobTitle";
            this.txbJobTitle.Size = new System.Drawing.Size(175, 22);
            this.txbJobTitle.TabIndex = 0;
            this.txbJobTitle.TextChanged += new System.EventHandler(this.txbJobTitle_TextChanged);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(30, 31);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(88, 16);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Job Title (*)";
            // 
            // labMinSalary
            // 
            this.labMinSalary.AutoSize = true;
            this.labMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinSalary.Location = new System.Drawing.Point(30, 108);
            this.labMinSalary.Name = "labMinSalary";
            this.labMinSalary.Size = new System.Drawing.Size(73, 16);
            this.labMinSalary.TabIndex = 3;
            this.labMinSalary.Text = "Min. Salary";
            // 
            // txbMinSalary
            // 
            this.txbMinSalary.Location = new System.Drawing.Point(33, 127);
            this.txbMinSalary.Name = "txbMinSalary";
            this.txbMinSalary.Size = new System.Drawing.Size(175, 22);
            this.txbMinSalary.TabIndex = 2;
            // 
            // labMaxSalary
            // 
            this.labMaxSalary.AutoSize = true;
            this.labMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaxSalary.Location = new System.Drawing.Point(30, 184);
            this.labMaxSalary.Name = "labMaxSalary";
            this.labMaxSalary.Size = new System.Drawing.Size(77, 16);
            this.labMaxSalary.TabIndex = 5;
            this.labMaxSalary.Text = "Max. Salary";
            // 
            // txbMaxSalary
            // 
            this.txbMaxSalary.Location = new System.Drawing.Point(33, 203);
            this.txbMaxSalary.Name = "txbMaxSalary";
            this.txbMaxSalary.Size = new System.Drawing.Size(175, 22);
            this.txbMaxSalary.TabIndex = 4;
            // 
            // butCloseConnection
            // 
            this.butCloseConnection.BackColor = System.Drawing.Color.Tomato;
            this.butCloseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseConnection.Location = new System.Drawing.Point(264, 178);
            this.butCloseConnection.Name = "butCloseConnection";
            this.butCloseConnection.Size = new System.Drawing.Size(156, 47);
            this.butCloseConnection.TabIndex = 6;
            this.butCloseConnection.Text = "Close";
            this.butCloseConnection.UseVisualStyleBackColor = false;
            this.butCloseConnection.Click += new System.EventHandler(this.butCloseConnection_Click);
            // 
            // butSubmit
            // 
            this.butSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.butSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmit.Location = new System.Drawing.Point(264, 115);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(156, 47);
            this.butSubmit.TabIndex = 7;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // FormCreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(451, 259);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCloseConnection);
            this.Controls.Add(this.labMaxSalary);
            this.Controls.Add(this.txbMaxSalary);
            this.Controls.Add(this.labMinSalary);
            this.Controls.Add(this.txbMinSalary);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.txbJobTitle);
            this.Name = "FormCreateJob";
            this.Text = "New Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbJobTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labMinSalary;
        private System.Windows.Forms.TextBox txbMinSalary;
        private System.Windows.Forms.Label labMaxSalary;
        private System.Windows.Forms.TextBox txbMaxSalary;
        private System.Windows.Forms.Button butCloseConnection;
        private System.Windows.Forms.Button butSubmit;
    }
}