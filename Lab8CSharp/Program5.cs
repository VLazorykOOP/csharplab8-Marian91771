//using System;
//using System.IO;

//class Program5
//{
//    static void Main()
//    {
//        string basePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\temp";

//        // 1. Створення папок vybyranyi1 і vybyranyi2
//        string dir1 = Path.Combine(basePath, "vybyranyi1");
//        string dir2 = Path.Combine(basePath, "vybyranyi2");

//        Directory.CreateDirectory(dir1);
//        Directory.CreateDirectory(dir2);

//        // 2. Створення файлів t1.txt і t2.txt у vybyranyi1
//        string file1 = Path.Combine(dir1, "t1.txt");
//        string file2 = Path.Combine(dir1, "t2.txt");

//        File.WriteAllText(file1, "Вибираний Мар'ян Вячеславович 2006 року народження, місце проживання м Тернопіль");
//        File.WriteAllText(file2, "Кривий Андрій Васильович, 2004 року народження, місце проживання с Гусятин");

//        // 3. Створення файлу t3.txt у vybyranyi2, об’єднання вмісту t1.txt і t2.txt
//        string file3 = Path.Combine(dir2, "t3.txt");
//        string combinedText = File.ReadAllText(file1) + "\n" + File.ReadAllText(file2);
//        File.WriteAllText(file3, combinedText);

//        // 4. Вивід інформації про файли
//        Console.WriteLine("Інформація про створені файли:");
//        PrintFileInfo(file1);
//        PrintFileInfo(file2);
//        PrintFileInfo(file3);

//        // 5. Перемістити t2.txt у vybyranyi2
//        string newFile2 = Path.Combine(dir2, "t2.txt");
//        File.Move(file2, newFile2);

//        // 6. Копіювати t1.txt у vybyranyi2
//        string copiedFile1 = Path.Combine(dir2, "t1.txt");
//        File.Copy(file1, copiedFile1);

//        // 7. Перейменувати vybyranyi2 → ALL, vybyranyi1 видалити
//        string allDir = Path.Combine(basePath, "ALL");
//        Directory.Move(dir2, allDir);
//        Directory.Delete(dir1, true);

//        // 8. Вивести повну інформацію про файли в папці ALL
//        Console.WriteLine("\nІнформація про файли в папці ALL:");
//        foreach (string file in Directory.GetFiles(allDir))
//        {
//            PrintFileInfo(file);
//        }
//    }

//    static void PrintFileInfo(string filePath)
//    {
//        FileInfo fi = new FileInfo(filePath);
//        Console.WriteLine($"Файл: {fi.Name}");
//        Console.WriteLine($"   Повний шлях: {fi.FullName}");
//        Console.WriteLine($"   Розмір: {fi.Length} байт");
//        Console.WriteLine($"   Створено: {fi.CreationTime}");
//        Console.WriteLine($"   Останній доступ: {fi.LastAccessTime}");
//        Console.WriteLine($"   Останнє редагування: {fi.LastWriteTime}");
//        Console.WriteLine();
//    }
//}
