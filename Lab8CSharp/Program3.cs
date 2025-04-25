//using System;
//using System.IO;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;

//class Program3
//{
//    static void Main()
//    {
//        string inputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\input3.txt";
//        string outputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\output3.txt";

//        // Зчитування вхідного тексту
//        string inputText = File.ReadAllText(inputFilePath);

//        // Виділення слів (без розділових знаків)
//        MatchCollection matches = Regex.Matches(inputText, @"\b\w+\b");

//        List<string> palindromes = new List<string>();

//        foreach (Match match in matches)
//        {
//            string word = match.Value;
//            if (IsPalindrome(word))
//            {
//                palindromes.Add(word);
//            }
//        }

//        // Запис результату у вихідний файл
//        File.WriteAllLines(outputFilePath, palindromes);

//        Console.WriteLine($"Знайдено {palindromes.Count} симетричних слів. Результат записано в {outputFilePath}.");
//    }

//    // Метод для перевірки чи слово паліндром
//    static bool IsPalindrome(string word)
//    {
//        word = word.ToLower(); // Робимо перевірку нечутливою до регістру
//        int len = word.Length;
//        for (int i = 0; i < len / 2; i++)
//        {
//            if (word[i] != word[len - i - 1])
//                return false;
//        }
//        return true;
//    }
//}
