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