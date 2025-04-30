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
                                            "hotfix. Создаются для исправления багов. Сливаются в master и develop"),

                ("Чем git-flow отличается от trunk-based development?","это методология разработки, при которой вся команда работает в одной основной ветке (trunk или main)\n" +
                                                                        ", а изменения интегрируются как можно чаще (в идеале — несколько раз в день).\n" +
                                                                        " Это противоположность Git-flow, где используется множество долгоживущих веток."),

                ("Почему git-flow может тормозить команды, работающие по Scrum?","В Git-flow фичи разрабатываются в изоляции, а мержатся в develop только после полной готовности.\n" +
                                                                                  
                                                                                  "У Scrum принцип работющий код каждый спринт\n"+
                                                                                  "Из за этого нельзя эффективно проводить merge и тестирование ")
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
