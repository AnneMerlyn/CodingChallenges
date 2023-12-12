using System;
namespace CodingChallenges
{
	public class RemoveLastCharacterFunctions
	{
        public static string RemoveLastCharacter(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            return value.Substring(0, value.Length - 1);
        }

        
    }
}

