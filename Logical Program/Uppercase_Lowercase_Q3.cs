using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class PlaceName
    {
       
            public void ProcessPlaceName(string placeName)
            {
                // Convert the input to uppercase and store it in a new variable
                string placeInUppercase = placeName.ToUpper();

                // Display the place name in uppercase
                Console.WriteLine($"Place in Uppercase: {placeInUppercase}");

                // Convert the input to lowercase and store it in a new variable
                string placeInLowercase = placeName.ToLower();

                // Display the place name in lowercase
                Console.WriteLine($"Place in Lowercase: {placeInLowercase}");
            }
        
    }
}
