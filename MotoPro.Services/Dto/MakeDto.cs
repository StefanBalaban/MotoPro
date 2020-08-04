using System.Collections.Generic;

namespace MotoPro.Services.Dto
{
    public class MakeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ModelDto> Models { get; set; }
    }
}
