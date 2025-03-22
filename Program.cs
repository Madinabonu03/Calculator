
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
       

 class Program{
    static void Main() 
    {
        Console.WriteLine("Welcome to simple calculator");
        bool isContinued=true;
        while(isContinued)
        {
            System.Console.WriteLine("1-Simple operation");
            System.Console.WriteLine("2-Tricky operation");
            System.Console.WriteLine("3-To see prime numbers till the given number");
            System.Console.WriteLine("Write anything to exit");
            System.Console.Write("Choose:");
            string inputOperation;
            int firstNumber;
            int indexOfOperator;
            int secondNumber;
            string choice=Console.ReadLine();
            switch(choice)
            {
             case "1":
                System.Console.WriteLine("Write the operation:");
                inputOperation=Console.ReadLine();
                if(inputOperation.Contains('+'))
                {
                    indexOfOperator=inputOperation.IndexOf('+');
                    firstNumber=Convert.ToInt32(inputOperation.Substring(0,indexOfOperator));
                    secondNumber=Convert.ToInt32(inputOperation.Substring(indexOfOperator+1));
                    System.Console.WriteLine($"Result: {firstNumber+secondNumber}");
                }
                else if (inputOperation.Contains('-'))
                {
                    firstNumber=Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('-')));
                    secondNumber=Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('-')+1));
                    System.Console.WriteLine($"Result: {firstNumber-secondNumber}");
                }
                else if (inputOperation.Contains('*'))
                {
                    firstNumber=Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('*')));
                    secondNumber=Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('*')+1));
                    System.Console.WriteLine($"Result: {firstNumber*secondNumber}");
                }
                else if (inputOperation.Contains('/'))
                {
                    firstNumber=Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('/')));
                    secondNumber=Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('/')+1));
                    System.Console.WriteLine($"Result: {firstNumber/secondNumber}");
                }
                else if (inputOperation.Contains('^'))
                {
                    firstNumber=Convert.ToInt32(inputOperation.Substring(0,inputOperation.IndexOf('^')));
                    secondNumber=Convert.ToInt32(inputOperation.Substring(inputOperation.IndexOf('^')+1));
                    System.Console.WriteLine($"Result: {Math.Pow(firstNumber,secondNumber)}");
                }
                else if (!inputOperation.Contains('+') && !inputOperation.Contains('-') && !inputOperation.Contains('*')
                && !inputOperation.Contains('/') && !inputOperation.Contains('^')) 
                {
                    System.Console.WriteLine("Invalid operation");
                }
                break;
                case "2":
                System.Console.WriteLine("Enter angle for its trigonemetric value :alpha=");
                string inputAngle=Console.ReadLine();
                int angle=Convert.ToInt32(inputAngle);
                System.Console.WriteLine($"tan(alpha)={Math.Atan(angle)}");
                System.Console.WriteLine($"sin(alpha)={Math.Asin(angle)}");
                System.Console.WriteLine($"cos(alpha)={Math.Cos(angle)}");
                break;
                default:
                System.Console.WriteLine("Bye ,the end");
                isContinued=false;
                break;
                }
                
            }
        }
}
   
        