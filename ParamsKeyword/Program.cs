
class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        double average = CalculateAverage(numbers);

        Console.WriteLine(average);

        /*Before C# 13
        double CalculateAverage(params int[] numbers)
        {
            return numbers.Average();
        }

        New to C# 13
        double CalculateAverage(params List<int> numbers)
        {
            return numbers.Average();
        }*/

        //Flexibiity
        double CalculateAverage(params HashSet<int> numbers)
        {
            return numbers.Average();
        }
    }
}
