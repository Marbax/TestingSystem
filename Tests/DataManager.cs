using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionNS;

namespace Tests
{
    class DataManager
    {
        private List<Question> _test;

        public List<Question> Test
        {
            get { return _test; }
            set { _test = value; }
        }

        public DataManager()
        {
            _test = new List<Question>();
        }
    }
}
