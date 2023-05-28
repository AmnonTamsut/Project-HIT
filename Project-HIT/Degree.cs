using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_HIT.Form1;
using System.Windows.Forms;

namespace Project_HIT
{
	 public class Degree
	{
		string name;
		int pointsNeeded;
		Dictionary<string, string> courses;


		public Degree(string name, int pointsNeeded, string fileName)
		{
			string workingDirectory = Environment.CurrentDirectory;
			var path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName, fileName);
			this.Name = name;
			this.pointsNeeded = pointsNeeded;
			readFile(path);
			
		}

        public string Name { get => name; set => name = value; }


        internal Dictionary<string, string> Courses { get => courses; set => courses = value; }


		public void populateComboFromDegree(ComboBox comboBox) {

			
			foreach (KeyValuePair<string, string> k in this.courses) {
				comboBox.Items.Add(k.Key);
					}

		}

		private void readFile(string PATH)
		{
			var dict = File.ReadLines(PATH).Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);


			this.courses = dict ;
		}

		 

	}






}
