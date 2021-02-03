using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Net;
using System.Web;
namespace TriviaQuiz
{
    public partial class Form1 : Form
    {
        string jsonUrl = "https://opentdb.com/api.php?amount=20&type=multiple";
        string json;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadJson();
        }

        public class results
        {
            public string Question { get; set; }
            public string CorrectAnswer { get; set; }
            public string IncorrectAnswer1 { get; set; }

            public string IncorrectAnswer2 { get; set; }
            public string IncorrectAnswer3 { get; set; }
            public string IncorrectAnswer4 { get; set; }
        }
        
        public void LoadJson()
        {
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(jsonUrl);
            }
            Console.WriteLine(json);
            json = json.Replace("&quot;", "");
            json = json.Replace("&#039;", "\'");
            json = json.Replace("&pi;", "pi");
            json = json.Replace("&‌amp;", "&");

            Console.WriteLine(json);

            JObject o1 = JObject.Parse(json);

            dynamic jsonObj = JsonConvert.DeserializeObject(o1.ToString());

            foreach (var obj in jsonObj.results)
            {
                Console.WriteLine(obj.question);
                Console.WriteLine(obj.correct_answer);
                Console.WriteLine(obj.incorrect_answers[0]);
                Console.WriteLine(obj.incorrect_answers[1]);
                Console.WriteLine(obj.incorrect_answers[2]);

            }
        }
    }
}
