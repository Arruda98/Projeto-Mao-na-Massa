using Projeto.Balta.MaoNaMassa.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Balta.MaoNaMassa.ContentContext
{
    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}
