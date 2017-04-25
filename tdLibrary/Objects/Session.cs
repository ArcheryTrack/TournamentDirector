using System;

namespace TournamentDirector.Library.Objects
{
    public class Session : AbstractObject
    {
        public DateTime Date { get; set; }

        public int Order { get; set; }

        public int BalesPerSession { get; set; }

        public int ArchersPerBale { get; set; }

         
    }
}
