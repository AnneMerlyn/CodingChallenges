using System;
namespace CSharpCrash
{
	public class Person
	{
		//fields
		private string name;
		private int age;

		//constructors
		public Person(string name, int age)
		{
			this.age = age;
			this.name = name;
		}

		//properties accesors for private fields
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

        //alternate
        //public string Name { get; set; }
        //public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old");
        }
    }

	
}

