using System;
using System.Media;
using NAudio.Wave;

class Program
{
    static string userName; // This is a a file dand will be available to all methods

    static void Main()
    {
        //Voice message for the chatbot
        PlayAudio("welcome.wav"); // We are going to create a method for this ,this is just calling the method
        Console.WriteLine("");

        //This is an ASCII IMAGE FOR THE CYBER BOT
        Console.ForegroundColor = ConsoleColor.Magenta;
        WriteCentered("      .-\"      \"-.");
        WriteCentered("    /            \\");
        WriteCentered("   |              |");
        WriteCentered("   |,  .-.  .-.  ,|");
        WriteCentered("   | )(_o/  \\o_)( |");
        WriteCentered("   |/     /\\     \\|");
        WriteCentered("   (_     ^^     _)");
        WriteCentered("    \\__|IIIIII|__/");
        WriteCentered("     | \\IIIIII/ |");
        WriteCentered("     \\          /");
        WriteCentered("      `--------`");
        WriteCentered("  [ CYBERSECURITY CHATBOT! ]");
        WriteCentered("     Protecting Your Data!");
        Console.ResetColor();

        Console.WriteLine("");

        //This should play after the voice play the words must come in an art form 
        //Changing the color between user and chatbot for readability
        Console.ForegroundColor = ConsoleColor.Green;
        WriteCentered("Hello and welcome to a Cybersecurity Awareness Chatbot!!");
        WriteCentered("May i start by asking for your name"); //This is it to get the name of the user
        Console.ResetColor();
        Console.WriteLine("");

        userName = ReadLineCentered(); //User input is centered
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        WriteCentered("Welcome " + userName + " How can i be of help today ? ");
        Console.ResetColor();

        Console.WriteLine("");

        while (true) // This is a while loop which will loop indifinte if users inputs the right answers all the time
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WriteCentered("Please type a number of the topic you would like to know about");
            Console.WriteLine("");
            WriteCentered("Topics of Cybersecurity");
            WriteCentered("1. Password Safety");
            WriteCentered("2. Safe Browsing");
            WriteCentered("3. Phishing");
            WriteCentered("4. Chatbot information");
            WriteCentered("5. EXIT");
            Console.WriteLine("");
            Console.ResetColor();

            //This is for taking the input from the user for the option selection and other questions that may arrise
            string userChoice = ReadLineCentered();

            switch (userChoice.ToLower().Trim()) //To lower converts input to lowecases and to trim cuts all the spaces 
            {
                //Five Options to be handled for Cyberssecurity
                case "1":
                    PasswordSafety();
                    break;
                case "2":
                    SafeBrowsing();
                    break;
                case "3":
                    Phishing();
                    break;
                case "4":
                    Chatbot();
                    break;
                case "5":
                    Exit();
                    return;

                //This is to the handle the three questions which are ,How are you ,what is your purpose and what can i ask you about.
                case "how are you":
                    HowAreYou();
                    break;
                case "what is your purpose":
                    Purpose();
                    break;
                case "what can i ask you about":
                    AskAbout();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCentered("Invalid operation ,Please input a valid operation to get help");
                    Console.ResetColor();
                    break;
            }

            //This is just a line for readability between loop iterations
            Console.WriteLine("");
        }
    }

    //This method is for centering any text to the middle of the console window
    static void WriteCentered(string text)
    {
        int width = Console.WindowWidth; //This gets the width of the console
        string[] lines = text.Split('\n'); //In case text has new lines

        foreach (var line in lines) //We loop through each line
        {
            string trimmed = line.Trim(); //Remove any extra spaces
            int left = (width - trimmed.Length) / 2; //Find center starting point
            if (left < 0) left = 0; //If line is too long, just set it to 0
            Console.SetCursorPosition(left, Console.CursorTop); //Move the cursor to that position
            Console.WriteLine(trimmed); //Write the line
        }
    }

    //This method will let users type near the center
    static string ReadLineCentered()
    {
        int width = Console.WindowWidth;
        int left = width / 3; //Start the input a bit off center
        Console.SetCursorPosition(left, Console.CursorTop);
        return Console.ReadLine();
    }

    static void PlayAudio(string filePath)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play(); // Plays sound while showing the welcome message and ASCII LOGO
        }
        catch (Exception e)
        {
            Console.WriteLine("Error playing sound: " + e.Message);
        }
    }

    static void PasswordSafety()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteCentered("\n Password Safety");
        WriteCentered("1. Use atleast 12 characters in your password ,mixing uppercase ,lowercase,numbers and symbols");
        WriteCentered("2. Avoid using common words ,names or predictable patterns");
        WriteCentered("3. Never re use passwords acrross multiple platforms or accounts");
        WriteCentered("4. Turn on the two factor authentication wherever possible");
        Console.ResetColor();
    }

    static void SafeBrowsing()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteCentered("\n Safe Browsing");
        WriteCentered("1. Always Look for the HTTPS in the url when entering personal or payment information");
        WriteCentered("2. Avoid downloading pirated software or media ");
        WriteCentered("3. Use a tusted anti virus to protect you against threats");
        WriteCentered("4. Be on the look out for pop ups and fake alerts claiming your system is infected");
        Console.ResetColor();
    }

    static void Phishing()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteCentered("\n Phishing ");
        WriteCentered("1. Phishing scams try to trick you into showing them sensitive information");
        WriteCentered("2. Dont open or download attachements from unknown suspiciouis emails");
        WriteCentered("3. Never share personal information like passwords etc..");
        Console.ResetColor();
    }

    static void Chatbot()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteCentered("\n Information about this Chatbot");
        WriteCentered("I offer tips and guidance on important topics likes:");
        WriteCentered("  1. Password safety - Learn how to create a strong secure password");
        WriteCentered("  2. Safe Browsing - Stay protected while using the internet");
        WriteCentered("  3. Phishong awareness - Realise and avoid online scams ");
        WriteCentered("My goal is to educate you witht the simple and practical knowlegde to protect your digital life");
        Console.ResetColor();
    }

    static void Exit()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        WriteCentered("\n Good bye " + userName + "!! Stay safe online");
        Console.ResetColor();
    }

    static void HowAreYou()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        WriteCentered("I am just a Chatbot. I am here to ansnwer only related questions");
        Console.ResetColor();
    }

    static void Purpose()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        WriteCentered("I here to educate you about the importance of Cybersecurity");
        Console.ResetColor();
    }

    static void AskAbout()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        WriteCentered("Anything related to the five options given above");
        Console.ResetColor();
    }
}
