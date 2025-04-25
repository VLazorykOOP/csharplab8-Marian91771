//using System;
//using System.IO;
//using System.Text.RegularExpressions;

//class Program2
//{
//    static void Main()
//    {
//        string inputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\input2.txt";
//        string outputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\output2.txt";

//        // Читання всього тексту з файлу
//        string inputText = File.ReadAllText(inputFilePath);

//        // Регулярний вираз для пошуку слів, які треба видалити:
//        // 1. Однобуквені слова (наприклад "a", "I")
//        // 2. Слова, що починаються на 'a', 'b', 'c', 'd' або 'e'
//        string pattern = @"\b[a-eA-E]\b|\b[a-eA-E]\w*\b";

//        // Видалення цих слів з тексту
//        string resultText = Regex.Replace(inputText, pattern, string.Empty);

//        // Очищення зайвих пробілів після видалення слів
//        resultText = Regex.Replace(resultText, @"\s+", " ").Trim();

//        // Запис результату в новий файл
//        File.WriteAllText(outputFilePath, resultText);

//        Console.WriteLine($"Результат записано в файл {outputFilePath}.");
//    }
//}
