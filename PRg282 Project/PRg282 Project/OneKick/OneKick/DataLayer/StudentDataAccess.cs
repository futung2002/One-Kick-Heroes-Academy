using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OneKick.DataLayer
{
    internal class StudentDataAccess
    {
        private readonly string filePath = "student.txt";

        //Saves student record
        public void addStudent(string name , int age, string cource)
        {
            string record = $"{name}, {age}, {cource}";
            File.AppendAllText(filePath, record + Environment.NewLine);
        }

        //This will read all students 
        public List<string[]> GetAllStudents()
        {
            var students = new List<string[]>();

            if (File.Exists(filePath))  
                return students;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (data.Length == 3)
                    students.Add(data);
            }
            return students;
        }

    }
}
