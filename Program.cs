using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person namized = new Person();
            namized.Name = "Xeyale";
            namized.Age = 14;
            namized.Year = 2010;

        }

        public class Person
        {
            private string _name;
            private int _age;
            private int _year;
       

    

        public string Name
        {
            get { return _name; }

            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("adiniz 2 herfden azdir");
                }
            }
        }


        public int Age
        {
            get { return _age; }

            set
            {
                if ( value > 16)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Yasiniz kicikdir");
                }
            }

        }


        public int Year
            {
                get { return _year; }

                set
                {
                    if (value < 2008)
                    {
                        _year = value;
                    }
                    else
                    {
                        Console.WriteLine("Siz uygun namized deyilsiniz");
                    }
                }
            }



        }
      
    }
}
