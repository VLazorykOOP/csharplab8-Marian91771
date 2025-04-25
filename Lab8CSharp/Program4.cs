//using System;
//using System.IO;

//class Program4
//{
//    static void Main()
//    {
//        string filePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\fibonacci.bin";

//        Console.Write("Введіть кількість чисел Фібоначчі (n): ");
//        int n = int.Parse(Console.ReadLine());

//        // Створюємо і записуємо n чисел Фібоначчі у двійковий файл
//        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//        {
//            long a = 0, b = 1;
//            for (int i = 0; i < n; i++)
//            {
//                writer.Write(a);
//                long temp = a + b;
//                a = b;
//                b = temp;
//            }
//        }

//        Console.WriteLine("\nЧисла Фібоначчі з номерами, не кратними 3:");

//        // Зчитуємо числа з файлу і виводимо ті, які не кратні 3
//        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//        {
//            int index = 1;
//            while (reader.BaseStream.Position < reader.BaseStream.Length)
//            {
//                long value = reader.ReadInt64();
//                if (index % 3 != 0)
//                {
//                    Console.WriteLine($"{index}: {value}");
//                }
//                index++;
//            }
//        }
//    }
//}
