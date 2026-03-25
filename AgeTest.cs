using System;


Console.WriteLine("\nHello!\n");

while(true) //run while it's true
{
    Console.WriteLine("Enter your age:");
    string AgeInput = Console.ReadLine(); //age check

        try //try to run a program 
        { 
            int AgeConverted = Convert.ToInt32(AgeInput); //convert string to int

            if (AgeConverted > 99)
            {
            Console.WriteLine("Please enter a realistic age (0-99).\n");
            } 

            if (AgeConverted >= 10 && AgeConverted <= 99)
            {
            Console.WriteLine("\nCongrats, your age is " + AgeConverted + "\n");
            break;
            }

            if (AgeConverted < 10)
            {
            Console.WriteLine("To use this app, age must be at least 10.\n");
            }  
        }

        catch //catch if there is a problem
        {
            Console.WriteLine("Invalid input. Please enter a number.\n");
        }
}

while(true)
{
    Console.WriteLine("Write: Done\n");
    string DoneInput = Console.ReadLine();

    if (DoneInput == "Done")
    {
        Console.WriteLine("\nIt's done!\n");
        break;
    }

    if (DoneInput == "done")
    {
        Console.WriteLine("\nPlease use a capital letter.\n");
    }

    else
    {
        Console.WriteLine("\nIt's not done. Please type Done.\n");
    }
}
