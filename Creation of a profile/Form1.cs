using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace JSON1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Student
        {
            public string name { get; set; }
            public string grade { get; set; }
            public string hobby { get; set; }
        }

        private void create_Click(object sender, EventArgs e)
        {
            string studentName = sName.Text;

            Student student = new Student()
            {
                grade = idNo.Text,
                name = sName.Text,
                hobby = sHobbies.Text,
            };
            string result = JsonConvert.SerializeObject(student);
            File.WriteAllText(@"Profiles/Profile - " + studentName + ".json", result);
            MessageBox.Show("Saved!", "JSON");
        }
    }
}