using System;
class P1
{
    static void Main()
    {   
        Console.Write("Enter the first number : ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        float b = float.Parse(Console.ReadLine());
        bool ch = true;
        float res=0;
        while (ch)
        {
            Console.Write("Enter the operator : ");
            char op = char.Parse(Console.ReadLine());
            
            switch(op)
            {
                case '+': res = a + b; break;
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case '/': if(b!=0)
                    {
                        res = a / b; break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid inputs"); break;
                    }
                case '%':
                    if (b != 0)
                    {
                        res = a % b; break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid inputs"); break;
                    }
                default : Console.WriteLine("Invalid input"); break;
            }

            Console.WriteLine($"{a}{op}{b} = {res}");
            Console.WriteLine("Enter 1 to continue and 0 to terminate program");
            int choice = int.Parse(Console.ReadLine());
            ch = (choice == 1);
        }
    }
}