using System.IO;
void TextWrite()
{
    Console.WriteLine("Write how much words do you need");
    int wordsToRead = Convert.ToInt32(Console.ReadLine());
    try
    {
        string content = File.ReadAllText("E:\\repos\\c#\\RAWILab1\\RAWILab1\\LoremIpsum.txt");
        string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < wordsToRead && i < words.Length; i++)
        {
            Console.Write(words[i] + " ");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}
void MathAction()
{
    Console.WriteLine("Write first number");
    int numb1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write second number");
    int numb2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choose action:");
    Console.WriteLine("Write + for addition");
    Console.WriteLine("Write - for subtraction");
    Console.WriteLine("Write * for multiplication");
    Console.WriteLine("Write / for division");
    char action = Convert.ToChar(Console.ReadLine());
    switch (action)
    {
        case '+':
            Console.WriteLine(numb1 + numb2);
            break;
        case '-':
            Console.WriteLine(numb1 - numb2);
            break;
        case '*':
            Console.WriteLine(numb1 * numb2);
            break;
        case '/':
            Console.WriteLine(numb1 / numb2);
            break;
        default: 
            Console.WriteLine("Wrong"); 
            break;
    }
}
void Main()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Choose option:");
        Console.WriteLine("1. Words in 'Lorem ipsum'");
        Console.WriteLine("2. Math action");
        Console.WriteLine("3. EXIT");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    TextWrite();
                    break;
                case 2:
                    MathAction();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Wrong choice.");
        }
        Console.WriteLine("\nEnter for continue...");
        Console.ReadLine();
    }
}
Main();