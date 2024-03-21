using System;

class Program
{
    static void Main()
    {
        WeatherProgram();
        AgeCategorizationProgram();
        TemperatureConverterProgram();
        FindMaxAndMin();
        ReverseArray();
        FindSecondLargest();
        SumArrays();
        Console.ReadLine();
    }

    static void WeatherProgram()
    {
        try
        {
            Console.Write("Enter the temperature in degrees Celsius: ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("Cold weather.");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Cool weather.");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("Moderate weather.");
            }
            else
            {
                Console.WriteLine("Warm weather.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the temperature.");
        }
    }

    static void AgeCategorizationProgram()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Please enter a non-negative age.");
            }
            else if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for age.");
        }
    }

    static void TemperatureConverterProgram()
    {
        try
        {
            Console.Write("Enter the temperature value: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Enter the conversion direction (F to C or C to F): ");
            char conversionDirection = char.ToUpper(Console.ReadLine()[0]);

            if (conversionDirection == 'F')
            {
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature}F is equal to {celsius}C.");
            }
            else if (conversionDirection == 'C')
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"{temperature}C is equal to {fahrenheit}F.");
            }
            else
            {
                Console.WriteLine("Invalid conversion direction. Please enter 'F' or 'C'.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value for temperature.");
        }
    }

    static void FindMaxAndMin()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        if (numbers.Length > 0)
        {
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Maximum Element: " + max);
            Console.WriteLine("Minimum Element: " + min);
        }
        else
        {
            Console.WriteLine("Array is empty.");
        }
    }

    static void ReverseArray()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        if (numbers.Length > 1)
        {
            int left = 0, right = numbers.Length - 1;

            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }

            Console.WriteLine("\nReversed Array:");
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("Array should have at least two elements.");
        }
    }

    static void FindSecondLargest()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        if (numbers.Length >= 2)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            Console.WriteLine("\nSecond Largest Element: " + secondLargest);
        }
        else
        {
            Console.WriteLine("Array should have at least two elements.");
        }
    }

    static void SumArrays()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];

        Console.WriteLine("Enter elements for Array 1:");
        InputArray(array1);

        Console.WriteLine("\nEnter elements for Array 2:");
        InputArray(array2);

        int[] sumArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            sumArray[i] = array1[i] + array2[i];
        }

        Console.WriteLine("\nSum Array:");
        Console.WriteLine(string.Join(" ", sumArray));
    }

    static void InputArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }
}