using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_HIT
{

    public class Student : Person
    {
        Degree d;
        double GPA = 0;
        Dictionary<string, int> grades = new Dictionary<string, int>();

        public Student(Degree degree)
        {
            this.D = degree;
            this.GPA1 = 0;
            foreach (string c in d.Courses.Keys) Grades.Add(c, 0);
        }

        public Degree D { get => d; set => d = value; }
        public Dictionary<string, int> Grades { get => grades; set => grades = value; }
        public double GPA1 { get => GPA; set => GPA = value; }

        public void updateGpa()
        {
            int counter = 0;
            foreach (var x in this.grades)
            {
                counter++;
                this.GPA += (double)x.Value;
            }
            this.GPA = this.GPA / (double)counter;
        }

        public bool takesCourse(string course)
        {
            return this.grades.TryGetValue(course, out var result);

        }
        public DataTable StudentBalanceToDataTable()
        {
            DataTable data = new DataTable();
            data.Columns.Add("שם קורס");
            data.Columns.Add("נק׳ זכות");
            data.Columns.Add("ציון");

            List<List<string>> x = new List<List<string>>();
            foreach (KeyValuePair<string, string> c in this.D.Courses)
            {
                List<string> temp = new List<string>();
                int s = 0;
                Grades.TryGetValue(c.Key, out s);
                temp.Add(c.Key);
                temp.Add(c.Value);
                temp.Add(s.ToString());
                data.Rows.Add(temp.ToArray());
            }

            return data;

        }
    }
}
