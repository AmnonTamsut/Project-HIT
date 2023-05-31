using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Project_HIT
{
    [Serializable()]

    public class SchoolMain
    {
        //maps worker to worker id
        Dictionary<int, Employee> workers;

        //maps students and their TZ
        Dictionary<string, Student> students;

        //maps a user with it's password
        Dictionary<Person, string> users;

        //List of the schools degrees
        List<Degree> degrees;

        Dictionary<string, List<Student>> studentsInCourse;

        int numOfWorkers = 0;


        internal Dictionary<int, Employee> Workers { get => workers; set => workers = value; }
        internal Dictionary<string, Student> Students { get => students; set => students = value; }
        internal Dictionary<Person, string> Users { get => users; set => users = value; }
        internal List<Degree> Degrees { get => degrees; set => degrees = value; }

        public SchoolMain(Dictionary<int, Employee> workers, Dictionary<string, Student> students, Dictionary<Person, string> users, List<Degree> degree)
        {
            this.Workers = workers;
            this.Students = students;
            this.Users = users;
            this.Degrees = degree;
            SchoolInit();
        }
        public SchoolMain()
        {
            this.Workers = new Dictionary<int, Employee>();
            this.Students = new Dictionary<string, Student>();
            this.Users = new Dictionary<Person, string>();
            this.Degrees = new List<Degree>();

            SchoolInit();
        }

        void SchoolInit()
        {

            string filePathDegrees = "\\Resources\\Degrees\\Degrees.csv";
            string filePathUsers = "\\Resources\\Users\\";
            string workingDirectory = Environment.CurrentDirectory;
            var path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + filePathDegrees;

            readDegrees(path);

            foreach (Degree degree in Degrees)
            {
                path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + filePathUsers + degree.Name + ".csv";
                readStudents(path, degree);
            }


            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + filePathUsers + "Professors.csv";

            readProfessors(path);
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + filePathUsers + "Minhala.csv";
            readMinhala(path);



        }

        private void readMinhala(string path)
        {


            if (File.Exists(path))
            {


                var dict = File.ReadLines(path).Select(line => line.Split(',')).ToArray();
                foreach (string[] arr in dict)
                {
                    var x = new MinhalaEmployee(this);
                    x.Name = arr[0];
                    x.Id = Int32.Parse(arr[1]);
                    x.workerId = ++this.numOfWorkers;
                    this.users.Add(x, arr[2]);
                    this.workers.Add(this.numOfWorkers, x);
                }
            }
            else { File.Create(path); }
        }

        public void readProfessors(string path)
        {


            if (File.Exists(path))
            {


                var dict = File.ReadLines(path).Select(line => line.Split(',')).ToArray();
                foreach (string[] arr in dict)
                {

                    List<string> profCourses = arr[3..((arr.Length) - 1)].ToList();
                    List<Student> proffStudents = new List<Student>();

                    foreach (string c in profCourses) { proffStudents.AddRange(getAllStudentsForCourse(c)); }

                    var x = new Professor(profCourses, proffStudents);
                    x.Name = arr[0];
                    x.Id = Int32.Parse(arr[1]);
                    x.workerId = ++this.numOfWorkers;

                    this.workers.Add(this.numOfWorkers, x);


                    this.users.Add(x, arr[2]);
                }
            }
            else { File.Create(path); }

        }

        public Degree getDegreeByName(string name)
        {
            foreach (Degree d in this.Degrees) { if (d.Name.Equals(name)) return d; }
            return null;
        }

        public void readStudents(string path, Degree degree)
        {
            if (File.Exists(path))
            {
                var dict = File.ReadLines(path).Select(line => line.Split(',')).ToArray();
                foreach (string[] arr in dict)
                {

                    var x = new Student(degree);
                    x.Name = arr[0];
                    x.D = degree;
                    x.Id = Int32.Parse(arr[1]);
                    x.updateFiles();

                    this.Students.Add(arr[1], x);
                    this.users.Add(x, arr[2]);
                }
            }
            else { File.Create(path); }

        }


        public void readDegrees(string path)
        {
            if (File.Exists(path))
            {
                var dict = File.ReadLines(path).Select(line => line.Split(',')).ToArray();
                foreach (string[] arr in dict)
                {

                    var x = new Degree(arr[0], Int32.Parse(arr[1]), arr[2] + ".csv");

                    this.Degrees.Add(x);
                }

            }
            else { File.Create(path); }


        }


        public List<Student> getAllStudentsForCourse(string course)
        {
            List<Student> sList = new List<Student>();
            foreach (Person p in Users.Keys)
            {
                if (p is Student)
                {
                    if (((Student)p).D.Courses.ContainsKey(course))
                    {
                        sList.Add((Student)p);
                    }
                }
            }
            return sList;
        }
        public Person findUserById(int id, string password)
        {
            string value;
            foreach (Person p in this.Users.Keys)
            {
                if (p.Id == id && this.Users.TryGetValue(p, out value) && value.Equals(password.ToString()))
                {
                    return p;
                }

            }
            return null;
        }


        public void addUser(Person person, string pass)
        {

            this.users.Add(person, pass);

        }
    }
}
