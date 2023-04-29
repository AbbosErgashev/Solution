using Solution.Models;

namespace Solution.Dtos.CommandDtos
{
    public class CommandReadDto : Base
    {
        public string HowTo { get; set; }

        public string Platform { get; set; }

        public string CommandLine { get; set; }
    }
}