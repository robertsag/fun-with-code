using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace QuestionAnswerReaderWriter
{
    public class QuestionAnswer
    {
        public string Question { get; set; }
        public string ActualAnswer { get; set; }
        public string SelectedAnswer { get; set; }
        public List<string> Choices { get; set; }
    }

    public class QuestionsAnswers : List<QuestionAnswer>
    {
        //public bool SerializeIntoXml()
        //{
        //    System.Xml.Serialization.XmlSerializer serializerReq = new System.Xml.Serialization.XmlSerializer(typeof(QuestionsAnswers));
        //    StringBuilder sbReq = new StringBuilder();
        //    System.IO.TextWriter twReq = new System.IO.StringWriter(sbReq);
        //    System.Xml.XmlWriter wsReq = new System.Xml.XmlTextWriter(twReq);
        //    serializerReq.Serialize(wsReq, this);

        //    string path = @"\QuestionsAndAnswers.xml";
        //    if (System.IO.File.Exists(path)) { System.IO.File.Delete(path); }

        //    FileStream fs = new FileStream(path, FileMode.Create);
        //    XmlTextWriter ws = new XmlTextWriter(fs, System.Text.Encoding.UTF8);
        //    ws.Formatting = Formatting.Indented;

        //    System.Xml.Serialization.XmlSerializer serial = new System.Xml.Serialization.XmlSerializer(typeof(QuestionsAnswers));
        //    serial.Serialize(ws, this);

        //    fs.Seek(0, SeekOrigin.Begin);
        //    fs.Flush();
        //    ws.Close();
        //    fs.Close();

        //    return true;
        //}

        //public bool DeserializeFromXml()
        //{

        //}
    }
}
