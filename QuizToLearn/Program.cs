namespace QuizToLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поехали");
            ListQA list=new ListQA();
            while (true)
            {

                list.PrintQA();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
