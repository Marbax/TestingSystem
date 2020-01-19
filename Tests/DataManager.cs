using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClass;

namespace Tests
{
    class DataManager
    {
        private List<Test> _testList;

        public List<Test> TestList
        {
            get { return _testList; }
            set { _testList = value; }
        }

        public DataManager()
        {
            _testList = new List<Test>();
        }
    }
}
