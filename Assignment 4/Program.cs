namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //for (int i = 1; i <= value; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q2
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i * value);
            //}
            #endregion
            #region Q3
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //for (int i = 1; i < value; i++)
            //{
            //    if (i % 2 ==0)
            //    {
            //        Console.WriteLine($"Even : {i}");
            //    }
            //}
            #endregion
            #region Q4
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //Console.WriteLine("Please enter power: ");
            //int.TryParse(Console.ReadLine(), out int power);
            //int result = 1;
            //for (int i = 0; i < power; i++)
            //{
            //  result *= value;
            //}
            //Console.WriteLine(result);
            #endregion
            #region Q5
            //Console.WriteLine("Enter marks of five subjects :");
            //float subjects;
            //float sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //   float.TryParse(Console.ReadLine() , out subjects);
            //    sum+= subjects;
            //}
            //Console.WriteLine($"Total marks = {sum}");
            //Console.WriteLine($"Average Marks = {sum/5}");
            //Console.WriteLine($"Percentage ={(sum/500)*100}%");
            #endregion
            #region Q6
            //Console.WriteLine("Enter word to reverse :");
            //string word = Console.ReadLine() ?? "0";
            //string reversed = "";
            //for (int i = word.Length -1; i >=0 ; i--)
            //{
            //    reversed += word[i];
            //}
            //Console.WriteLine($"Reversed word: {reversed}");
            #endregion
            #region Q7
            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int numbers);
            //int reversed = 0;
            //while (numbers != 0)
            //{
            //    int number = numbers % 10;
            //    reversed = reversed * 10 + number;
            //    numbers /= 10;
            //}
            //Console.WriteLine($"Reversed number: {reversed}");
            #endregion
            #region Q8
            //Console.WriteLine("Enter starting number of ranges: ");
            //int.TryParse(Console.ReadLine(), out int start);
            //Console.WriteLine("Enter ending number of range : ");
            //int.TryParse(Console.ReadLine(), out int end);
            //Console.WriteLine($"Prime numbers between {start} and {end} are :");
            //    for (int num = start; num <= end; num++)
            //    {
            //        if (num <= 1)
            //            continue;

            //        bool isPrime = true;

            //        for (int i = 2; i < num; i++)
            //        {
            //            if (num % i == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.WriteLine(num);
            //        }
            //    }
            #endregion
            #region Q9
            //Console.Write("Enter a number to convert : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //int binary = 0;
            //int place = 1;
            //while (number > 0)
            //{
            //    int remainder = number % 2;
            //    binary = binary + (remainder * place);
            //    place *= 10;
            //    number /= 2;
            //}
            //Console.WriteLine($"Binary number: {binary}");
            #endregion
        }
    }
}
