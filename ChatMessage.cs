using SpiderMan.Unity.Mongo;
using System;

namespace Baozou.Entity {
    public class ChatMessage : MEntity {
        public string MatchId { get; set; }
        public string Name { get; set; }
        public DateTime CreatDate { get; set; }
        public string Content { get; set; }
    }
}