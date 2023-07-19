Console.Write("Please enter your name: ");
string name=Console.ReadLine();
Console.Clear();
Console.WriteLine($"Welcome to Number Guessing Game {name}");
Random random = new();
int number = random.Next(1, 10);

int test = 0;
while (true)
{   
    test++;
    try
    {
        Console.WriteLine("Please guess a number from 1-10: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess >= 1 && guess <= 10)
        {
            if (number == guess)
            {
                Console.Clear();
                Console.WriteLine($"CONGRATULATİONS \nYou got your {test}th guess right. ");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("WRONG! Please try again..");
            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please keep your number between 1-10 !");
        }
           

    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Please don't enter characters other than number!!");

    }
}
