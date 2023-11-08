namespace MarcVallverduConexionBaseDatos.Forms
{
    partial class FormCreateEmployee
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
            this.butSubmit = new System.Windows.Forms.Button();
            this.butCloseConnection = new System.Windows.Forms.Button();
            this.labEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.labLastName = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.labFirstName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.labPhoneNum = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.labJobId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labSalary = new System.Windows.Forms.Label();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.labManagerId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labDepartmentId = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSubmit
            // 
            this.butSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.butSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmit.Location = new System.Drawing.Point(48, 382);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(156, 47);
            this.butSubmit.TabIndex = 15;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butCloseConnection
            // 
            this.butCloseConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCloseConnection.BackColor = System.Drawing.Color.Tomato;
            this.butCloseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseConnection.Location = new System.Drawing.Point(277, 382);
            this.butCloseConnection.Name = "butCloseConnection";
            this.butCloseConnection.Size = new System.Drawing.Size(156, 47);
            this.butCloseConnection.TabIndex = 14;
            this.butCloseConnection.Text = "Close";
            this.butCloseConnection.UseVisualStyleBackColor = false;
            // 
            // labEmail
            // 
            this.labEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(26, 173);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(66, 16);
            this.labEmail.TabIndex = 13;
            this.labEmail.Text = "Email (*)";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Location = new System.Drawing.Point(29, 192);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(175, 22);
            this.txbEmail.TabIndex = 12;
            // 
            // labLastName
            // 
            this.labLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labLastName.AutoSize = true;
            this.labLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLastName.Location = new System.Drawing.Point(26, 97);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(98, 16);
            this.labLastName.TabIndex = 11;
            this.labLastName.Text = "Last name (*)";
            // 
            // txbLastName
            // 
            this.txbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbLastName.Location = new System.Drawing.Point(29, 116);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(175, 22);
            this.txbLastName.TabIndex = 10;
            // 
            // labFirstName
            // 
            this.labFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labFirstName.AutoSize = true;
            this.labFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstName.Location = new System.Drawing.Point(26, 20);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(69, 16);
            this.labFirstName.TabIndex = 9;
            this.labFirstName.Text = "First name";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFirstName.Location = new System.Drawing.Point(29, 39);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(175, 22);
            this.txbFirstName.TabIndex = 8;
            // 
            // labPhoneNum
            // 
            this.labPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPhoneNum.AutoSize = true;
            this.labPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhoneNum.Location = new System.Drawing.Point(26, 249);
            this.labPhoneNum.Name = "labPhoneNum";
            this.labPhoneNum.Size = new System.Drawing.Size(94, 16);
            this.labPhoneNum.TabIndex = 17;
            this.labPhoneNum.Text = "Phone number";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhoneNumber.Location = new System.Drawing.Point(29, 268);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(175, 22);
            this.txbPhoneNumber.TabIndex = 16;
            // 
            // labJobId
            // 
            this.labJobId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labJobId.AutoSize = true;
            this.labJobId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labJobId.Location = new System.Drawing.Point(274, 20);
            this.labJobId.Name = "labJobId";
            this.labJobId.Size = new System.Drawing.Size(72, 16);
            this.labJobId.TabIndex = 19;
            this.labJobId.Text = "Job ID (*)";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(277, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 18;
            // 
            // labSalary
            // 
            this.labSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labSalary.AutoSize = true;
            this.labSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSalary.Location = new System.Drawing.Point(274, 97);
            this.labSalary.Name = "labSalary";
            this.labSalary.Size = new System.Drawing.Size(72, 16);
            this.labSalary.TabIndex = 21;
            this.labSalary.Text = "Salary (*)";
            // 
            // txbSalary
            // 
            this.txbSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSalary.Location = new System.Drawing.Point(277, 116);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(175, 22);
            this.txbSalary.TabIndex = 20;
            // 
            // labManagerId
            // 
            this.labManagerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labManagerId.AutoSize = true;
            this.labManagerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labManagerId.Location = new System.Drawing.Point(274, 173);
            this.labManagerId.Name = "labManagerId";
            this.labManagerId.Size = new System.Drawing.Size(77, 16);
            this.labManagerId.TabIndex = 23;
            this.labManagerId.Text = "Manager ID";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(277, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 22;
            // 
            // labDepartmentId
            // 
            this.labDepartmentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDepartmentId.AutoSize = true;
            this.labDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDepartmentId.Location = new System.Drawing.Point(274, 249);
            this.labDepartmentId.Name = "labDepartmentId";
            this.labDepartmentId.Size = new System.Drawing.Size(93, 16);
            this.labDepartmentId.TabIndex = 25;
            this.labDepartmentId.Text = "Department ID";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(277, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 22);
            this.textBox3.TabIndex = 24;
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 441);
            this.Controls.Add(this.labDepartmentId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labManagerId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labSalary);
            this.Controls.Add(this.txbSalary);
            this.Controls.Add(this.labJobId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labPhoneNum);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCloseConnection);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.labFirstName);
            this.Controls.Add(this.txbFirstName);
            this.Name = "FormCreateEmployee";
            this.Text = "New employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butCloseConnection;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label labPhoneNum;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label labJobId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labSalary;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.Label labManagerId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labDepartmentId;
        private System.Windows.Forms.TextBox textBox3;
    }
}