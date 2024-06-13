using System;

class DataTypeConversion
{
    static void Main()
    {
        // Display the main menu
        Console.WriteLine("Data Type Conversion Program");
        Console.WriteLine("1. Convert string to int");
        Console.WriteLine("2. Convert string to double");
        Console.WriteLine("3. Convert double to int");
        Console.WriteLine("4. Convert int to double");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option (1-5): ");

        // Read and validate user's choice
        string? choiceInput = Console.ReadLine();
        if (choiceInput != null && int.TryParse(choiceInput, out int choice) && choice >= 1 && choice <= 5)
        {
            // Perform the selected conversion based on the user's choice
            if (choice == 1)
                ConvertStringToInt();
            else if (choice == 2)
                ConvertStringToDouble();
            else if (choice == 3)
                ConvertDoubleToInt();
            else if (choice == 4)
                ConvertIntToDouble();
            else if (choice == 5)
                Console.WriteLine("Exiting the program.");
        }
        else
        {
            // Display an error message if the choice is invalid
            Console.WriteLine("Invalid choice. Please choose a valid option (1-5).");
        }
    }

    static void ConvertStringToInt()
    {
        // Prompt user to enter a string for conversion to int
        Console.Write("Enter a string to convert to int: ");
        string? input = Console.ReadLine();
        if (input != null && int.TryParse(input, out int result))
        {
            // Display the integer value if conversion succeeds
            Console.WriteLine("Converted value: " + result);
        }
        else
        {
            // Display an error message if conversion fails
            Console.WriteLine("Invalid input. Cannot convert to int.");
        }
    }

    static void ConvertStringToDouble()
    {
        // Prompt user to enter a string for conversion to double
        Console.Write("Enter a string to convert to double: ");
        string? input = Console.ReadLine();
        if (input != null && double.TryParse(input, out double result))
        {
            // Display the double value if conversion succeeds
            Console.WriteLine("Converted value: " + result);
        }
        else
        {
            // Display an error message if conversion fails
            Console.WriteLine("Invalid input. Cannot convert to double.");
        }
    }

    static void ConvertDoubleToInt()
    {
        // Prompt user to enter a double for conversion to int
        Console.Write("Enter a double to convert to int: ");
        string? input = Console.ReadLine();
        if (input != null && double.TryParse(input, out double doubleValue))
        {
            // Convert the double to an integer by truncating the fractional part
            int result = (int)doubleValue;
            // Display the integer value
            Console.WriteLine("Converted value: " + result);
        }
        else
        {
            // Display an error message if input is invalid
            Console.WriteLine("Invalid input. Cannot convert to int.");
        }
    }

    static void ConvertIntToDouble()
    {
        // Prompt user to enter an integer for conversion to double
        Console.Write("Enter an int to convert to double: ");
        string? input = Console.ReadLine();
        if (input != null && int.TryParse(input, out int intValue))
        {
            // Convert the integer to a double
            double result = (double)intValue;
            // Display the double value
            Console.WriteLine("Converted value: " + result);
        }
        else
        {
            // Display an error message if input is invalid
            Console.WriteLine("Invalid input. Cannot convert to double.");
        }
    }
}
