using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    #region Part 05 Encapsulation (Continued) - Indexer

    internal struct PhoneBook
    {
        #region Attributes/Fields

        private string[] names;
        private ulong[] numbers;
        private int size;  //size/capacity =>  is how many items an array can hold.
        private int length;//length        => is how many items an array currently has.

        #endregion

        #region Properties

        public int Size
        {
            get { return this.size; }
        }

        public int Length
        {
            get
            {
                length = 0;
                for (int i = 0; i < size; i++)
                {
                    if (names[i] is not null && numbers[i] != 0)
                    {
                        length++;
                    }
                }
                return length;
            }
        }

        #region Indexers => Special Property [Because it's always named with "this" keyword && can take parameters]

        public ulong this[string name]//this refer to current object.
        {
            get
            {
                if (this.names is { } && this.numbers is { })
                {
                    for (int i = 0; i < this.size; i++)
                    {
                        if (names[i] == name)
                        {
                            return numbers[i];
                        }
                    }
                    return 0;//Indicate that this name is not found.
                }
                return 1;//indicate that there is no names object and numbers object.
            }

            set
            {
                if (names is { } && numbers is { })
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            return;//once make update, Exit the method, and don't make another iteration
                        }
                    }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"{index + 1}- ({names[index]}, {numbers[index]})";
            }
        }

        #endregion

        #endregion

        #region Constructors

        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new ulong[size];
        }

        #endregion

        #region Methods

        #region Getters

        public ulong getNumber(string name)
        {
            if (this.names is { } && this.numbers is { })
            {
                for (int i = 0; i < this.size; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return 0;//Indicate that this name is not found.
            }
            return 1;//indicate that there is no names object and numbers object.
        }

        #endregion

        #region Setters

        public void setNumber(string name, ulong newNumber)
        {
            if (this.names is not null && this.numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = newNumber;
                        return;//once make update, Exit the method, and don't make another iteration
                    }
                }
            }
        }

        #endregion

        #region Another Methods

        public void AddPerson(uint position, string name, ulong number)
        {
            if (position < size && this.names is { } && this.numbers is { })
            {
                this.names[position] = name;
                this.numbers[position] = number;
            }
        }

        public void printPersons()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1}- ({names[i]}, {numbers[i]})\n");
            }
        }


        public int countPersons()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (names[i] is not null && numbers[i] != 0)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

        #endregion

    }

    #endregion
}
