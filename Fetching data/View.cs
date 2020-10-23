using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace JSON1
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string l = uName.Text;
            string loca = @"Records/Record - " + l + ".json";
            string jsonData = "";
            using (StreamReader r = new StreamReader(Path.Combine(loca)))
            {
                string json = r.ReadToEnd();
                jsonData = json;
            }
            dynamic obj = JsonConvert.DeserializeObject(jsonData);
            dName.Text = obj["Name"];
            dProblem.Text = obj["Problem"];
            dFix.Text = obj["Fix"];
            
        }

        private void View_Load(object sender, EventArgs e)
        {

        }
    }
}