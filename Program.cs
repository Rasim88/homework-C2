// Задачи 10 и 13
Console.WriteLine("Enter any number from 0 to 999:");
int AnyNumber = Convert.ToInt32(Console.ReadLine());

    if (AnyNumber <= 9)
    {
        Console.WriteLine("This is a single digit number: " + AnyNumber);
    }
    else if (AnyNumber > 9 && AnyNumber < 100)
    {
        Console.WriteLine("Second digit: " + (AnyNumber % 10));

        Console.WriteLine("Third digit is missing");
    }
    else if (AnyNumber >= 100)
    {
        Console.WriteLine("Second digit: " + ((AnyNumber / 10) % 10));

        Console.WriteLine("Third digit:" + ((AnyNumber / 10) - ((AnyNumber / 10) % 1)));
    }

// Задачи 15

Console.WriteLine("Enter Number from 0 to 7:");
int Number = Convert.ToInt32(Console.ReadLine());

    if (Number == 1)
    {
        Console.WriteLine("It's a weekday - Monday: " + Number);
    }
    else if (Number == 2)
    {
        Console.WriteLine("It's a weekday - Tuesday: " + Number);
    }
    else if (Number == 3)
    {
        Console.WriteLine("It's a weekday - Wednesday: " + Number);
    }    
    else if (Number == 4)
    {
        Console.WriteLine("It's a weekday - Thursday: " + Number);
    }    
    else if (Number == 5)
    {
        Console.WriteLine("It's a weekday - Friday: " + Number);
    }    
    else if (Number == 6)
    {
        Console.WriteLine("It's a weekend - Saturday: " + Number);
    }
    else if (Number == 7)
    {
        Console.WriteLine("It's a weekend - Sunday: " + Number);
    }

// Дополнительная задача

Console.WriteLine("Enter any number:");
int MultiNumber = Convert.ToInt32(Console.ReadLine());

    if ((MultiNumber % 7 == 0) && (MultiNumber % 23 == 0))
    {
        Console.WriteLine("You number is a multiple 7 and 23:" + MultiNumber);
    }
    else if (MultiNumber % 7 == 0)
    {
        Console.WriteLine("You number is a multiple of only 7: " + MultiNumber);
    }
    else if (MultiNumber % 23 == 0)
    {
        Console.WriteLine("You number is a multiple of only 23: " + MultiNumber);
    }
    else 
    {
        Console.WriteLine("You number is not multiple 7 and 23: " + MultiNumber);
    }