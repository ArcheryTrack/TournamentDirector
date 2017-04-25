using System;
using System.Collections.Generic;
using TournamentDirector.Library.Objects;

namespace TournamentDirector.Library.Interfaces
{
    public interface IDatabase
    {
        AbstractObject GetItem(Guid id);

        void Persist(AbstractObject item);

        List<AbstractObject> GetItems();        
    }
}
