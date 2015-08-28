using SpiderMan.Unity.Mongo;
using System.Collections.Generic;

namespace Baozou.Entity {
    public class MatchFixbug : MEntity {
        public string SourceCode { get; set; }
        public string KanbisaiLink { get; set; }
        
        public string Title { get; set; } //for azhibo.com 待分词
        public string CapString { get; set; }
        public string CapStringDetial { get; set; }

        public int Status { get; set; }
        public int Type { get; set; }
        public int Cap { get; set; }
        public string Time { get; set; }
        public int Grade { get; set; } //eGrade

        public string TeamName { get; set; }
        public string TeamNameChinese { get; set; }
        public string TeamNameForGuest { get; set; }
        public string TeamNameChineseForGuest { get; set; }

        public IEnumerable<Link> LiveVideos { get; set; }
        public IEnumerable<Link> LiveVideosForMobile { get; set; }
        public IEnumerable<Link> LiveVideosForAndroid { get; set; }
        public string LiveText { get; set; }
        public string LiveTextForMobile { get; set; }
        public int Point { get; set; }
        public int PointForGuest { get; set; }
        public string Quarter { get; set; }
        public string QuarterTime { get; set; }

        public string BestVideo { get; set; }
        public string BestVideoMobi { get; set; }
        public IEnumerable<string> HighlightsVideo { get; set; }
        public string Recording { get; set; }

        public bool LockSpider { get; set; }

        public SoccerMatchData DataForSoccer { get; set; }
        public BasketballMatchData DataForBasketball { get; set; }

    }
}