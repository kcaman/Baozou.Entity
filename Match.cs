using SpiderMan.Unity.Mongo;
using System;
using System.Collections.Generic;

namespace Baozou.Entity {
    public class Match : MEntity {
        public string SourceCode { get; set; }
        public string KanbisaiLink { get; set; }
        
        public string Title { get; set; }
        public string CapString { get; set; }
        public string CapStringDetial { get; set; } //CapString's Original

        public int Status { get; set; }
        public int Type { get; set; }
        public int Cap { get; set; }
        public DateTime Time { get; set; }
        public int Grade { get; set; } //eGrade

        public string TeamName { get; set; }
        public string TeamNameChinese { get; set; }
        public string TeamNameForGuest { get; set; }
        public string TeamNameChineseForGuest { get; set; }

        public int Point { get; set; }
        public int PointForGuest { get; set; }
        public string Quarter { get; set; }
        public string QuarterTime { get; set; }

        public IEnumerable<Link> LiveVideos { get; set; }
        public IEnumerable<Link> LiveVideosForMobile { get; set; }
        public IEnumerable<Link> LiveVideosForAndroid { get; set; }
        public IList<Link> Recording { get; set; }
        public IList<Link> RecordingMobi { get; set; }
        public IList<Link> Highlights { get; set; }
        public IList<Link> HighlightsMobi { get; set; }
        public string LiveText { get; set; }
        public string LiveTextForMobile { get; set; }

        public string BestVideo { get; set; } //obsolete
        public string BestVideoMobi { get; set; } //obsolete

        public bool LockSpider { get; set; }
        public string TransferData { get; set; }

        public SoccerMatchData DataForSoccer { get; set; }
        public BasketballMatchData DataForBasketball { get; set; }
    }

    public class Link {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}