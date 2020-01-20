using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Question
    {

        private string _questionnText;

        public string QuestionText
        {
            get { return _questionnText; }
            set { _questionnText = value; }
        }

        private double _questionValue;

        public double QuestionValue
        {
            get { return _questionValue; }
            set { _questionValue = value; }
        }


        private SortedList<string, bool> _answers;

        public SortedList<string, bool> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        public Question(string question, double questionValue, params KeyValuePair<string, bool>[] answers)
        {
            _questionnText = question;
            _questionValue = questionValue;
            _answers = new SortedList<string, bool>();
            foreach (var item in answers)
                _answers.Add(item.Key, item.Value);
        }

        public double Answer(params bool[] checkedItems)
        {
            double _answerValue = QuestionValue;
            int _index = 0;

            foreach (var item in Answers)
            {
                if (item.Value != checkedItems[_index])
                    _answerValue -= QuestionValue;
                _index++;
            }
            return _answerValue;
        }
    }
}
