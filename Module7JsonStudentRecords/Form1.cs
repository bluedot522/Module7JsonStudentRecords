using System.Drawing.Text;
using System.Text.Json;
using System.IO;

namespace Module7JsonStudentRecords
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudent()
        {
            bool isValid = false;
            isValid = ValidateInput();
            if (isValid == true)
            {
                Student student = new Student();
                students.Add(new Student
                {
                    StudentId = Convert.ToInt32(nudStudentId.Value),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    ProgramName = comboProgram.Text,
                    GPA = nudGpa.Value
                });
                lblStatus.Text = "Student successfully added.";
                DisplayStudents();
                ClearInputFields();
            }
        }

        private bool ValidateInput()
        {
            bool valid = false;
            if (nudStudentId.Value == 0)
            {
                lblStatus.Text = "Student ID must be greater than 0.";
            }
            else if (txtFirstName.Text == "")
            {
                lblStatus.Text = "First name must not be blank.";
            }
            else if (txtLastName.Text == "")
            {
                lblStatus.Text = "Last name must not be blank.";
            }
            else if (comboProgram.Text == "")
            {
                lblStatus.Text = "Program must be selected.";
            }
            else if (nudGpa.Value < 0.0m || nudGpa.Value > 4.0m)
            {
                lblStatus.Text = "GPA must be between 0.0 and 4.0.";
            }
            else
            {
                lblStatus.Text = "";
                valid = true;
            }

            return valid;
        }
        private void DisplayStudents()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
            dgvStudents.Columns[0].HeaderText = "ID";
            dgvStudents.Columns[1].HeaderText = "First Name";
            dgvStudents.Columns[2].HeaderText = "Last Name";
            dgvStudents.Columns[3].HeaderText = "Program";
            dgvStudents.Columns[4].HeaderText = "GPA";
            dgvStudents.Columns[4].DefaultCellStyle.Format = "N1";
        }
        private void SaveStudents()
        {
            if (students.Count >= 5)
            {
                string fileName = "students.json";
                string filePath = Path.Combine(Application.StartupPath, fileName);
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(students, options);
                File.WriteAllText(filePath, jsonString);
            }
            else
            {
                lblStatus.Text = "Must be at least 5 students to save.";
            }
        }
        private void LoadStudents()
        {
            try
            {
                string fileName = "students.json";
                string filePath = Path.Combine(Application.StartupPath, fileName);
                string jsonString = File.ReadAllText(filePath);
                students = JsonSerializer.Deserialize<List<Student>>(jsonString);
                DisplayStudents();
                lblStatus.Text = "Records loaded.";
            }
            catch (FileNotFoundException)
            {
                lblStatus.Text = "File not found.";
            }
            catch (JsonException)
            {
                lblStatus.Text = "JSON is invalid.";
            }
            catch (IOException)
            {
                lblStatus.Text = "Error processing file.";
            }
            catch (UnauthorizedAccessException)
            {
                lblStatus.Text = "Access denied.";

            }
            catch (Exception)
            {
                lblStatus.Text = "An error has occurred.";
            }
        }
        private void ClearInputFields()
        {
            nudStudentId.Value = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            comboProgram.SelectedIndex = -1;
            nudGpa.Value = 0.0m;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SaveStudents();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            students.Clear();
            lblStatus.Text = "Current records cleared.";
        }
    }
}
