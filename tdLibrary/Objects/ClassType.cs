using System.Collections.Generic;
using TournamentDirector.Library.Enums;

namespace TournamentDirector.Library.Objects
{
    public class ClassType : AbstractObject
    {
        public string Code { get; set; }

        public Gender Gender { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public int AgeStart { get; set; }

        public int AgeEnd { get; set; }

        public List<string> ValidClasses { get; set; }

        public List<string> AllowedDivisions { get; set; }
    }
}
