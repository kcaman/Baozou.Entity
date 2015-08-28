using SpiderMan.Unity.Mongo;
using System.ComponentModel.DataAnnotations;

namespace Baozou.Entity {
    public class UserOAuth : MEntity {
        [MaxLength(30)]
        public string Provider { get; set; }
        [MaxLength(100)]
        public string ProviderUserId { get; set; }

        public string UserId { get; set; }

        public int ExpireTime { get; set; }
        public string Token { get; set; }

        public string NickName { get; set; }
        public string HeadUrl { get; set; }

        public string ProfileUrl { get; set; }
    }
}
