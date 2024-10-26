using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StructIndexerException.HomeWork.Models
{
    internal class Student
    {
        public Student(string fullName, string groupNo, int age)
        {
            FullName = fullName;
            GroupNo = groupNo;
            Age = age;
        }

        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }

       public static bool CheckGroupNo(string groupNo) //P123
        {
            //if (string.IsNullOrEmpty(groupNo)&&groupNo.Length!=4)
            //  return false;
            //var part1 = groupNo.Substring(0, 1).ToCharArray();
            //string part2 = groupNo.Substring(1);

            //if (!(char.IsLetter(part1[0]) && char.IsUpper(part1[0])))
            //    return false;
            //foreach (var item in part2)
            //{
            //    if (!Char.IsDigit(item))
            //        return false;
            //}
            //return true;
            return Regex.IsMatch(groupNo, @"^[A-Z]\d{3}$");
        }
        public static bool CheckFullname(string fullName)//Lorem Ipsumov
        {
            //if(string.IsNullOrEmpty(fullName)) return false;
            //string[] names = fullName.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            //if (names.Length != 2)
            //    return false;
            //foreach (char letter in fullName)
            //{
            //    if (!Char.IsLetter(letter))
            //        return false;
            //}
            //return true;
            return Regex.IsMatch(fullName, @"^[A-Z][a-zA-Z]+\s[A-Z][a-zA-Z]+$");

        }

    }
}
