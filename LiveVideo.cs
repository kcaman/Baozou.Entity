using SpiderMan.Unity.Mongo;
using SpiderMan.Unity;
using System.Collections.Generic;

namespace Baozou.Entity {
    public class LiveVideo : MEntity {
        public int Act { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Alias { get; set; }
        public IEnumerable<string> AliasForMobile { get; set; }

        public bool IsAimTypeCap { get; set; }
        public IEnumerable<int> AimTypes { get; set; }
        public IEnumerable<int> AimCaps { get; set; }

        public string Link { get; set; }
        public bool WithClient { get; set; }
        public string LinkForMobile { get; set; }
        public string LinkForAndroid { get; set; }
        public virtual void Creat() {
            Act = (int)eAct.Normal;
        }

        public int Rank { get; set; }

        public Link GenerateLink() {
            return new Link {
                Name = Name + (WithClient ? "φ" : ""),
                Url = Link
            };
        }

        public Link GenerateLinkMobi() {
            return new Link {
                Name = Name,
                Url = LinkForMobile
            };
        }

        public Link GenerateLinkAndroid() {
            return new Link {
                Name = Name,
                Url = string.IsNullOrEmpty(LinkForAndroid) ? LinkForMobile : LinkForAndroid
            };
        }
    }
}