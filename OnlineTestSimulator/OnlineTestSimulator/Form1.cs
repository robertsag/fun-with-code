using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Configuration;

namespace OnlineTestSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private static int _questionCounter;
        private List<QuestionAnswer> qnaThisTest;
        private string sourceFile = ConfigurationManager.AppSettings["SourceFile"];
        private string resultFile = ConfigurationManager.AppSettings["ResultFile"];
        private int numberOfQuestions = Convert.ToInt16(ConfigurationManager.AppSettings["NumberOfQuestions"]);
        private bool isReviewing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Questions
            List<QuestionAnswer> questionAnswers = ParseQuestionAnswers();
            qnaThisTest = questionAnswers.Take<QuestionAnswer>(numberOfQuestions).ToList<QuestionAnswer>();

            //Set Values
            _questionCounter = 0;
            lbl_Question.Text = qnaThisTest[_questionCounter].Question;
            lbl_QuestionCounter.Text = (_questionCounter + 1).ToString();

            //Set ScreenState
            RefreshControlStates(ScreenState.InitialLoading);            
        }

        private List<QuestionAnswer> ParseQuestionAnswers()
        {
            QuestionsAnswers result = new QuestionsAnswers();

            //int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(sourceFile);

            //while ((line = file.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //    counter++;
            //}
            line = file.ReadToEnd();
            file.Close();
            //Console.WriteLine(line);

            // Suspend the screen.
            //Console.ReadLine();

            List<string> Questions = line.Split(new string[] { "QUESTION NO: " }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            foreach (string item in Questions)
            {
                string[] qna = item.Split(new string[] { "Answer: " }, StringSplitOptions.None);
                QuestionAnswer qnaObject = new QuestionAnswer()
                {
                    Question = qna[0],
                    ActualAnswer = qna[1].Trim()
                };
                result.Add(qnaObject);
            }

            return result.OrderBy(a => Guid.NewGuid()).ToList<QuestionAnswer>();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            _questionCounter++;
            RefreshControlStates();
            lbl_Question.Text = qnaThisTest[_questionCounter].Question;
            lbl_QuestionCounter.Text = (_questionCounter + 1).ToString();

            if (isReviewing)
            {
                lbl_ShowAns.Text = qnaThisTest[_questionCounter].ActualAnswer;
                if (qnaThisTest[_questionCounter].ActualAnswer != qnaThisTest[_questionCounter].SelectedAnswer)
                    lbl_ShowAns.ForeColor = Color.Red;
                else
                    lbl_ShowAns.ForeColor = Color.Green;
            }
           
            //if already answered question, show the selected answer
            if (!string.IsNullOrEmpty(qnaThisTest[_questionCounter].SelectedAnswer))
            {
                if (qnaThisTest[_questionCounter].SelectedAnswer == "A")
                    radio_A.Checked = true;
                else if (qnaThisTest[_questionCounter].SelectedAnswer == "B")
                    radio_B.Checked = true;
                else if (qnaThisTest[_questionCounter].SelectedAnswer == "C")
                    radio_C.Checked = true;
                else if (qnaThisTest[_questionCounter].SelectedAnswer == "D")
                    radio_D.Checked = true;
            }
        }

        private void RefreshControlStates(ScreenState screenState)
        {
            lbl_Question.Text = string.Empty;
            lbl_ShowAns.Text = string.Empty;
            radio_A.Checked = false;
            radio_B.Checked = false;
            radio_C.Checked = false;
            radio_D.Checked = false;
            btn_Next.Enabled = (_questionCounter < (numberOfQuestions - 1));
            btn_Prev.Enabled = (_questionCounter != 0);
            btn_ShowAns.Enabled = false;
            btn_Review.Enabled = (_questionCounter == (numberOfQuestions - 1));

            if (screenState == ScreenState.InitialLoading)
            {
                radio_A.Checked = false;
                radio_B.Checked = false;
                radio_C.Checked = false;
                radio_D.Checked = false;
                btn_Next.Enabled = true;
                btn_Prev.Enabled = false;
                btn_ShowAns.Enabled = false;
                btn_Review.Enabled = false;
                groupBox1.Enabled = true;
            }
            else if (screenState == ScreenState.AnsSelected)
            {
                btn_ShowAns.Enabled = true;
            }
            else if (screenState == ScreenState.Next)
            {
                if (!string.IsNullOrEmpty(qnaThisTest[_questionCounter].SelectedAnswer))
                {
                    if (qnaThisTest[_questionCounter].SelectedAnswer == "A")
                        radio_A.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "B")
                        radio_B.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "C")
                        radio_C.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "D")
                        radio_D.Checked = true;

                    btn_ShowAns.Enabled = true;
                    groupBox1.Enabled = false;
                }
                else
                {
                    radio_A.Checked = false;
                    radio_B.Checked = false;
                    radio_C.Checked = false;
                    radio_D.Checked = false;
                    btn_ShowAns.Enabled = false;
                    groupBox1.Enabled = true;
                }
                
                btn_Next.Enabled = (_questionCounter < (numberOfQuestions - 1));
                btn_Prev.Enabled = true;
                btn_Review.Enabled = false;            
            }
            else if (screenState == ScreenState.Previous)
            {
                if (!string.IsNullOrEmpty(qnaThisTest[_questionCounter].SelectedAnswer))
                {
                    if (qnaThisTest[_questionCounter].SelectedAnswer == "A")
                        radio_A.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "B")
                        radio_B.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "C")
                        radio_C.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "D")
                        radio_D.Checked = true;

                    btn_ShowAns.Enabled = true;
                    groupBox1.Enabled = !qnaThisTest[_questionCounter].AnsShown;
                }
                else
                {
                    radio_A.Checked = false;
                    radio_B.Checked = false;
                    radio_C.Checked = false;
                    radio_D.Checked = false;
                    btn_ShowAns.Enabled = false;
                    groupBox1.Enabled = true;
                }

                btn_Next.Enabled = true;
                btn_Prev.Enabled = (_questionCounter != 0);                
                btn_Review.Enabled = false;            
            }
            else if (screenState == ScreenState.ShowAns)
            {
                groupBox1.Enabled = false;
            }
            else if (screenState == ScreenState.Review)
            {
                if (!string.IsNullOrEmpty(qnaThisTest[_questionCounter].SelectedAnswer))
                {
                    if (qnaThisTest[_questionCounter].SelectedAnswer == "A")
                        radio_A.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "B")
                        radio_B.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "C")
                        radio_C.Checked = true;
                    else if (qnaThisTest[_questionCounter].SelectedAnswer == "D")
                        radio_D.Checked = true;

                    btn_ShowAns.Enabled = true;
                    groupBox1.Enabled = false;
                }
                else
                {
                    radio_A.Checked = false;
                    radio_B.Checked = false;
                    radio_C.Checked = false;
                    radio_D.Checked = false;
                    btn_ShowAns.Enabled = false;
                    groupBox1.Enabled = false;
                }
            }
            else if (screenState == ScreenState.End)
            { 
            
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            _questionCounter--;
            RefreshControlStates();
            lbl_Question.Text = qnaThisTest[_questionCounter].Question;
            lbl_QuestionCounter.Text = (_questionCounter + 1).ToString();

            if (isReviewing)
            {
                lbl_ShowAns.Text = qnaThisTest[_questionCounter].ActualAnswer;
                if (qnaThisTest[_questionCounter].ActualAnswer != qnaThisTest[_questionCounter].SelectedAnswer)
                    lbl_ShowAns.ForeColor = Color.Red;
                else
                    lbl_ShowAns.ForeColor = Color.Green;
            }

            if (qnaThisTest[_questionCounter].SelectedAnswer == "A")
                radio_A.Checked = true;
            else if (qnaThisTest[_questionCounter].SelectedAnswer == "B")
                radio_B.Checked = true;
            else if (qnaThisTest[_questionCounter].SelectedAnswer == "C")
                radio_C.Checked = true;
            else if (qnaThisTest[_questionCounter].SelectedAnswer == "D")
                radio_D.Checked = true;
        }

        private void radio_A_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_A.Checked == true)
            {
                qnaThisTest[_questionCounter].SelectedAnswer = "A";
                btn_ShowAns.Enabled = !isReviewing;
            }

        }

        private void radio_B_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_B.Checked == true)
            {
                qnaThisTest[_questionCounter].SelectedAnswer = "B";
                btn_ShowAns.Enabled = !isReviewing;
            }
        }

        private void radio_C_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_C.Checked == true)
            {
                qnaThisTest[_questionCounter].SelectedAnswer = "C";
                btn_ShowAns.Enabled = !isReviewing;
            }
        }

        private void radio_D_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_D.Checked == true)
            {
                qnaThisTest[_questionCounter].SelectedAnswer = "D";
                btn_ShowAns.Enabled = !isReviewing;
            }
        }

        private void btn_EndTest_Click(object sender, EventArgs e)
        {
            var attemptedItems = from item in qnaThisTest
                               where !string.IsNullOrEmpty(item.SelectedAnswer)  
                               select item;

            var successItems = from item in qnaThisTest
                               where item.ActualAnswer == item.SelectedAnswer
                               select item;

            int attemptedCount = attemptedItems.Count();
            int successCount = successItems.Count();
            double percentage = ((double)successCount / numberOfQuestions) * 100;

            string message = String.Format("Total Questions = 40 \nAttempted Questions = {0} \nCorrect Answers = {1} \nPercentage = {2}%",
                                            attemptedCount.ToString(),
                                            successCount.ToString(),
                                            percentage.ToString());

            MessageBox.Show(this,message, "Your Result");
            //SaveResult();

            if (MessageBox.Show("Do you want to exit the test?", "End Test", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void SaveResult()
        {
            System.Xml.Serialization.XmlSerializer serializerReq = new System.Xml.Serialization.XmlSerializer(typeof(List<QuestionAnswer>));
            StringBuilder sbReq = new StringBuilder();
            System.IO.TextWriter twReq = new System.IO.StringWriter(sbReq);
            System.Xml.XmlWriter wsReq = new System.Xml.XmlTextWriter(twReq);
            serializerReq.Serialize(wsReq, qnaThisTest);

            if (System.IO.File.Exists(resultFile)) { System.IO.File.Delete(resultFile); }

            FileStream fs = new FileStream(resultFile, FileMode.Create);
            XmlTextWriter ws = new XmlTextWriter(fs, System.Text.Encoding.UTF8);
            ws.Formatting = Formatting.Indented;

            System.Xml.Serialization.XmlSerializer serial = new System.Xml.Serialization.XmlSerializer(typeof(List<QuestionAnswer>));
            serial.Serialize(ws, qnaThisTest);

            fs.Seek(0, SeekOrigin.Begin);
            fs.Flush();
            ws.Close();
            fs.Close();
        }

        private void btn_ShowAns_Click(object sender, EventArgs e)
        {
            if (qnaThisTest[_questionCounter].ActualAnswer != qnaThisTest[_questionCounter].SelectedAnswer)
                lbl_ShowAns.ForeColor = Color.Red;
            else
                lbl_ShowAns.ForeColor = Color.Green;


            lbl_ShowAns.Text = qnaThisTest[_questionCounter].ActualAnswer;
        }

        private void btn_Review_Click(object sender, EventArgs e)
        {
            _questionCounter = 0;
            RefreshControlStates();
           
            lbl_Question.Text = qnaThisTest[_questionCounter].Question;
            lbl_QuestionCounter.Text = (_questionCounter + 1).ToString();
            lbl_ShowAns.Text = qnaThisTest[_questionCounter].ActualAnswer;

            if (qnaThisTest[_questionCounter].ActualAnswer != qnaThisTest[_questionCounter].SelectedAnswer)
                lbl_ShowAns.ForeColor = Color.Red;
            else
                lbl_ShowAns.ForeColor = Color.Green;

            if (qnaThisTest[_questionCounter].SelectedAnswer == "A")
                radio_A.Checked = true;
            else if (qnaThisTest[_questionCounter].SelectedAnswer == "B")
                radio_B.Checked = true;
            else if (qnaThisTest[_questionCounter].SelectedAnswer == "C")
                radio_C.Checked = true;
            else if (qnaThisTest[_questionCounter].SelectedAnswer == "D")
                radio_D.Checked = true;

            btn_Next.Enabled = true;
            isReviewing = true;
            groupBox1.Enabled = false;

        }

        private enum ScreenState
        { 
            InitialLoading,
            Next,
            Previous,
            ShowAns,
            Review,
            End,
            AnsSelected
        }
    }
}
