using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace OnlineTestSimulator
{
    public class QuestionAnswer
    {
        public string Question { get; set; }
        public string ActualAnswer { get; set; }
        public string SelectedAnswer { get; set; }
        public bool AnsShown { get; set; }
    }

    public class QuestionsAnswers : List<QuestionAnswer>
    {
        
    }
}
