using System;
using TournamentDirector.Library.Enums;

namespace TournamentDirector.Library.Objects
{
    public class ArcherSession
    {
        public Guid ArcherId { get; set; }

        public Guid SessionId { get; set; }

        public int Bale { get; set; }

        public TargetPosition TargetPosition { get; set; }
    }
}
