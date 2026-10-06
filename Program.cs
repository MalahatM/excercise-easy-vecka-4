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



//uppgift 3
// Create a dictionary to store student names and grades
Dictionary<string, int> studentGrades = new Dictionary<string, int>();

// Variable for the user's menu choice
int gradeChoice = 0;

// Keep showing the menu until the user chooses to exit
while (gradeChoice != 5)
{
    Console.WriteLine("\n--- Student Grades ---");
    Console.WriteLine("1. Add student and grade");
    Console.WriteLine("2. Update grade");
    Console.WriteLine("3. Show all students and grades");
    Console.WriteLine("4. Calculate average grade");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");

    gradeChoice = Convert.ToInt32(Console.ReadLine());

    switch (gradeChoice)
    {
        case 1:
            // Ask for the student's name
            Console.Write("Enter student name: ");
            string studentNameToAdd = Console.ReadLine()!;

            // Check if the student already exists
            if (studentGrades.ContainsKey(studentNameToAdd))
            {
                Console.WriteLine("Student already exists.");
            }
            else
            {
                // Ask for the student's grade
                Console.Write("Enter grade: ");
                int studentGrade = Convert.ToInt32(Console.ReadLine());

                // Add the student and grade to the dictionary
                studentGrades.Add(studentNameToAdd, studentGrade);

                Console.WriteLine("Student added.");
            }

            break;

        case 2:
            // Ask which student's grade should be updated
            Console.Write("Enter student name: ");
            string studentNameToUpdate = Console.ReadLine()!;

            // Check if the student exists
            if (studentGrades.ContainsKey(studentNameToUpdate))
            {
                // Ask for the new grade
                Console.Write("Enter new grade: ");
                int updatedGrade = Convert.ToInt32(Console.ReadLine());

                // Update the student's grade
                studentGrades[studentNameToUpdate] = updatedGrade;

                Console.WriteLine("Grade updated.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            break;

        case 3:
            // Show all students and their grades
            foreach (var student in studentGrades)
            {
                Console.WriteLine(
                    $"Student: {student.Key}, Grade: {student.Value}"
                );
            }

            break;

        case 4:
            // Check that there are students before calculating the average
            if (studentGrades.Count > 0)
            {
                int gradeSum = 0;

                // Add all grades together
                foreach (var student in studentGrades)
                {
                    gradeSum += student.Value;
                }

                // Calculate the average grade
                double gradeAverage =
                    (double)gradeSum / studentGrades.Count;

                Console.WriteLine($"Average grade: {gradeAverage}");
            }
            else
            {
                Console.WriteLine("No students available.");
            }

            break;

        case 5:
            // Exit the program
            Console.WriteLine("Exiting the program.");
            break;

        default:
            // Handle an invalid menu choice
            Console.WriteLine("Invalid choice.");
            break;
    }
}

//uppgift 4
// Create a queue to store tasks
Queue<string> taskQueue = new Queue<string>();

// Variable for the user's menu choice
int queueChoice = 0;

// Keep showing the menu until the user chooses to exit
while (queueChoice != 5)
{
    Console.WriteLine("\n--- Task Manager ---");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. Show next task");
    Console.WriteLine("3. Complete a task");
    Console.WriteLine("4. Show all remaining tasks");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");

    queueChoice = Convert.ToInt32(Console.ReadLine());

    switch (queueChoice)
    {
        case 1:
            // Ask the user to enter a new task
            Console.Write("Enter a new task: ");
            string newTask = Console.ReadLine()!;

            // Add the new task to the end of the queue
            taskQueue.Enqueue(newTask);

            Console.WriteLine("Task added.");
            break;

        case 2:
            // Check if there are any tasks in the queue
            if (taskQueue.Count > 0)
            {
                // Show the first task without removing it
                string nextTask = taskQueue.Peek();

                Console.WriteLine($"Next task: {nextTask}");
            }
            else
            {
                Console.WriteLine("No tasks in the queue.");
            }

            break;

        case 3:
            // Check if there are any tasks in the queue
            if (taskQueue.Count > 0)
            {
                // Remove and return the first task in the queue
                string completedTask = taskQueue.Dequeue();

                Console.WriteLine($"Completed task: {completedTask}");
            }
            else
            {
                Console.WriteLine("No tasks to complete.");
            }

            break;

        case 4:
            // Check if there are any tasks in the queue
            if (taskQueue.Count > 0)
            {
                Console.WriteLine("Remaining tasks:");

                // Show all remaining tasks
                foreach (string task in taskQueue)
                {
                    Console.WriteLine(task);
                }
            }
            else
            {
                Console.WriteLine("No tasks in the queue.");
            }

            break;

        case 5:
            // Exit the task manager
            Console.WriteLine("Exiting task manager.");
            break;

        default:
            // Handle an invalid menu choice
            Console.WriteLine("Invalid choice.");
            break;
    }
}