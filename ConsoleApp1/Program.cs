namespace Embedded_Sorting;
internal class Program
{
    static void Main(string[] args)
    {
        SortByNumber(args);
    }

    static void SortByNumber(string[] args)
    {
        var correctOrder = new List<string>();
        var numsAsStrings = new string[9];

        for (int i = 0; i < numsAsStrings.Length; i++)
        {
            numsAsStrings[i] = $"{i}";
        }

        correctOrder = (from numStr in numsAsStrings
            from arg in args
            where arg.Contains(numStr)
            select arg).ToList();
        
        correctOrder.ForEach(x => Console.Write($"{x}; "));
    }
}   