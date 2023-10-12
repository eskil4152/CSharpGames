// See https://aka.ms/new-console-template for more information

using CSharpGames;
using CSharpGames.Hangman;
using CSharpGames.NumberGuesser;
using CSharpGames.RockPaperScissors;

bool playing = true;

while (playing)
{
    Interface.SetTitle("Games In C Sharp");
    
    Interface.DisplayMessage("What do you want to play?");
    Interface.DisplayMessage("Write 1 for Hangman");
    Interface.DisplayMessage("Write 2 for Number Guesser");
    Interface.DisplayMessage("Write 3 for Rock, Paper, Scissors (Not finished yet)");

    Interface.Spacer();

    string? inputString = Console.ReadLine();

    if (int.TryParse(inputString, out int input))
    {
        switch (input)
        {
            case 1:
                await PlayHangman.Play();
                break;

            case 2:
                PlayNumberGuesser.Play();
                break;

            case 3:
                PlayRockPaperScissor.Play();
                break;

            default:
                Console.WriteLine("Invalid input");
                continue;
        }

        playing = KeepPlaying.KeepPlayingCheck("C# Games");

        Interface.Spacer();

    } else
    {
        Interface.DisplayMessage("Invalid input, please enter a number between 1 and 3");

        Interface.Spacer();
    }
}

Interface.ClearScreen();
Console.WriteLine("Bye!");
