using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClass;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Tests
{
    class DataManager
    {
        private BinaryFormatter bf = new BinaryFormatter();

        private string _testsFilePath;

        public string TestsFilePath
        {
            get { return _testsFilePath; }
            set { _testsFilePath = value; }
        }


        private List<Test> _testList;

        public List<Test> TestList
        {
            get { return _testList; }
            set { _testList = value; }
        }

        private void InitTestList()
        {
            Test testTest = new Test("Testing Test", "Test for testing");

            testTest.QuestionList.Add(new Question("Что есть жизнь?", 1,
                new KeyValuePair<string, bool>("Еда", false),
                new KeyValuePair<string, bool>("Кекс", false),
                new KeyValuePair<string, bool>("Котики", false),
                new KeyValuePair<string, bool>("Рокеннрол", true)));

            testTest.QuestionList.Add(new Question("What is love?", 1,
                new KeyValuePair<string, bool>("Games", false),
                new KeyValuePair<string, bool>("Baby dont hurt me", false),
                new KeyValuePair<string, bool>("Dev", false),
                new KeyValuePair<string, bool>("Рокеннрол", true)));

            testTest.QuestionList.Add(new Question("Akhuna matata?", 1,
                new KeyValuePair<string, bool>("Dont worry", false),
                new KeyValuePair<string, bool>("Be happy", false),
                new KeyValuePair<string, bool>("Life is simple", false),
                new KeyValuePair<string, bool>("There are three simple words", true)));

            TestList.Add(testTest);
            TestList.Add(new Test("tmp", "tmp"));
            TestList.Add(new Test("tmp", "tmp"));
            TestList.Add(new Test("tmp", "tmp"));
            TestList.Add(new Test("tmp", "tmp"));
        }

        public DataManager(string testsFilePath = @".\TestsDataFile.dat")
        {
            _testsFilePath = testsFilePath;
            _testList = new List<Test>();
            //InitTestList();
        }

        public void LoadData()
        {
            try
            {
                using (FileStream fs = new FileStream(_testsFilePath, FileMode.Open))
                {
                    _testList = (List<Test>)bf.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveData()
        {
            try
            {
                using (FileStream fs = new FileStream(_testsFilePath, FileMode.Create))
                {
                    bf.Serialize(fs, _testList);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
