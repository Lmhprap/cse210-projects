//Robert A Phelps
//CSE210
//FINAL PROJECT

using System;

public class MainMenu : Menu
{
    // Attributes
    private new string _menu = $@"
                Main Menu 
==========================================
Please select one of the following options:
1. Play Game
2. How to Play
3. Quit
==========================================
Select a number the menu:  ";

    private string _welcome = @"
*******************************************
***                                     ***
***          Welcome to Hangman         ***
***   +++ Save me from the Hangman +++  ***
***                                     ***
*******************************************";
    private string _goodbye = @"
******************************************* 
***                                     ***
***        Thank you for playing.       ***
***      Please try you luck again!!    ***
***                                     ***
*******************************************";

    // Constructors

    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        // Call GameMenu
        Menu gameMenu = new GameMenu();
        // Print welcome message
        PrintWelcome();

        while (_action != 3)
        // switch case for main menu
        {
            // Ask for user input (1-6)
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Play Game - Untimed
                    Console.Clear();  // This will clear the console
                    gameMenu.MenuChoice();
                    break;
                // case 2:
                //     // Play Game - Timed
                //     Console.Clear();  // This will clear the console
                //     gameMenu.MenuChoice();
                //     break;
                case 2:
                    // How to Play
                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;
                case 3:
                    // Quite
                    PrintGoodbye();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    private void PrintWelcome()
    {
        Console.Clear();  // This will clear the console
        Console.Write($"{_welcome}\n\n");
    }
    private void PrintGoodbye()
    {
        Console.Clear();  // This will clear the console
        Console.Write($"{_goodbye}\n\n");
    }
}