using Project_HIT.Screens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Project_HIT
{

    [Serializable()]

    public class Student : Person
    {
        Degree d;
        double GPA = 0;
        Dictionary<string, int> grades = new Dictionary<string, int>();
        bool doneFirstTime = false;

        public Student(Degree degree)
        {
            this.D = degree;
            this.GPA1 = 0;
            //foreach (string c in d.Courses.Keys) Grades.Add(c, 0);
            //init();
        }

        public Degree D { get => d; set => d = value; }
        public Dictionary<string, int> Grades { get => grades; set => grades = value; }
        public double GPA1 { get => GPA; set => GPA = value; }

        private void init()
        {

            updateFiles();





        }

        private void readGrades()
        {
            string fileName = this.Id.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Grades\\" + this.Name + ".csv");


            if (File.Exists(path))
            {
                var dict = File.ReadLines(path).Select(line => line.Split(',')).ToArray();
                foreach (string[] arr in dict)
                {
                    if (this.Grades.ContainsKey(arr[0]))
                    {
                        this.Grades[arr[0]] = Int32.Parse(arr[1]);
                    }
                    else
                    {
                        this.Grades.Add(arr[0], Int32.Parse(arr[1]));


                    }
                }

            }


        }

        override public void OpenForm(Form1 owner)
        {
            var x = new StudentForm(this, owner);
            x.Show();
        }
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

        public override void updateFiles()
        {
            string fileName = this.Id.ToString();
            string workingDirectory = Environment.CurrentDirectory;
            string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Grades\\");
            path = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources\\Grades\\" + this.Name) + ".csv";

            //readGrades();


            if (!File.Exists(path))
            {



                var x = File.Create(path);
                x.Dispose();
                foreach (string c in d.Courses.Keys)
                {
                    Grades.Add(c, 0);

                    File.AppendAllLines(path, new string[] { c + "," + "0" });

                }

            }

            //&& !this.doneFirstTime
            else if (Grades.Count == 0)
            {
                readGrades();
                this.doneFirstTime = true;
                //File.WriteAllText(path, string.Empty);

                foreach (string c in d.Courses.Keys)
                {

                    //Grades.Add(c, 0);

                    File.AppendAllLines(path, new string[] { c + "," + this.Grades[c] });




                }
            }
            else
            {

                File.WriteAllText(path, string.Empty);


                foreach (string c in d.Courses.Keys)
                {


                    File.AppendAllLines(path, new string[] { c + "," + this.Grades[c] });




                }
            }

        }
    }
}
