namespace StudentManagementSystem
{
    partial class Form1
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
            this.IblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.IblLastName = new System.Windows.Forms.Label();
            this.IblGender = new System.Windows.Forms.Label();
            this.IblDOB = new System.Windows.Forms.Label();
            this.IblEmail = new System.Windows.Forms.Label();
            this.IblPhone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtPDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // IblFirstName
            // 
            this.IblFirstName.AutoSize = true;
            this.IblFirstName.Location = new System.Drawing.Point(72, 41);
            this.IblFirstName.Name = "IblFirstName";
            this.IblFirstName.Size = new System.Drawing.Size(72, 16);
            this.IblFirstName.TabIndex = 0;
            this.IblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // IblLastName
            // 
            this.IblLastName.AutoSize = true;
            this.IblLastName.Location = new System.Drawing.Point(475, 41);
            this.IblLastName.Name = "IblLastName";
            this.IblLastName.Size = new System.Drawing.Size(72, 16);
            this.IblLastName.TabIndex = 2;
            this.IblLastName.Text = "Last Name";
            this.IblLastName.Click += new System.EventHandler(this.IblLastName_Click);
            // 
            // IblGender
            // 
            this.IblGender.AutoSize = true;
            this.IblGender.Location = new System.Drawing.Point(72, 87);
            this.IblGender.Name = "IblGender";
            this.IblGender.Size = new System.Drawing.Size(52, 16);
            this.IblGender.TabIndex = 3;
            this.IblGender.Text = "Gender";
            // 
            // IblDOB
            // 
            this.IblDOB.AutoSize = true;
            this.IblDOB.Location = new System.Drawing.Point(488, 84);
            this.IblDOB.Name = "IblDOB";
            this.IblDOB.Size = new System.Drawing.Size(36, 16);
            this.IblDOB.TabIndex = 4;
            this.IblDOB.Text = "DOB";
            // 
            // IblEmail
            // 
            this.IblEmail.AutoSize = true;
            this.IblEmail.Location = new System.Drawing.Point(72, 130);
            this.IblEmail.Name = "IblEmail";
            this.IblEmail.Size = new System.Drawing.Size(41, 16);
            this.IblEmail.TabIndex = 5;
            this.IblEmail.Text = "Email";
            this.IblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // IblPhone
            // 
            this.IblPhone.AutoSize = true;
            this.IblPhone.Location = new System.Drawing.Point(488, 124);
            this.IblPhone.Name = "IblPhone";
            this.IblPhone.Size = new System.Drawing.Size(46, 16);
            this.IblPhone.TabIndex = 6;
            this.IblPhone.Text = "Phone";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(606, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(156, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(606, 124);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(185, 80);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(150, 24);
            this.cmbGender.TabIndex = 10;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // dtPDOB
            // 
            this.dtPDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPDOB.Location = new System.Drawing.Point(606, 78);
            this.dtPDOB.Name = "dtPDOB";
            this.dtPDOB.Size = new System.Drawing.Size(156, 22);
            this.dtPDOB.TabIndex = 11;
            this.dtPDOB.ValueChanged += new System.EventHandler(this.dtPDOB_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(361, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(581, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(787, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 237);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1124, 248);
            this.dgvStudents.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 497);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtPDOB);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.IblPhone);
            this.Controls.Add(this.IblEmail);
            this.Controls.Add(this.IblDOB);
            this.Controls.Add(this.IblGender);
            this.Controls.Add(this.IblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.IblFirstName);
            this.Name = "Form1";
            this.Text = "First Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label IblLastName;
        private System.Windows.Forms.Label IblGender;
        private System.Windows.Forms.Label IblDOB;
        private System.Windows.Forms.Label IblEmail;
        private System.Windows.Forms.Label IblPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtPDOB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}

