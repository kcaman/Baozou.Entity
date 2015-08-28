using SpiderMan.Unity.Mongo;
using System;

namespace Baozou.Entity {
    public class Player : MEntity {
        public string Name { get; set; }
        public string NameChinese { get; set; }
        public DateTime Birth { get; set; }
        public float Height { get; set; }
        public string Contract { get; set; }
        public string TeamId { get; set; }
    }
}