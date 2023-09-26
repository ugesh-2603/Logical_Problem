namespace Logical_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while (execute)
            { 
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Display_5_friend_name \n2.Square_of_Numbers \n3.String_Conversion \n4. Uppercase_Lowercase \n5. Average \n6. AreaofCircle \n7. Date_and_Time \n8. StopWatch \n9. Range_of_Numbers \n10. Person_Name  \n11.Print_1_to_100 \n12.Number_to_String \n13.Present_Absent \n14.Shifting_the_number \n15.Quadratic EQuation \n16.Factorial \n17. Reapted_Element \n18.Array_PrimeNumber \n19.SubString \n20.EXIT");
            int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:


                        FriendList myFriendList = new FriendList();
                        Console.WriteLine("My Friends:");
                        string[] friends = myFriendList.GetFriends(); 
                        foreach (string friend in friends)
                        {
                            Console.WriteLine(friend);

                        }

                        break;

                    case 2:

                        Console.WriteLine("unique elements are");
                        Console.WriteLine("enter first number");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Square_of_Number c = new Square_of_Number(a, b);
                        break;

                    case 3:

                        Console.WriteLine(" ");
                        String_Conversion p = new String_Conversion();
                        break;

                    case 4:

                        
                        PlaceName processor = new PlaceName();
                        Console.Write("Enter a place name you would like to visit: ");
                        string inputPlace = Console.ReadLine();
                        processor.ProcessPlaceName(inputPlace);

                        break;

                    case 5:

                        Console.WriteLine(" ");
                        Average_Q6 average = new Average_Q6();
                        break;

                    case 6:

                        Console.Write("Enter the diameter of the circle: ");
                        double diameter = Convert.ToDouble(Console.ReadLine());

                        double perimeter = CircleCalculator.CalculatePerimeter(diameter);
                        double area = CircleCalculator.CalculateArea(diameter);

                        Console.WriteLine($"Perimeter of the circle: {perimeter}");
                        Console.WriteLine($"Area of the circle: {area}");

                        break;

                    case 7:

                        Console.Write("Input a year: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.Write("Input a month [1-12]: ");
                        int month = int.Parse(Console.ReadLine());

                        Console.Write("Input a day [1-31]: ");
                        int day = int.Parse(Console.ReadLine());

                        DateTime inputDate = new DateTime(year, month, day);
                        DateTime nextDay = inputDate.AddDays(1);

                        Console.WriteLine("The next date is [yyyy-MM-dd] " + nextDay.ToString("yyyy-MM-dd"));

                        break;

                    case 8:

                        Stop_Watch.stopwatch();
                        Console.WriteLine();
                        break;

                    case 9:

                        Console.WriteLine("welcome to the range of numbers ");
                        Range_of_Numbers r = new Range_of_Numbers();
                        break;

                    case 10:

                        Console.WriteLine(" ");
                        PersonName person = new PersonName();
                        break;

                    case 11:

                        print ab = new print();
                        Console.WriteLine();
                        break;

                     case 12:

                         Number_to_Strings n = new Number_to_Strings();
                         Console.WriteLine();
                         break;

                    case 13:

                        Present_Absent pa = new Present_Absent();
                        Console.WriteLine();
                        break;

                    case 14:

                        shifting_the_number s = new shifting_the_number();
                        Console.WriteLine();
                        break;

                    case 15:

                        Qyadratic_Equation Q = new Qyadratic_Equation();
                        Console.WriteLine();
                        break;

                    case 16:

                        Factorial F = new Factorial();
                        Console.WriteLine();    
                        break;

                    case 17:

                        RepeatedElement RE = new RepeatedElement();
                        Console.WriteLine();
                        break;

                    case 18:

                        Prime_Number pn = new Prime_Number();
                        Console.WriteLine();
                        break;

                    case 19:

                        SubString S = new SubString();
                        Console.WriteLine();
                        break;

                    case 20:

                        Console.WriteLine( "EXIT ");
                        break;






                }
            }
        }
        
    }
}
