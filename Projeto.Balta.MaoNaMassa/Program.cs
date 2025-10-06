using System;

namespace Projeto.Balta.MaoNaMassa.ContentContext
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));


            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var course = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            course.Add(courseOOP);
            course.Add(courseCsharp);
            course.Add(courseAspNet);

            var carrers = new List<Career>();
            var carrerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var carrerItem3 = new CarrerItem(3, "Aprenda .NET", "", courseAspNet);
            var carrerItem = new CarrerItem(1, "Comece por aqui", "", courseCsharp);
            var carrerItem2 = new CarrerItem(2, "Aprenda OOP", "", courseOOP);
            carrerDotnet.Items.Add(carrerItem2);
            carrerDotnet.Items.Add(carrerItem3);
            carrerDotnet.Items.Add(carrerItem);
            carrers.Add(carrerDotnet);

            foreach (var carrer in carrers)
            {
                Console.WriteLine(carrer.Title);
                foreach (var item in carrer.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }
        }
    }
}