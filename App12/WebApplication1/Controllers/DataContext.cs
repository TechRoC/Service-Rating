using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    internal class DataContext
    {
        public DataContext()
        {
        }

        public IEnumerable<object> FeedbackDatabase { get; internal set; }
    }
}