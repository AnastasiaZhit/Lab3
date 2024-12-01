
public interface IOperation
{
    string GetOperationName();
    string GetOperationSign();
    int Operation(int a, int b);
}

public class Plus : IOperation
{
    public string GetOperationName() => "Сложение";
    public string GetOperationSign() => "+";
    public int Operation(int a, int b)
    {
        return a + b;
    }
}

public class Minus : IOperation
{
    public string GetOperationName() => "Вычитание";

    public string GetOperationSign() => "-";

    public int Operation(int a, int b)
    {
        return a - b;
    }
}

public class Multiplication : IOperation
{
    public string GetOperationName() => "Умножение";

    public string GetOperationSign() => "*";

    public int Operation(int a, int b)
    {
        return a * b;
    }
}

public class MAX : IOperation
{
    public string GetOperationName() => "Максимум";

    public string GetOperationSign() => "MAX";

    public int Operation(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите одну из представленных операций +, -, *, MAX: ");
            string operation = Console.ReadLine();
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (operation == "+")
            {
                Plus result = new Plus();
                Console.Write($"Название операции: {result.GetOperationName()}\n" +
                    $"Знак операции: {result.GetOperationSign()}\n" +
                    $"Результат операции: {result.Operation(a, b)}\n");
            }
            else if (operation == "-")
            {
                Minus result = new Minus();
                Console.Write($"Название операции: {result.GetOperationName()}\n" +
                    $"Знак операции: {result.GetOperationSign()}\n" +
                    $"Результат операции: {result.Operation(a, b)}\n");
            }
            else if (operation == "*")
            {
                Multiplication result = new Multiplication();
                Console.Write($"Название операции: {result.GetOperationName()}\n" +
                    $"Знак операции: {result.GetOperationSign()}\n" +
                    $"Результат операции: {result.Operation(a, b)}\n");
            }
            else if (operation == "MAX")
            {
                MAX result = new MAX();
                Console.Write($"Название операции: {result.GetOperationName()}\n" +
                    $"Знак операции: {result.GetOperationSign()}\n" +
                    $"Результат операции: {result.Operation(a, b)}\n");
            }
            else
            {
                Console.WriteLine("Выбрана неверная операция, повторите попытку.");
            }
        }
    }
}