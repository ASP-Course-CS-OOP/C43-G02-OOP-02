using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person02
    {

        #region Properties

        public string Name { get; set; }
        public int Age { get; set; }

        #endregion

        #region Constructors

        public Person02(string name,int age)
        {
            Name = name;
            Age = age;
        }

        #endregion
    }
}
