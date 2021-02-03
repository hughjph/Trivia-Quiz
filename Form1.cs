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
        string jsonUrl = "https://opentdb.com/api.php?amount=5&type=multiple";
        string json;
        string Q1cAnswer;
        string Q2cAnswer;
        string Q3cAnswer;
        string Q4cAnswer;
        string Q5cAnswer;
        int timesLoaded = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadJson();
        }

        class ComboItem
        {
            public int ID { get; set; }
            public string Answer { get; set; }
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
            json = json.Replace("&eacute;", "e");

            Console.WriteLine(json);

            JObject o1;
            try
            {
                o1 = JObject.Parse(json);
                dynamic jsonObj = JsonConvert.DeserializeObject(o1.ToString());

                foreach (var obj in jsonObj.results)
                {
                    string question = obj.question;
                    string cAnswer = obj.correct_answer;
                    string incAnswer1 = obj.incorrect_answers[0];
                    string incAnswer2 = obj.incorrect_answers[1];
                    string incAnswer3 = obj.incorrect_answers[2];

                    WriteInData(question, cAnswer, incAnswer1, incAnswer2, incAnswer3);

                    /*
                    Console.WriteLine(obj.question);
                    Console.WriteLine(obj.correct_answer);
                    Console.WriteLine(obj.incorrect_answers[0]);
                    Console.WriteLine(obj.incorrect_answers[1]);
                    Console.WriteLine(obj.incorrect_answers[2]);*/

                }
            }
            catch
            {
                LoadJson();
            }

            
        }

        public void WriteInData(string question, string cAnswer, string incAnswer1, string incAnswer2, string incAnswer3)
        {
            timesLoaded++;
            string[] Answers = new string[] { cAnswer, incAnswer1, incAnswer2, incAnswer3 };
            

            Random rnd = new Random();
            string[] MyRandomArray = Answers.OrderBy(x => rnd.Next()).ToArray();

            if (timesLoaded == 1)
            {
                Q1cAnswer = cAnswer;
                Question1Label.Text = "Question 1: " + question;
                Question1Answers.Items.AddRange(Answers);
            } else if (timesLoaded == 2)
            {
                Q2cAnswer = cAnswer;
                Question2Label.Text = "Question 2: " + question;
                Question2Answers.Items.AddRange(Answers);
            } else if (timesLoaded == 3)
            {
                Q3cAnswer = cAnswer;
                Question3Label.Text = "Question 3: " + question;
                Question3Answers.Items.AddRange(Answers);
            }
            else if (timesLoaded == 4)
            {
                Q4cAnswer = cAnswer;
                Question4Label.Text = "Question 4: " + question;
                Question4Answers.Items.AddRange(Answers);
            }
            else if (timesLoaded == 5)
            {
                Q5cAnswer = cAnswer;
                Question5Label.Text = "Question 5: " + question;
                Question5Answers.Items.AddRange(Answers);
                timesLoaded = 0;
            }




        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string q1Selected = Question1Answers.GetItemText(Question1Answers.SelectedItem);
            string q2Selected = Question2Answers.GetItemText(Question2Answers.SelectedItem);
            string q3Selected = Question3Answers.GetItemText(Question3Answers.SelectedItem);
            string q4Selected = Question4Answers.GetItemText(Question4Answers.SelectedItem);
            string q5Selected = Question5Answers.GetItemText(Question5Answers.SelectedItem);

            // add selection for q2-5

            string outputText = "";

            if (q1Selected == Q1cAnswer)
            {
                outputText += "Question 1: Correct! \n" + Environment.NewLine;
            }
            else
            {
                outputText += "Question 1: Wrong!"+ Environment.NewLine + "The correct answer was " + Q1cAnswer + Environment.NewLine;
            }

            if (q2Selected == Q2cAnswer)
            {
                outputText += "Question 2: Correct! \n" + Environment.NewLine;
            }
            else
            {
                outputText += "Question 2: Wrong!" + Environment.NewLine + "The correct answer was " + Q2cAnswer + Environment.NewLine;
            }

            if (q3Selected == Q3cAnswer)
            {
                outputText += "Question 3: Correct! \n" + Environment.NewLine;
            }
            else
            {
                outputText += "Question 3: Wrong!" + Environment.NewLine + "The correct answer was " + Q3cAnswer + Environment.NewLine;
            }

            if (q4Selected == Q4cAnswer)
            {
                outputText += "Question 4: Correct! \n" + Environment.NewLine;
            }
            else
            {
                outputText += "Question 4: Wrong!" + Environment.NewLine + "The correct answer was " + Q4cAnswer + Environment.NewLine;
            }

            if (q5Selected == Q5cAnswer)
            {
                outputText += "Question 5: Correct! \n" + Environment.NewLine;
            }
            else
            {
                outputText += "Question 5: Wrong!" + Environment.NewLine + "The correct answer was " + Q5cAnswer + Environment.NewLine;
            }




            AnswerOuput.Text = outputText;
        }

        private void btnNewQs_Click(object sender, EventArgs e)
        {
            Question1Answers.Items.Clear();
            Question2Answers.Items.Clear();
            Question3Answers.Items.Clear();
            Question4Answers.Items.Clear();
            Question5Answers.Items.Clear();

            Question1Answers.Text = "-Select an answer-";
            Question2Answers.Text = "-Select an answer-";
            Question3Answers.Text = "-Select an answer-";
            Question4Answers.Text = "-Select an answer-";
            Question5Answers.Text = "-Select an answer-";

            AnswerOuput.Text = "";
            LoadJson();
        }
    }
}
