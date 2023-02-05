using System.Text.RegularExpressions;

namespace _3_Modul.Regex_3_Lesson.Regex_Examples;

/*
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - one or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - New line
 * \d - Digit
 * \D - Non-digit
 * \s - White space
 * \S - non-white space
 * \w - alphanumeric/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x|y) - Alternative - x or y
 * 
 * [^x] - Anything but x (where x is whatever character you want)
 */
internal class MyRegexExamples
{
    public static void Start()
    {
        Console.WriteLine("Matnni kiriting:");
        string InputString = Console.ReadLine() ?? "";

        ////Enter character which exists between a-g ?
        //Console.Write("Enter character which exists between a-g ? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "[a-g]"));

        ////Enter characters between[a - g] with length of 3 ?
        //Console.Write("Enter characters between[a - g] with length of 3 ? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "[a-g]{3}"));

        ////Enter characters between[a - g] with maximum 3 characters and minimum 1 character?
        //Console.Write("Enter characters between[a - g] with maximum 3 characters and minimum 1 character? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "[a-g]{1,3}"));

        ////How can | validate data with 8 digit fix numeric format like 91230456, 01237648 etc?
        //Console.Write("How can | validate data with 8 digit fix numeric format like 91230456, 01237648 etc? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "^[0-9]{8}$"));

        ////How to validate numeric data with minimum length of 3 and maximum of 7, ex - 123,
        ////1274667, 87654 ?
        //Console.Write(" : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "[0-9]{3,7}$"));

        ////Validate invoice numbers which have formats like LJI1020, the first 3 characters are
        ////alphabets and remaining is 8 length number?
        //Console.Write("Validate invoice numbers which have formats like LJI1020, the first 3 characters are alphabets and remaining is 8 length number?: ");
        //Console.WriteLine(Regex.IsMatch(InputString, "^[a-zA-Z]{3}[0-9]{8}$"));

        ////Check for format INV190203 or inv820830, with first 3 characters alphabets case
        ////insensitive and remaining 8 length numeric ?
        //Console.Write("Check for format INV190203 or inv820830, with first 3 characters alphabets case insensitive and remaining 8 length numeric ? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "^[a-zA-Z]{3}[0-9]{8}$"));

        ////Can we see a simple validation for website URL's?
        //Console.Write("Can we see a simple validation for website URL's? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "^www.[0-9a-zA-Z]{1,50}.(com|org|in)$"));

        ////Any character except hello ?
        //Console.Write("Any character except hello ? : ");
        //Console.WriteLine(Regex.IsMatch(InputString, "^hello"));



        //string pattern = @"(\s|^)(T|t)im(\s|$)";
        //string toSearch = "Tim Corey";

        //Console.WriteLine("Tom Corey: " + Regex.IsMatch("Tim Corey", pattern));
        //Console.WriteLine("Timothy Corey: " + Regex.IsMatch("Timothy Corey", pattern));
        //Console.WriteLine("Always Tim: " + Regex.IsMatch("Always Tim", pattern));
        //Console.WriteLine("I Am Tim Corey: " + Regex.IsMatch("I Am Tim Corey", pattern));


        // (440) 555-1212
        // 12-34567890
        // 123 87876

        // string toSearch = File.ReadAllText("test.txt");

        // This pattern matches phone numbers in the following patterns
        //string pattern = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

        //MatchCollection matches = Regex.Matches(toSearch, pattern);

        //foreach (Match match in matches)
        //{
        //    Console.WriteLine(match.Value);
        //}


        //Stopwatch stopwatch = new();

        //stopwatch.Start();
        //Regex test = new Regex(pattern);

        //for (int i = 0; i < 100000; i++)
        //{
        //    //Regex.IsMatch("I Am Tim Corey", pattern);
        //    test.IsMatch("I Am Tim Corey");
        //}

        //stopwatch.Stop();

        //Console.WriteLine($"Time Elapsed in ms: {stopwatch.ElapsedMilliseconds}");
    }
}

