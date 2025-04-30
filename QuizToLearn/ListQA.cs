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
                ("0. Что такое git-flow?"," это модель ветвления для Git, которая предлагает стандартизированный подход к управлению ветками в проекте.\n"+
                                          "Основные ветки в Git-flow:\n"+
                                           "master. В нем стабильный код. Хранит в себе версии релизов \n"+
                                           "develop. Основная ветка для разработки.В нее сливаются все ветки feature и из нее создаются release ветки\n"+
                                           "feature.Создаются  от develop и сливаются в develop.\n "+
                                            "release. Создаются от develop.Тестирование и документация. Сливается в master и develop\n"+
                                            "hotfix. Создаются для исправления багов. Сливаются в master и develop"),

                ("1. Чем git-flow отличается от trunk-based development?","это методология разработки, при которой вся команда работает в одной основной ветке (trunk или main)\n" +
                                                                        ", а изменения интегрируются как можно чаще (в идеале — несколько раз в день).\n" +
                                                                        " Это противоположность Git-flow, где используется множество долгоживущих веток."),

                ("2. Почему git-flow может тормозить команды, работающие по Scrum?","В Git-flow фичи разрабатываются в изоляции, а мержатся в develop только после полной готовности.\n" +
                                                                                  "merge часто происходит в ручную из за большого обьема кода\n "+
                                                                                  "У Scrum принцип \"работющий код каждый спринт\"\n"+
                                                                                  "Что подразумевает частный и простой merge "),

                ("3. Как установить git-flow на macOS через brew?","Проверить через терминал установлен и обновлен Homebrew\n" +
                                                                 " в терминале brew install git-flow.\n"),

                ("4. Как проверить, установлен ли git-flow и его версия?","which git-flow выдает путь где установлен git-flow\n"+
                                                                           "git-flow version выдает версию"  ),

                ("5.Можно ли использовать git-flow без установки расширения? ","Можно в ручную создать ветки и упралять ими с помощью гит\n. "),

                ("6.Как проинициализировать git-flow?","git flow init"),

                ("7.Какие ветки создаются при инициализации?","main (или master) — стабильная ветка для релизов.\n"+
                                                               "develop — основная ветка для разработки.\n"+
                                                               "feature/ — префикс для веток фич.\n"+
                                                               "release/ — префикс для веток релизов\n"+
                                                                "hotfix/ — префикс для срочных исправлений.\n"),
                
                ("8.Что произойдёт, если репозиторий уже содержит другие ветки?","Если в репозитории есть ветки то git flow init не повредит их"+
                                                                                 "Она просто настроит git flow,учитывая существующую структуру"+
                                                                                 "Если изначально были ветки main или developer они остаются вместо создания новых"+
                                                                                 "При отсутствии developer создается от main "+
                                                                                 "Если совпадают старые остаются а новые создаются с префиксом"),

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
