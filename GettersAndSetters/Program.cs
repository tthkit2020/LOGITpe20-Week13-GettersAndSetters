using System;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            string gender;
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idCode;
            }

            public string Name
            {
                get { return name; }
            }

            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value == "male" || value == "female")
                    {
                        gender = value;
                    } else
                    {
                        gender = "undefined unicorn";
                    }
                }
            }

            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if (value.Length == 11)
                    {
                        idCode = value;
                    }
                    else
                    {
                        idCode = "undefined";
                    }
                }
            }

            public void ChangeName(string newName)
            {
                name = newName;
            }

            public void ChangeIdCode(string newCode)
            {
                IdCode = newCode;
            }

        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("Harry Potter", "gmail", 35, "1234");
            Console.WriteLine(newPerson.Name);
           // Console.WriteLine(newPerson.age);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);
            newPerson.ChangeName("Harry Plotter");
            newPerson.ChangeIdCode("12345");
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.IdCode);
            //newPerson.name = "Harriette Plotter";
            //newPerson.gender = "female";
            //newPerson.age = 21;
            // Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.age);
            //  Console.WriteLine(newPerson.gender);

        }
    }
}
