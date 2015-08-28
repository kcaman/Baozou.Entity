using SpiderMan.Unity.Mongo;
using System.Collections.Generic;

namespace Baozou.Entity {
    public class BasketballMatchData {
        public IEnumerable<string> Players { get; set; }
        public IEnumerable<bool> IsFirstRounds { get; set; }        
        public IEnumerable<int> Times { get; set; }
        public IEnumerable<int> TimesForGuest { get; set; }

        public IEnumerable<int> Shots { get; set; }
        public IEnumerable<int> Hits { get; set; }        
        public IEnumerable<int> ThreeShots { get; set; }        
        public IEnumerable<int> ThreeHits { get; set; }
        public IEnumerable<int> FreeShots { get; set; }        
        public IEnumerable<int> FreeHits { get; set; }
        public IEnumerable<int> Points { get; set; }        

        public IEnumerable<int> Rebounds { get; set; }
        public IEnumerable<int> OffensiveRebounds { get; set; }
        public IEnumerable<int> Assists { get; set; }
        
        public IEnumerable<int> Steals { get; set; }
        public IEnumerable<int> Blocks { get; set; }
        public IEnumerable<int> Fouls { get; set; }
        public IEnumerable<int> Faults { get; set; }

        #region Guest
        public IEnumerable<string> PlayersForGuest { get; set; }
        public IEnumerable<bool> IsFirstRoundsForGuest { get; set; }
        public IEnumerable<int> ShotsForGuest { get; set; }
        public IEnumerable<int> HitsForGuest { get; set; }
        public IEnumerable<int> ThreeShotsForGuest { get; set; }
        public IEnumerable<int> ThreeHitsForGuest { get; set; }
        public IEnumerable<int> FreeShotsForGuest { get; set; }
        public IEnumerable<int> FreeHitsForGuest { get; set; }
        public IEnumerable<int> PointsForGuest { get; set; }
        public IEnumerable<int> ReboundsForGuest { get; set; }
        public IEnumerable<int> OffensiveReboundsForGuest { get; set; }
        public IEnumerable<int> AssistsForGuest { get; set; }
        public IEnumerable<int> StealsForGuest { get; set; }
        public IEnumerable<int> BlockssForGuest { get; set; }
        public IEnumerable<int> FoulsForGuest { get; set; }
        public IEnumerable<int> FaultsForGuest { get; set; }
        #endregion
    }
}