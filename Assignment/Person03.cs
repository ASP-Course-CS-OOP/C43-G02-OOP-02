using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person03
    {
        #region Properties

        public string[] Name { get; set; }
        public int[] Age { get; set; }
        public int Size { get; }
        public int Length
        {
            get
            {
                    int length = 0;
                for (int i = 0; i < Size; i++)
                {
                    if (Name[i] is not null && Age[i] != 0)
                    {
                        length++;
                    }
                }
                return length;
            }
        }

        #endregion

        #region Constructors

        public Person03(int size)
        {
            this.Size = size;
            Name = new string[size];
            Age = new int[size];
        }

        #endregion

        #region Methods

        public void AddPerson(int position, string name, int age)
        {
            if (Name is { } && Age is { } && position <= Size)
            {
                Name[position - 1] = name;
                Age[position - 1] = age;
            }
        }

        public void printPersons()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i + 1}-({Name[i]},{Age[i]})");
            }
        }
        #endregion


    }
}
