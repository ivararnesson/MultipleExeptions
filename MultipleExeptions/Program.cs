using System;

public class Program
{
    static void Main()
    {
        HandleMultipleExeptions("1", 10);
    }
    static void HandleMultipleExeptions(string parseValue, int index)
    {
        try
        {
            int parsedValue = ParseStringToInt(parseValue);
            Console.WriteLine(parsedValue);

            int indexResult = FindArrayElementAtIndex(index);
            Console.WriteLine(indexResult);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static int ParseStringToInt(string str)
    {
        if (!int.TryParse(str, out var result))
        {
            throw new FormatException($"{str} is invalid format");
        }
        return result;
    }
    static int FindArrayElementAtIndex(int index)
    {
        int[] numbers = { 10, 123, 32, 54 };
        if (index < 0 || index >= numbers.Length)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
        return numbers[index];
    }
}

