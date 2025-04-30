using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizToLearn
{
    internal class ListQA
    {
        public List<(string, string)> listQA { get; set; }
        public ListQA()
        {
            listQA = new List<(string, string)>()
            {
                ("Что такое git-flow?"," это модель ветвления для Git, которая предлагает стандартизированный подход к управлению ветками в проекте.\n"+
                                          "Основные ветки в Git-flow:\n"+
                                           "master. В нем стабильный код. Хранит в себе версии релизов \n"+
                                           "develop. Основная ветка для разработки.В нее сливаются все ветки feature и из нее создаются release ветки\n"+
                                           "feature.Создаются  от develop и сливаются в develop.\n "+
                                            "release. Создаются от develop.Тестирование и документация. Сливается в master и develop\n"+
                                            "hotfix. Создаются для исправления багов. Сливаются в master и develop")
            };
        }

        public int GetNumber()
        {
            Random random = new Random();
            return random.Next(0,listQA.Count-1);
        }

        public void PrintQA()
        {
            int number=GetNumber();
            Console.WriteLine($"Вопрос номер {number}");
            Console.WriteLine(listQA[number].Item1);
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine($"Ответ номер {number}");
            Console.WriteLine(listQA[number].Item2);
            Console.WriteLine("\n");

        }
    }
}
