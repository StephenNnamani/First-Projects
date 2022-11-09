namespace IndexArray
{
    class Program
    {
        static void Main(string[] arg)
        {
            try
            {
                Console.WriteLine("Type in your word(s): ");
                var comment = "";
                comment = Console.ReadLine();
                int lengthOfWords = 0;

                char[] commentArray = new char[] {};
                if (comment != null)
                {
                    commentArray = comment.ToCharArray();
                    lengthOfWords = commentArray.Length;
                    Console.WriteLine(commentArray.Length);
                }

                foreach (char s in commentArray)
                {
                    bool isUpper = Char.IsUpper(s);
                    if (isUpper)
                    {
                        int position = Array.IndexOf(commentArray, s);
                        Console.WriteLine(position);
                    }
                    
                }

            }
            catch
            {
                Console.WriteLine("Error Occured");
            }

        }
    }
}
