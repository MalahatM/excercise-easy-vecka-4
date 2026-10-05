// Prompt the user to enter the numbers
Console.Write("How many numbers do you want to enter? ");

// Read the number of numbers from the user
int numberOfNumbers = Convert.ToInt32(Console.ReadLine());

// Create an array to hold the numbers
int[] numbers = new int[numberOfNumbers];

// Loop to read each number from the user
for (int i = 0; i < numberOfNumbers; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

// Print each number entered by the user
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Number {i + 1}: {numbers[i]}");
}

// Calculate the sum
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}

// Calculate the average
double average = (double)sum / numbers.Length;

// Print sum and average
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");




//uppgift 2

// Create a list to store books
List<Bok> books = new List<Bok>();

// Variable for the user's menu choice
int choice = 0;

// Keep showing the menu until the user chooses to exit
while (choice != 4)
{
    Console.WriteLine("\n--- Book Collection ---");
    Console.WriteLine("1. Add a book");
    Console.WriteLine("2. Show all books");
    Console.WriteLine("3. Search for a book");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Ask the user for the book title
            Console.Write("Enter title: ");
            string title = Console.ReadLine()!;

            // Ask the user for the author
            Console.Write("Enter author: ");
            string author = Console.ReadLine()!;

            // Ask the user for the publication year
            Console.Write("Enter year published: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Create a new book object
            Bok newBook = new Bok
            {
                Titel = title,
                Författare = author,
                YearPublished = year
            };

            // Add the new book to the list
            books.Add(newBook);

            Console.WriteLine("Book added.");
            break;

        case 2:
            // Show all books in the collection
            foreach (Bok book in books)
            {
                Console.WriteLine(
                    $"Title: {book.Titel}, Author: {book.Författare}, Year: {book.YearPublished}"
                );
            }

            break;

        case 3:
            // Ask the user which title to search for
            Console.Write("Enter the title to search for: ");
            string searchTitle = Console.ReadLine()!;

            // Search through all books
            foreach (Bok book in books)
            {
                // Compare titles without caring about uppercase/lowercase
                if (book.Titel.ToLower() == searchTitle.ToLower())
                {
                    Console.WriteLine($"Title: {book.Titel}");
                    Console.WriteLine($"Author: {book.Författare}");
                    Console.WriteLine($"Year: {book.YearPublished}");
                }
            }

            break;

        case 4:
            // Exit the program
            Console.WriteLine("Exiting the program.");
            break;

        default:
            // Handle an invalid menu choice
            Console.WriteLine("Invalid choice.");
            break;
    }
}