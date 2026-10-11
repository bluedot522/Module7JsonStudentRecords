namespace Module7JsonStudentRecords
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudStudentId = new NumericUpDown();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            comboProgram = new ComboBox();
            nudGpa = new NumericUpDown();
            btnAddStudent = new Button();
            btnSaveJson = new Button();
            btnLoadJson = new Button();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            lblStatus = new Label();
            lblStudentId = new Label();
            lblFirstName = new Label();
            lblProgram = new Label();
            lblGpa = new Label();
            lblLastName = new Label();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStudentId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // nudStudentId
            // 
            nudStudentId.Location = new Point(96, 40);
            nudStudentId.Name = "nudStudentId";
            nudStudentId.Size = new Size(88, 23);
            nudStudentId.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(96, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(151, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(96, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 23);
            txtLastName.TabIndex = 2;
            // 
            // comboProgram
            // 
            comboProgram.FormattingEnabled = true;
            comboProgram.Items.AddRange(new object[] { "Accounting", "Agriculture", "Aviation", "Biology", "Building Construction", "Business", "Chemistry", "Computer Science", "Criminal Justice", "Culinary Arts", "Cybersecurity", "Data Analytics", "Dental Hygeine", "Design", "Education", "Electrical Engineering", "Entrepreneurship", "Fine Arts", "General", "Health", "Informatics", "Interior Design", "Legal", "Liberal Arts", "Manufacturing", "Nursing", "Psychology", "Software Development", "Veterinary Nursing", "Visual Communications" });
            comboProgram.Location = new Point(96, 182);
            comboProgram.Name = "comboProgram";
            comboProgram.Size = new Size(151, 23);
            comboProgram.TabIndex = 3;
            // 
            // nudGpa
            // 
            nudGpa.DecimalPlaces = 1;
            nudGpa.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudGpa.Location = new Point(95, 229);
            nudGpa.Name = "nudGpa";
            nudGpa.Size = new Size(48, 23);
            nudGpa.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(25, 281);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(86, 31);
            btnAddStudent.TabIndex = 5;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(25, 535);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(99, 28);
            btnSaveJson.TabIndex = 6;
            btnSaveJson.Text = "Save to JSON";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Location = new Point(143, 535);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(104, 28);
            btnLoadJson.TabIndex = 7;
            btnLoadJson.Text = "Load from JSON";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(264, 535);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 28);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Display";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudents.Location = new Point(25, 332);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(423, 167);
            dgvStudents.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(131, 289);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 10;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(25, 41);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(65, 15);
            lblStudentId.TabIndex = 11;
            lblStudentId.Text = "Student ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(23, 89);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 12;
            lblFirstName.Text = "First Name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(34, 190);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(56, 15);
            lblProgram.TabIndex = 13;
            lblProgram.Text = "Program:";
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(57, 237);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(32, 15);
            lblGpa.TabIndex = 14;
            lblGpa.Text = "GPA:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(23, 144);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last Name:";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(373, 535);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 28);
            btnQuit.TabIndex = 16;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 589);
            Controls.Add(btnQuit);
            Controls.Add(lblLastName);
            Controls.Add(lblGpa);
            Controls.Add(lblProgram);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentId);
            Controls.Add(lblStatus);
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Controls.Add(btnLoadJson);
            Controls.Add(btnSaveJson);
            Controls.Add(btnAddStudent);
            Controls.Add(nudGpa);
            Controls.Add(comboProgram);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(nudStudentId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudStudentId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox comboProgram;
        private NumericUpDown nudGpa;
        private Button btnAddStudent;
        private Button btnSaveJson;
        private Button btnLoadJson;
        private Button btnClear;
        private DataGridView dgvStudents;
        private Label lblStatus;
        private Label lblStudentId;
        private Label lblFirstName;
        private Label lblProgram;
        private Label lblGpa;
        private Label lblLastName;
        private Button btnQuit;
    }
}
