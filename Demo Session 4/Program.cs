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
        }
    }
}
