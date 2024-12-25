using System;

class LibraryManager
{
    static void Main(string[] args)
    {
        // Step 1: Create variables for books
        string book1 = null, book2 = null, book3 = null, book4 = null, book5 = null;

        while (true) // Step 5: Loop indefinitely
        {
            Console.WriteLine("\nLibrary Manager");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an action (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Add a Book
                    // Step 7: Only allow adding if there are empty slots
                    if (book1 != null && book2 != null && book3 != null && book4 != null && book5 != null)
                    {
                        Console.WriteLine("The library is full. Cannot add more books.");
                    }
                    else
                    {
                        Console.Write("Enter the title of the book to add: ");
                        string newBook = Console.ReadLine();

                        if (book1 == null) book1 = newBook;
                        else if (book2 == null) book2 = newBook;
                        else if (book3 == null) book3 = newBook;
                        else if (book4 == null) book4 = newBook;
                        else if (book5 == null) book5 = newBook;

                        Console.WriteLine($"Book '{newBook}' added to the library.");
                    }
                    break;

                case "2": // Remove a Book
                    // Step 7: Only allow removing if there are books in the library
                    if (book1 == null && book2 == null && book3 == null && book4 == null && book5 == null)
                    {
                        Console.WriteLine("The library is empty. No books to remove.");
                    }
                    else
                    {
                        Console.Write("Enter the title of the book to remove: ");
                        string bookToRemove = Console.ReadLine();
                        bool found = false;

                        if (book1 == bookToRemove) { book1 = null; found = true; }
                        else if (book2 == bookToRemove) { book2 = null; found = true; }
                        else if (book3 == bookToRemove) { book3 = null; found = true; }
                        else if (book4 == bookToRemove) { book4 = null; found = true; }
                        else if (book5 == bookToRemove) { book5 = null; found = true; }

                        if (found)
                            Console.WriteLine($"Book '{bookToRemove}' removed from the library.");
                        else
                            Console.WriteLine($"Book '{bookToRemove}' not found in the library.");
                    }
                    break;

                case "3": // Display the list of books
                    Console.WriteLine("\nBooks in the Library:");
                    if (book1 != null) Console.WriteLine($"- {book1}");
                    if (book2 != null) Console.WriteLine($"- {book2}");
                    if (book3 != null) Console.WriteLine($"- {book3}");
                    if (book4 != null) Console.WriteLine($"- {book4}");
                    if (book5 != null) Console.WriteLine($"- {book5}");
                    if (book1 == null && book2 == null && book3 == null && book4 == null && book5 == null)
                        Console.WriteLine("No books in the library.");
                    break;

                case "4": // Exit
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default: // Step 6: Handle invalid inputs
                    Console.WriteLine("Invalid choice. Please choose a valid action (1-4).");
                    break;
            }
        }
    }
}
