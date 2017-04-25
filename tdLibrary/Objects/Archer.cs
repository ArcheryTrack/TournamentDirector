using System;
using TournamentDirector.Library.Enums;

namespace TournamentDirector.Library.Objects
{
    public class Archer : AbstractObject
    {
        public string DivisionCode { get; set; }

        public string AgeClassCode { get; set; }

        public string ClassCode { get; set; }

        public string Bib { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string CountryCode { get; set; }

        public string CountryDescription { get; set; }
    }
}
