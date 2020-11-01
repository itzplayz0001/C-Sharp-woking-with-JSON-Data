using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Chat_Bot
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        class User
        {
            public string name { get; set; }
        }
        private void main_Load(object sender, EventArgs e)
        {
            setupWindow.Hide();
            string local = @"user.json";
            if (File.Exists(local))
            {
                //
                string jsonData = "";
                using (StreamReader r = new StreamReader(Path.Combine(local)))
                {
                    string json = r.ReadToEnd();
                    jsonData = json;
                }
                dynamic obj = JsonConvert.DeserializeObject(jsonData);
                string username = obj["name"];
            }
            else
            {
                setupWindow.Show();
            }
        }

        private void setup_Click(object sender, EventArgs e)
        {
            string uName = setupName.Text;

            User user = new User()
            {
                name = uName,
            };

            string data = JsonConvert.SerializeObject(user);
            File.WriteAllText(@"user.json", data);
        }
    }
}
