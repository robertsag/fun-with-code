using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionAnswerReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuestionAnswer> questionAnswers = ParseQuestionAnswers();            

        }

        static List<QuestionAnswer> ParseQuestionAnswers()
        {
            QuestionsAnswers result = new QuestionsAnswers();

            //int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(@"D:\Prototypes\OnlineTestSimulator\Itil.txt");

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

            List<string> Questions = line.Split(new string[] { "QUESTION NO: "}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

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
    }
}
