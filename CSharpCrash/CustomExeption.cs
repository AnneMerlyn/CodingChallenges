using System;
namespace CSharpCrash
{
	public class CustomExeption : Exception
	{
		public CustomExeption()
		{
		}

		public CustomExeption(string message) : base(message) { }
    }
}

