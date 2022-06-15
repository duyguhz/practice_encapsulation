using System;
namespace practiceEncapsulation
{
    public class Student
    {
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No;
        public string FullName;
        private string _groupNo;
        private static int  _totalCount;
        public static int TotalCount => _totalCount;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNumber(value))
                {
                    _groupNo = value;
                }
            }
            
        }

        public static bool CheckGroupNumber(string text)
        {

            if (!string.IsNullOrWhiteSpace(text) && text.Length == 4)
            {
                if (char.IsLetter(text[0]))
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (char.IsDigit(text[i]))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }
        
        }
    }

