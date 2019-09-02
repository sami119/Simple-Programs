using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTest
{
    public class Exercises
    {
        public void ExSeven()
        {
            try
            {
                uint num = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
                Console.ReadKey();
            }
        }

        public void ExEight()
        {
            int[] array = new int[10];
            try
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        ReadNumber(1, 100);
                    }
                    else
                    {
                        ReadNumber(array[i - 1], 100);
                    }
                    array[i] = readNumber;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int readNumber;

        public void ReadNumber(int start, int end)
        {
            readNumber = int.Parse(Console.ReadLine());
            if (readNumber < start || readNumber > end)
            {
                throw new ArgumentException("InvalidNumber");
            }
        }

        public string ExNine()
        {
            string fileName = Console.ReadLine();
            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    return reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                return $"Can not find file {fileName}.";
            }
            catch (DirectoryNotFoundException)
            {
                return $"Invalid directory in the file path.";
            }
            catch (IOException)
            {
                return $"Can not open the file {fileName}";
            }
        }

        public byte[] bytes;

        public void ExTen()
        {
            string fileName = Console.ReadLine();
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    bytes = new byte[fileStream.Length];
                    fileStream.Read(bytes, 0, (int)fileStream.Length);
                    memoryStream.Write(bytes, 0, (int)fileStream.Length);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Can not find file {fileName}.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.WriteLine($"Can not open the file {fileName}");
            }
        }
    }
}
