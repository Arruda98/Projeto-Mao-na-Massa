<<<<<<< HEAD
namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
=======
namespace Projeto.Balta.MaoNaMassa.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
>>>>>>> 17bb7a8 (Continuidade nos estudos em POO)
}