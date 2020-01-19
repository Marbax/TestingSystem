using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNS
{
    public class Question
    {


        private string _questionnText;

        public string QuestionText
        {
            get { return _questionnText; }
            set { _questionnText = value; }
        }

        private SortedList<string, bool> _answers;

        public SortedList<string, bool> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        public Question(string question, params KeyValuePair<string, bool>[] answers)
        {
            _questionnText = question;
            _answers = new SortedList<string, bool>();
            foreach (var item in answers)
                _answers.Add(item.Key, item.Value);

        }

    }
    //TODELETE

    /*
      public class Answer
    {
        private string _answerText;

        public string AnswerText
        {
            get { return _answerText; }
            set { _answerText = value; }
        }


        private bool _correct;

        public bool Correct
        {
            get { return _correct; }
            set { _correct = value; }
        }

        public Answer(string answerText, bool correct)
        {
            _answerText = answerText;
            _correct = correct;
        }

    }
    */
}
