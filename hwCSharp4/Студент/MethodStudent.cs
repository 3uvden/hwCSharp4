using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Студент
{
    public class MethodStudents
    {
        private string _FIO;
        private int _groupName;
        private int _numbergradeBook;
        private string _SNILS;


        public void SetFIO(string fio) => _FIO = fio;
        public string GetFIO() => _FIO;

        public int GetGroupName() => _groupName;
        public int GetGradeBookNum() => _numbergradeBook;

        public void SetSNILS(string snils) => _SNILS = snils;
        public string GetSNILS() => _SNILS;

        public string Info()
        {
            return $"ФИО: {_FIO}, номер группы: {_groupName}, номер зачетки: {_numbergradeBook}, Снилс: {_SNILS}";
        }



        public MethodStudents(string fIO, int groupName, int numbergradeBook)
        {
            _FIO = fIO;
            _groupName = groupName;
            _numbergradeBook = numbergradeBook;
        }
    }
}
