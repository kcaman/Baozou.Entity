using SpiderMan.Unity.Mongo;
using SpiderMan.Unity;
using System;

namespace Baozou.Entity {
    public class News : MEntity {
        public int Act { get; set; }
        public int NewsGroup { get; set; }
        public DateTime CreatTime { get; set; }
        public string Source { get; set; }
        public virtual void Creat() {
            Act = (int)eAct.Normal;
        }

        public string Title { get; set; }
        public string Content { get; set; }
    }
}
