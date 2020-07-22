using System.Collections.Generic;

namespace MotoPro.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Model> Models { get; set; }
    }
}
