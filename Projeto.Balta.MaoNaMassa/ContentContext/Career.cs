<<<<<<< HEAD
namespace Balta.ContentContext
{
    public class Career : Content
    {
        public int Courses { get; set; }
    }
=======
namespace Projeto.Balta.MaoNaMassa.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            :base(title, url)
        {
            Items = new List<CarrerItem>();
        }
        public IList<CarrerItem> Items { get; set; }
        public int TotalCourses { get 
            {
                return Items.Count;   
            } 
        }
    }
>>>>>>> 17bb7a8 (Continuidade nos estudos em POO)
}