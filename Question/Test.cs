using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Test : ICloneable
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private List<Question> _questionList;

        public List<Question> QuestionList
        {
            get { return _questionList; }
            set { _questionList = value; }
        }

        public Test(string name = default, string description = default, params Question[] questins)
        {
            _questionList = new List<Question>();

            _name = name;
            _description = description;

            if (questins.Length > 0)
                foreach (var item in questins)
                    _questionList.Add(item);
        }

        public object Clone()
        {
            List<Question> newQuestionList = new List<Question>();
            foreach (var item in _questionList)
            {
                newQuestionList.Add(item.Clone() as Question);
            }

            return new Test(_name, _description, newQuestionList.ToArray());
        }

    }
}
