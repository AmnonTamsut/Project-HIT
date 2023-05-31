using System;



namespace Project_HIT
{
    [Serializable()]

    public class MinhalaEmployee : Employee
    {
        SchoolMain school;

        public MinhalaEmployee(int salary, int workerId, SchoolMain school)
        {
            this.salary = salary;
            this.workerId = workerId;
            this.school = school;
        }

        public MinhalaEmployee(SchoolMain school)
        {
            this.salary = 0;
            this.workerId = 0;
            this.school = school;
        }



        override public void OpenForm(Form1 owner)
        {
            var x = new MinhalaForm(this, this.school, owner);
            x.Show();
        }

        public void getAllStudentsForCourse(string course)
        {


        }
    }
}
