using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_practice_project_1._14
{
    internal class Subject
    {

       private string _subname;

		public string Name
		{
			get { return _subname; }
			set { _subname = value; }
		}

		private string _subCode;

		public string SubCode
		{
			get { return _subCode; }
			set { _subCode = value; }
		}

		public Subject(string n, string c)
		{
			Name = n;
			SubCode = c;

		}

	}
}
    
