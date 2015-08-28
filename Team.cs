using SpiderMan.Unity.Mongo;
using SpiderMan.Unity;
using System.Collections.Generic;

namespace Baozou.Entity {
    public class Team : MEntity {
        public int Act { get; set; }

        public virtual void Creat() {
            Act = (int)eAct.Normal;
        }

        public string Name { get; set; }
        public string NameChinese { get; set; }
        public IList<string> NameAlias { get; set; }

        public int League { get; set; }
    }
}
