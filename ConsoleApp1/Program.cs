namespace Embedded_Sorting;
internal class Program
{
    static void Main(string[] args)
    {
        SortByNumber(args);
    }

    static void SortByNumber(string[] args)
    {
        List<string> correctOrder = new();
        var nums = new string[9];
        for (int i = 0; i < nums.Length; i++)
            nums[i] = $"{i}";
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < args.Length; j++)
            {
                if (args[j].Contains(nums[i])) correctOrder.Add(args[j]);
            }
        }
        
        correctOrder.ForEach(x => Console.Write($"{x}; "));
    }
}   