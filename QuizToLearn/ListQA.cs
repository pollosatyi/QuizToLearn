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

                ("5.Можно ли использовать git-flow без установки расширения? ","Можно в ручную создать ветки и управлять ими с помощью гит\n"),

                ("6.Как проинициализировать git-flow?","git flow init"),

                ("7.Какие ветки создаются при инициализации?","Две ветки получают названия\n"+
                                                                "main (или master) — стабильная ветка для релизов.\n"+
                                                               "develop — основная ветка для разработки.\n"+
                                                               "Остальные просто именуются.\n"+
                                                               "feature/ —  ветка фич.\n"+
                                                               "release/ — ветка релизов\n"+
                                                                "hotfix/ — ветка срочных исправлений.\n"),
                
                ("8.Что произойдёт, если репозиторий уже содержит другие ветки?","Если уже есть ветки то git flow init не повредит их\n"+
                                                                                 "Init настроит git flow,учитывая существующую структуру\n"+
                                                                                 "Если изначально были ветки main или developer\n"+ 
                                                                                 "они остаются вместо создания новых\n"+
                                                                                 "При отсутствии developer создается от main\n "+
                                                                                 "Если совпадают старые вспомогательные остаются\n"+ 
                                                                                  "а новые создаются с префиксом\n"),

                ("9.Почему develop должна быть защищена в CI/CD? ","Нужно поддерживать стабильность ветки develop\n "+
                                                                   "Все коммиты должны делаться через merge/pullRequests\n "+
                                                                   "Это снижает риск поломанного коммита и делает историю измений контролируемой\n"+
                                                                   "иначе весь процесс теряет смысл\n"),

                ("10.Как начать фичу?","Переключится на develop git checkout develop\n"+
                                       "Убедиться что локальная вумудщз соответсвует удаленной git pull origin develop\n"+
                                       "Создать новую фичу ветку и перейти на неё git checkout -b feature/new-feature-name\n"+
                                       "Добавить код и сделать коммит git add . git commit -m\n"+
                                       "Снова проверить обновления из develop git pull origin develop\n"+
                                       "Запушить ветку и открыть Merge/PullRequests  git push origin feature/newFeature\n"+
                                       "Затем зайти в git host и запросить слияние\n"+
                                       "После удачного слияния удаляем ветку локально: git branch -d feature/newFeature\n "+
                                       "и на удаленном сервере git push origin --delete feature/newFeature\n"),

                ("11. Что делает feature finish?","Код из feature/NewFeature, объединяется с develop через merge/pullRequests\n"+
                                                   "Удаляется ветка локально и удаленно\n"),

                ("12.Что произойдёт при feature finish, если есть незакоммиченные изменения?","выйдет ошибка. Можно сделать коммит \n"+
                                                             "git commit -m\n"+
                                                             "Или сделать временные сохраненее\n"+
                                                             "git stash\n"+
                                                             "git flow finish feature/newFeature\n"+
                                                             "git pop - возвращение изменений\n"+
                                                             "можно удалить изменения\n"+
                                                             "git reset --hard\n"),

                ("13.Как работать с фичей вдвоём?","один разработчик создает feature\n"+
                                                "git flow feature start newFeature\n"+
                                                "Пушим ветку на сервер\n"+
                                                "git push -u origin feature newFeature\n"+
                                                "второй разработчик получает актуальные ветки\n"+
                                                "git fetch --all\n"+
                                                "переходим на feature\n"+
                                                "git checkout feature\n"+
                                                "подтягиваем последние изменения\n"+
                                                "git pull origin feature\n"),

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
