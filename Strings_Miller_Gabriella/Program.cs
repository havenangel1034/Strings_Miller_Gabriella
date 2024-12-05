namespace Strings_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //requests the user to insert a character and assigns it to a variable
            Console.WriteLine("Hello, User. Would you please insert a character?");
            char myChar = Console.ReadKey().KeyChar;

            //checks if the user put in a letter
            bool isLetter = Char.IsLetter(myChar);

            //prints the results
            Console.WriteLine($"\n {myChar} is a letter: {isLetter}.");

            //asks a question and saves the users answer to the sentence variable
            Console.WriteLine("Why do you like writing, user?");
            string sentence = Console.ReadLine();

            //asks user to input a word and saves the answer to the word variable
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();

            //checks if the word is in the sentence
            bool isIn = sentence.Contains(word);

            //prints results
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");
            

        }
    }
}