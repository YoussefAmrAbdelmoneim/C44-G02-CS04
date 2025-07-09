namespace Demo_Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01
            //object number = 5.2;
            #region Ex1 [Pattern Matching on Types]
            //switch (number)
            //{
            //    case int value:
            //        Console.WriteLine("Integer");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;
            //    case double value:
            //        Console.WriteLine("Double");
            //        break;
            //    default:
            //        Console.WriteLine("No Matching");
            //        break;
            //}
            #endregion
            #region EX2 [Case Guards [When]]
            //switch (number)
            //{
            //    case int value when value <10:
            //        Console.WriteLine("Integer is less than 10");
            //        break;
            //    case int value when value > 10:
            //        Console.WriteLine("Integer is more than 10");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;
            //    case double value when value > 5.5 && value < 10.10:
            //        Console.WriteLine("Double is between 5.5 and 10.10");
            //        break;
            //    default:
            //        Console.WriteLine("No Matching");
            //        break;
            //}
            #endregion
            #region EX3 [User Defined Data Type]
            //object input = 60;
            //input = new Person(Id = 1, Name = "Omar", Age = 25);
            //switch(input) {
            //    case int value when value >10:
            //        Console.WriteLine("Int greater than 10");
            //        break;
            //    case string value:
            //        Console.WriteLine("String");
            //        break;
            //    case Person value when value.Id == 1 && value.Name == "Omar":
            //        Console.WriteLine("Person");
            //        break;
            //    default:
            //        Console.WriteLine("No Matching");
            //        break;
            #endregion
            #endregion
            #region Video 02
            #region Ex1 Pattern matching without alias name
            //object number = 5.6;
            //switch (number)
            //{
            //    case int:
            //        Console.WriteLine("Int");
            //        break;
            //    case decimal:
            //        Console.WriteLine("Decimal");
            //         break;
            //    case double when (double) number >5.5 && (double) number <10.10:
            //        Console.WriteLine("Double");
            //        break;
            //}
            #endregion
            #region Ex2 Switch expression
            //Console.WriteLine("Enter Your number:");
            //string option = Console.ReadLine() ?? "0";
            //string message;
            //message = option switch
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3",
            //    _ => "Invalid Option"
            //};
            //Console.WriteLine(message);
            #endregion
            #region Ex3 Property pattern
            //Person person = new Person() { Id = 10, Name = "Omar", Age = 25 };
            //string message = person switch
            //{
            //    {Name:"Ahmed",Age:10} => "Hello Ahmed",
            //    {Name:"Omar"} => "Hello Omar",
            //    { Id:50} =>"Hello person with Id = 20",
            //    _ => "Sorry we don't know you"
            //};
            #endregion
            #region Ex4 Nullable Type
            //int? number = 10;
            //string Result = number switch
            //{
            //    null => "Nullable Type",
            //    int x when x >0 => "Positive number",
            //    int x when x < 0 => "Negative number",
            //     0 => "Zero"
            //};
            #endregion
            #endregion
            #region Video 03
            #region Ex1 Relational Patterns
            //int number = 20;
            //string result = number switch
            //{
            //    <10 => "Less than 10",
            //    >=10 and <=20 => "Number is between 10 and 20",
            //    >20 => "Number is greater than 20"
            //};
            //Console.WriteLine(result);
            #endregion
            #region Ex2 Logical Patterns
            //int number = 10;
            //string result = number switch
            //{
            //    >0 and <10 => "Number is between 1 and 9",
            //    >= 10 and <= 20 => "Number is between 10 and 20",
            //    > 0 => "Number is 0",
            //    > 20 or < 0 => "Number is outside the range"
            //};
            //Console.WriteLine(result);
            #endregion
            #region Ex3 Enhanced Property matching
            //Person person = new Person() { Id = 10, Name = "Omar", Age = 25 };
            //string result = person switch
            //{
            //    { Name: "Samy", Age: 10 } => "Hello Samy",
            //    { Name: "Omar" , Age: >=20 and <=24 } => "Hello Omar",
            //    { Age: >50 and <60 } => "Hello old man",
            //    _ => "Sorry we don't know you"
            //};
            #endregion
            #endregion
            #region Video 04
            #region For - Foreach
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    numbers[i] += 10; //valid
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach (int item in numbers)
            //{
            //    item += 10 //invalid
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region Video 05
            #region do-while
            //bool isParsed;
            //int number;
            //do
            //{
            //    Console.WriteLine("Please enter an even number : ");   
            //    isParsed = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!isParsed || number %2==1);
            //Console.WriteLine($"{number} is an even number");
            #endregion
            #region While
            // int number;
            // Console.WriteLine("Enter a number :");
            //bool isParsed = int.TryParse(Console.ReadLine(), out number);
            // if (isParsed)
            // {
            //     while (number <=10)
            //     {
            //       Console.WriteLine(number);
            //         number++;
            //     }
            // }
            #endregion
            #endregion
            #region Video 06
            #region Ex1
            //string name;
            //name = new string("Route");
            //Console.WriteLine($"Name {name}");
            //Console.WriteLine($"HashCode Name {name.GetHashCode()}");
            //string name02 = "Route";
            //Console.WriteLine($"name02 {name02}");
            #endregion
            #region Ex2
            //string name01 = "Amr";
            //string name02 = "May";
            //Console.WriteLine($"Name01 : {name01}");
            //Console.WriteLine($"HashCode Name {name01.GetHashCode()}");
            //Console.WriteLine($"Name01 : {name02}");
            //Console.WriteLine($"HashCode Name {name02.GetHashCode()}");
            #endregion
            #region Ex3
            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //message + = "Route";
            //Console.WriteLine("After changing in Message");
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            #endregion
            #region string methods
            string message = " Hello Route";
            //Console.WriteLine(message.Length);
            //Console.WriteLine(message.ToUpper());
            //Console.WriteLine(message.ToLower());
            //Console.WriteLine(message.Trim());
            //Console.WriteLine(message.TrimEnd());
            //Console.WriteLine(message.TrimStart());
            //Console.WriteLine(message.Substring(0,5));
            //Console.WriteLine(message.Replace('e','M'));
            //Console.WriteLine(message.Contains('o'));
            #endregion
            #endregion
        }
    }
}
