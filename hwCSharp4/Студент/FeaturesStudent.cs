using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Студент
{
    public class FeaturesStudent
    {
        private string _FIO;
        private int _groupName;
        private int _numbergradeBook;


        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public int GroupName { get; set; }
        public int NumbergradeBook { get; set; }
        public string SNILS { get; set; }

        public FeaturesStudent(string fIO, int groupName, int numbergradeBook)
        {
            FIO = fIO;
            GroupName = groupName;
            NumbergradeBook = numbergradeBook;
        }

        public string Info() => $"ФИО: {FIO}, номер группы: {GroupName}, номер зачетнки: {NumbergradeBook}, Снилс: {SNILS}";
    }
}   
