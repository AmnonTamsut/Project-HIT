using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_HIT
{
    [Serializable()]

    public class Employee : Person
	{
		public int salary;
		public int workerId;

        public override void OpenForm(Form1 owner)
        {
            
        }

        public override void updateFiles()
        {
            throw new NotImplementedException();
        }
    }

	
}
