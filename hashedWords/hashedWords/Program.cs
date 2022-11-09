namespace HashedWords
{
    class Program
    {
        static void Main(string[] arg)
        {
            try
            {
                Console.WriteLine("Type in your word(s)");
                var words = Convert.ToString(Console.ReadLine());
                int hashedLength = 0;
                if (words != null)
                {
                    hashedLength = words.Length - 4;
                }

                string lastFourWords = "";
                string hash = "#";
                if (words != null)
                {
                    lastFourWords = words.Remove(0, hashedLength);
                }


                for (int i = 0; i < hashedLength; i++)
                {
                    Console.Write(hash);
                }
                Console.Write(lastFourWords);
            }
            catch
            {
                Console.WriteLine("You types a word less than four characters");
            }

        }
    }
}
