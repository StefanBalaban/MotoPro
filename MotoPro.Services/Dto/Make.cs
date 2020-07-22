using System.Collections.Generic;

namespace MotoPro.Services.Dto
{
    public class Make
    {
        public Make()
        {
            Name = "Nejm";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Model> Models { get; set; }
    }
}
