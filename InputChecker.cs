using System;
using CSharpGames.RockPaperScissors;

namespace CSharpGames
{
	public class InputChecker
	{
		public static int IntCheck()
		{
			bool validInput = false;
			int inputInt = 0;

            while (!validInput)
			{
                string? inputString = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputString) && int.TryParse(inputString, out inputInt))
                {
					validInput = true;
                }
				else
				{
					Interface.DisplayError("Invalid input, try again");
					continue;
				}
            }

            return inputInt;
        }

		public static char CharCheck(List<char> usedLetters)
		{
			bool validInput = false;
			char inputChar = '\0';

			while (!validInput)
			{
				string? inputString = Console.ReadLine();

				if (!string.IsNullOrEmpty(inputString) && inputString.Trim().Length == 1 && char.IsLetter(inputString.Trim()[0]))
				{
                    if (!usedLetters.Contains(inputString.Trim()[0]))
					{
                        inputChar = inputString.Trim()[0];
                        validInput = true;
                    }
					else
					{
                        Interface.DisplayError("Letter already used");
                    }
				}
				else
				{
					Interface.DisplayError("Invalid input, please only enter a single letter.");
				}
			}

			return inputChar;
		}

		public static HandValue RockPaperScissorsCheck()
		{
			bool validInput = false;
			string handString = "";

			while (!validInput)
			{
                string? inputString = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputString) || !inputString!.ToUpper().Trim().Equals("ROCK") ||
					!inputString!.ToUpper().Trim().Equals("PAPER") ||
					!inputString!.ToUpper().Trim().Equals("SCISSORS"))
                {
					handString = inputString;
					validInput = true;
                }
                else
                {
                    Interface.DisplayError("Invalid input, please enter 'rock', 'paper' or 'sciccors'.");
                }
            }

			HandValue handValue = (HandValue)Enum.Parse(typeof(HandValue), handString);
			return handValue;
		}
	}
}

