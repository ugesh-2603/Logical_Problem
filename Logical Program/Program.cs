namespace Logical_Program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Display_5_friend_name \n2.Square_of_Numbers \n3.String_Conversion \n4. Uppercase_Lowercase \n5. Average \n6. AreaofCircle \n7. Date_and_Time \n8. StopWatch\n9.Sum_of_row");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:


                    FriendList myFriendList = new FriendList(); // instance of friendslist
                    Console.WriteLine("My Friends:");
                    string[] friends = myFriendList.GetFriends(); // call getfriend
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

                    String_Conversion s = new String_Conversion();
                      Console.WriteLine();
                      break;

                case 4:

                    // Create an instance of the PlaceNameProcessor class
                    PlaceName processor = new PlaceName();

                    // Prompt the user to enter a place name
                    Console.Write("Enter a place name you would like to visit: ");

                    // Read the user's input and store it in a variable
                    string inputPlace = Console.ReadLine();

                    // Call the ProcessPlaceName method to display the place name in both cases
                    processor.ProcessPlaceName(inputPlace);

                    break;

              /*  case 5:

                    Console.WriteLine("unique elements are");
                    Console.WriteLine("enter first number");
                    int sum = 0;
                    foreach (int number in numbers)
                    {
                        sum += number;
                    }
                    double average = (double)sum / numbers.Length;

                    Average_Q6 average_Q6 = new Average_Q6( );

                    break;*/

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


            }
        }
        
    }
}
