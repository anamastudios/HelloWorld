using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        int letterCount;
        string World;
        string output
        {
            get { return World; }
            set { World = value; }
        }
        static void Main(string[] args)
        {
            var Hello = new Program();
            Hello.text();

            Console.WriteLine(Hello.World);
            Console.ReadKey();
        }
        void text()
        {
            var icecream = new FileStuff();
            char[] letters = {'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd'};
            foreach (char c in letters)
            {
                letterCount++;
            }
            icecream.WriteStuff(letterCount, letters);
            icecream.ReadStuff(letterCount);
            output = icecream.getOutput();
            icecream.DeleteStuff(letterCount);
        }
    }
    public class FileStuff
    {
        string output = String.Empty;

        public void WriteStuff(int letters, char[] letter)
        {
            for (int i = 0; i < letters; i++)
            {
                var writer = new StreamWriter(i.ToString() + ".txt");
                writer.Write(letter[i].ToString());
                writer.Close();
            }
        }
        public void ReadStuff(int letters)
        {
            var outer = new Program();
            string Word = String.Empty;

            for (int i = 0; i < letters; i++)
            {
                var reader = new StreamReader(i.ToString() + ".txt");
                Word = Word + reader.ReadLine();
                reader.Close();
            }
            output = Word;
        }
        public string getOutput()
        {
            return output;
        }
        public void DeleteStuff(int letters)
        {
            for (int i = 0; i < letters; i++)
            {
                File.Delete(i.ToString() + ".txt");
            }
        }
    }
}
 