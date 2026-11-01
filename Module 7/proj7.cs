using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // STEP 1: Create the dictionary
        Dictionary<string, string> dictionary =
            new Dictionary<string, string>();

        // Keeps the menu looping until the user picks exit
        bool running = true;

        while (running)
        {
            // STEP 2: Display the Menu
            Console.WriteLine("\n=== Dictionary Menu ===");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort the Keys");
            Console.WriteLine("7. Exit Program");
            Console.Write("Choose an option: ");

            // Read user's input.
            string choice = Console.ReadLine() ?? "";

            // STEP 3: Use a switch statement
            switch (choice)
            {
                /*Cases 1, 2 and Menu by Blaze*/
                // STEP 4: Populate the Dictionary
                case "1":
                    dictionary["Apple"] = "Fruit";
                    dictionary["Car"] = "Vehicle";
                    dictionary["Dog"] = "Animal";
                    dictionary["Book"] = "Reading material";

                    // Notify that the disctionary is populated
                    Console.WriteLine(
                        "Dictionary populated successfully!");
                    break;

                // STEP 5: Display Dictionary Contents
                case "2":
                    Console.WriteLine("\n=== Dictionary Contents ===");

                    foreach (KeyValuePair<string, string> item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    break;

                // cases 3, 4, 5 by Alex
                // step 5b. remove key
                case "3":
                    // key removal
                    Console.Write("enter the key to remove: ");
                    string removeKey = Console.ReadLine() ?? "";

                    if (dictionary.ContainsKey(removeKey))
                    {
                        // remove key and value
                        dictionary.Remove(removeKey);
                        Console.WriteLine("key removed!");
                    }
                    else
                    {
                        Console.WriteLine("key not found.");
                    }
                    break;

                // step 6. add new key and value
                case "4":
                    // user input new key
                    Console.Write("enter new key: ");
                    string newKey = Console.ReadLine() ?? "";

                    // check if key exists already
                    if (dictionary.ContainsKey(newKey))
                    {
                        Console.WriteLine("key already exists.");
                    }
                    else
                    {
                        // new value input
                        Console.Write("enter the value: ");
                        string newValue = Console.ReadLine() ?? "";

                        // new key and value added to dictionary
                        dictionary.Add(newKey, newValue);

                        Console.WriteLine("key and value added!");
                    }
                    break;

                // step 7. add a value to an existing key
                case "5":
                    // user input existing key
                    Console.Write("enter the key to add to: ");
                    string existKey = Console.ReadLine() ?? "";

                    // only add if the key is actually there
                    if (dictionary.ContainsKey(existKey))
                    {
                        Console.Write("enter the value to add: ");
                        string addValue = Console.ReadLine() ?? "";

                        // stick the new value on the end of the old one
                        dictionary[existKey] = dictionary[existKey] + ", " + addValue;
                        Console.WriteLine("value added!");
                    }
                    else
                    {
                        Console.WriteLine("key not found.");
                    }
                    break;

                // Cases 6, 7 and array/loop Tomas
                // Step 8: Sort keys
                case "6":
                    Console.WriteLine("\n=== Sorted Dictionary Keys ===");

                    // Copy keys into an array to sort
                    string[] sortedKeys = new string[dictionary.Count];
                    dictionary.Keys.CopyTo(sortedKeys, 0);
                    Array.Sort(sortedKeys);

                    foreach (string key in sortedKeys)
                    {
                        Console.WriteLine($"{key}: {dictionary[key]}");
                    }
                    break;

                // Step 9: exit
                case "7":
                    // Stop loop
                    running = false;
                    break;

                default:
                    Console.WriteLine("invalid choice.");
                    break;
            }
        }

        // STEP 10: End the Program
        // Display a message when the program finishes.
        Console.WriteLine("\nProgram finished.");

        // Wait for enter before closing.
        Console.Write("Press Enter to close...");
        Console.ReadLine();
    }
}
