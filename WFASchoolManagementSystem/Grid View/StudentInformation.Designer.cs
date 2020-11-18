namespace WFASchoolManagementSystem.Grid_View
{
    partial class FormStudentInfo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissiondate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduationdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parmanentaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtParmanentAddress = new System.Windows.Forms.TextBox();
            this.txtPresentAddress = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.dtpGraduationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelParmanentAddress = new System.Windows.Forms.Label();
            this.labelPresentAddress = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.LabelPaymentStatus = new System.Windows.Forms.Label();
            this.labelGraduationDate = new System.Windows.Forms.Label();
            this.labelAdmissionDate = new System.Windows.Forms.Label();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.labelBloodGroup = new System.Windows.Forms.Label();
            this.labelReligion = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 34);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 53);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(32, 358);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 53);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.fullname,
            this.email,
            this.gender,
            this.dateofbirth,
            this.nationality,
            this.religion,
            this.bloodgroup,
            this.fathername,
            this.mothername,
            this.admissiondate,
            this.graduationdate,
            this.paymentstatus,
            this.result,
            this.presentaddress,
            this.parmanentaddress,
            this.contactnumber});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudent.Location = new System.Drawing.Point(0, 531);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1350, 361);
            this.dgvStudent.TabIndex = 12;
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // userId
            // 
            this.userId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "Student ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "DOB";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationality.DataPropertyName = "nationality";
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // religion
            // 
            this.religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.religion.DataPropertyName = "religion";
            this.religion.HeaderText = "Religion";
            this.religion.Name = "religion";
            this.religion.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BloodGroup";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // fathername
            // 
            this.fathername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fathername.DataPropertyName = "fathername";
            this.fathername.HeaderText = "Father\'s Name";
            this.fathername.Name = "fathername";
            this.fathername.ReadOnly = true;
            // 
            // mothername
            // 
            this.mothername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mothername.DataPropertyName = "mothername";
            this.mothername.HeaderText = "Mother\'s Name";
            this.mothername.Name = "mothername";
            this.mothername.ReadOnly = true;
            // 
            // admissiondate
            // 
            this.admissiondate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admissiondate.DataPropertyName = "admissiondate";
            this.admissiondate.HeaderText = "AdmissionDate";
            this.admissiondate.Name = "admissiondate";
            this.admissiondate.ReadOnly = true;
            // 
            // graduationdate
            // 
            this.graduationdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.graduationdate.DataPropertyName = "graduationdate";
            this.graduationdate.HeaderText = "GraduationDate";
            this.graduationdate.Name = "graduationdate";
            this.graduationdate.ReadOnly = true;
            // 
            // paymentstatus
            // 
            this.paymentstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentstatus.DataPropertyName = "paymentstatus";
            this.paymentstatus.HeaderText = "Payment Status";
            this.paymentstatus.Name = "paymentstatus";
            this.paymentstatus.ReadOnly = true;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // presentaddress
            // 
            this.presentaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presentaddress.DataPropertyName = "presentaddress";
            this.presentaddress.HeaderText = "Present Address";
            this.presentaddress.Name = "presentaddress";
            this.presentaddress.ReadOnly = true;
            // 
            // parmanentaddress
            // 
            this.parmanentaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parmanentaddress.DataPropertyName = "parmanentaddress";
            this.parmanentaddress.HeaderText = "Parmanent Address";
            this.parmanentaddress.Name = "parmanentaddress";
            this.parmanentaddress.ReadOnly = true;
            // 
            // contactnumber
            // 
            this.contactnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactnumber.DataPropertyName = "contactnumber";
            this.contactnumber.HeaderText = "Contact Number";
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.ReadOnly = true;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(659, 330);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(211, 22);
            this.txtContactNumber.TabIndex = 80;
            // 
            // txtParmanentAddress
            // 
            this.txtParmanentAddress.Location = new System.Drawing.Point(659, 292);
            this.txtParmanentAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParmanentAddress.Name = "txtParmanentAddress";
            this.txtParmanentAddress.Size = new System.Drawing.Size(211, 22);
            this.txtParmanentAddress.TabIndex = 79;
            // 
            // txtPresentAddress
            // 
            this.txtPresentAddress.Location = new System.Drawing.Point(660, 257);
            this.txtPresentAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.Size = new System.Drawing.Size(211, 22);
            this.txtPresentAddress.TabIndex = 78;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(660, 220);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(211, 22);
            this.txtResult.TabIndex = 77;
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Location = new System.Drawing.Point(659, 188);
            this.txtPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(211, 22);
            this.txtPaymentStatus.TabIndex = 76;
            // 
            // dtpGraduationDate
            // 
            this.dtpGraduationDate.CustomFormat = "yyyy-MM-dd";
            this.dtpGraduationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGraduationDate.Location = new System.Drawing.Point(660, 156);
            this.dtpGraduationDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGraduationDate.Name = "dtpGraduationDate";
            this.dtpGraduationDate.Size = new System.Drawing.Size(211, 22);
            this.dtpGraduationDate.TabIndex = 75;
            // 
            // dtpAdmissionDate
            // 
            this.dtpAdmissionDate.CustomFormat = "yyyy-MM-dd";
            this.dtpAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdmissionDate.Location = new System.Drawing.Point(660, 123);
            this.dtpAdmissionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAdmissionDate.Name = "dtpAdmissionDate";
            this.dtpAdmissionDate.Size = new System.Drawing.Size(211, 22);
            this.dtpAdmissionDate.TabIndex = 74;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(660, 84);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(211, 22);
            this.txtMotherName.TabIndex = 73;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(660, 46);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(211, 22);
            this.txtFatherName.TabIndex = 72;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(163, 345);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(211, 22);
            this.txtBloodGroup.TabIndex = 71;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(163, 315);
            this.txtReligion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(211, 22);
            this.txtReligion.TabIndex = 70;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(163, 279);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(211, 22);
            this.txtNationality.TabIndex = 69;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 119);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 22);
            this.txtEmail.TabIndex = 67;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(163, 80);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(211, 22);
            this.txtFullName.TabIndex = 66;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(163, 43);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(211, 22);
            this.txtStudentId.TabIndex = 65;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AllowDrop = true;
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNumber.Location = new System.Drawing.Point(484, 330);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(131, 20);
            this.labelContactNumber.TabIndex = 64;
            this.labelContactNumber.Text = "Contact Number";
            // 
            // labelParmanentAddress
            // 
            this.labelParmanentAddress.AllowDrop = true;
            this.labelParmanentAddress.AutoSize = true;
            this.labelParmanentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParmanentAddress.Location = new System.Drawing.Point(484, 299);
            this.labelParmanentAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParmanentAddress.Name = "labelParmanentAddress";
            this.labelParmanentAddress.Size = new System.Drawing.Size(157, 20);
            this.labelParmanentAddress.TabIndex = 63;
            this.labelParmanentAddress.Text = "Parmanent Address";
            // 
            // labelPresentAddress
            // 
            this.labelPresentAddress.AllowDrop = true;
            this.labelPresentAddress.AutoSize = true;
            this.labelPresentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentAddress.Location = new System.Drawing.Point(485, 257);
            this.labelPresentAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPresentAddress.Name = "labelPresentAddress";
            this.labelPresentAddress.Size = new System.Drawing.Size(134, 20);
            this.labelPresentAddress.TabIndex = 62;
            this.labelPresentAddress.Text = "Present Address";
            // 
            // labelResult
            // 
            this.labelResult.AllowDrop = true;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(485, 218);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(57, 20);
            this.labelResult.TabIndex = 61;
            this.labelResult.Text = "Result";
            // 
            // LabelPaymentStatus
            // 
            this.LabelPaymentStatus.AllowDrop = true;
            this.LabelPaymentStatus.AutoSize = true;
            this.LabelPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaymentStatus.Location = new System.Drawing.Point(484, 188);
            this.LabelPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPaymentStatus.Name = "LabelPaymentStatus";
            this.LabelPaymentStatus.Size = new System.Drawing.Size(127, 20);
            this.LabelPaymentStatus.TabIndex = 60;
            this.LabelPaymentStatus.Text = "Payment Status";
            // 
            // labelGraduationDate
            // 
            this.labelGraduationDate.AllowDrop = true;
            this.labelGraduationDate.AutoSize = true;
            this.labelGraduationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraduationDate.Location = new System.Drawing.Point(485, 156);
            this.labelGraduationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGraduationDate.Name = "labelGraduationDate";
            this.labelGraduationDate.Size = new System.Drawing.Size(132, 20);
            this.labelGraduationDate.TabIndex = 59;
            this.labelGraduationDate.Text = "Graduation Date";
            // 
            // labelAdmissionDate
            // 
            this.labelAdmissionDate.AllowDrop = true;
            this.labelAdmissionDate.AutoSize = true;
            this.labelAdmissionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmissionDate.Location = new System.Drawing.Point(485, 123);
            this.labelAdmissionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(128, 20);
            this.labelAdmissionDate.TabIndex = 58;
            this.labelAdmissionDate.Text = "Admission Date";
            // 
            // labelMotherName
            // 
            this.labelMotherName.AllowDrop = true;
            this.labelMotherName.AutoSize = true;
            this.labelMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotherName.Location = new System.Drawing.Point(485, 84);
            this.labelMotherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(110, 20);
            this.labelMotherName.TabIndex = 57;
            this.labelMotherName.Text = "Mother Name";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AllowDrop = true;
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFatherName.Location = new System.Drawing.Point(485, 46);
            this.labelFatherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(106, 20);
            this.labelFatherName.TabIndex = 56;
            this.labelFatherName.Text = "Father Name";
            // 
            // labelBloodGroup
            // 
            this.labelBloodGroup.AllowDrop = true;
            this.labelBloodGroup.AutoSize = true;
            this.labelBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodGroup.Location = new System.Drawing.Point(47, 345);
            this.labelBloodGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBloodGroup.Name = "labelBloodGroup";
            this.labelBloodGroup.Size = new System.Drawing.Size(103, 20);
            this.labelBloodGroup.TabIndex = 55;
            this.labelBloodGroup.Text = "Blood Group";
            // 
            // labelReligion
            // 
            this.labelReligion.AllowDrop = true;
            this.labelReligion.AutoSize = true;
            this.labelReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReligion.Location = new System.Drawing.Point(47, 315);
            this.labelReligion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReligion.Name = "labelReligion";
            this.labelReligion.Size = new System.Drawing.Size(69, 20);
            this.labelReligion.TabIndex = 54;
            this.labelReligion.Text = "Religion";
            // 
            // labelNationality
            // 
            this.labelNationality.AllowDrop = true;
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(43, 279);
            this.labelNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(87, 20);
            this.labelNationality.TabIndex = 53;
            this.labelNationality.Text = "Nationality";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AllowDrop = true;
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(32, 241);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(109, 20);
            this.labelDateOfBirth.TabIndex = 52;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "yyyy-MM-dd";
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(163, 241);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(211, 22);
            this.dtpdob.TabIndex = 51;
            // 
            // labelGender
            // 
            this.labelGender.AllowDrop = true;
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(47, 177);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 20);
            this.labelGender.TabIndex = 50;
            this.labelGender.Text = "Gender";
            // 
            // labelEmail
            // 
            this.labelEmail.AllowDrop = true;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(47, 119);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 20);
            this.labelEmail.TabIndex = 49;
            this.labelEmail.Text = "Email";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AllowDrop = true;
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentId.Location = new System.Drawing.Point(49, 43);
            this.labelStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(92, 20);
            this.labelStudentId.TabIndex = 48;
            this.labelStudentId.Text = "StudentI ID";
            // 
            // labelFullName
            // 
            this.labelFullName.AllowDrop = true;
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(47, 80);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(85, 20);
            this.labelFullName.TabIndex = 47;
            this.labelFullName.Text = "Full Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(1013, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 485);
            this.panel1.TabIndex = 81;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 284);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(32, 212);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 53);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 128);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 53);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(883, 496);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 28);
            this.btnShow.TabIndex = 82;
            this.btnShow.Text = "Show All Info";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(19, 496);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(132, 22);
            this.txtAutoSearch.TabIndex = 85;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(163, 177);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(211, 24);
            this.cmbGender.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Search By Name";
            // 
            // FormStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtParmanentAddress);
            this.Controls.Add(this.txtPresentAddress);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPaymentStatus);
            this.Controls.Add(this.dtpGraduationDate);
            this.Controls.Add(this.dtpAdmissionDate);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.labelContactNumber);
            this.Controls.Add(this.labelParmanentAddress);
            this.Controls.Add(this.labelPresentAddress);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.LabelPaymentStatus);
            this.Controls.Add(this.labelGraduationDate);
            this.Controls.Add(this.labelAdmissionDate);
            this.Controls.Add(this.labelMotherName);
            this.Controls.Add(this.labelFatherName);
            this.Controls.Add(this.labelBloodGroup);
            this.Controls.Add(this.labelReligion);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudentInfo";
            this.Text = "StudentInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudentInformation_FormClosed);
            this.Load += new System.EventHandler(this.FormStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtParmanentAddress;
        private System.Windows.Forms.TextBox txtPresentAddress;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtPaymentStatus;
        private System.Windows.Forms.DateTimePicker dtpGraduationDate;
        private System.Windows.Forms.DateTimePicker dtpAdmissionDate;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label labelParmanentAddress;
        private System.Windows.Forms.Label labelPresentAddress;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label LabelPaymentStatus;
        private System.Windows.Forms.Label labelGraduationDate;
        private System.Windows.Forms.Label labelAdmissionDate;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Label labelBloodGroup;
        private System.Windows.Forms.Label labelReligion;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothername;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiondate;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduationdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmanentaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumber;
        private System.Windows.Forms.Label label1;
    }
}