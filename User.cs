using SpiderMan.Unity.Mongo;
using SpiderMan.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Baozou.Entity {
    public class User : MEntity {

        public string TokenIdentity { get; set; } //用于生成权限票据ticket，不能对外暴露。（因为没有password）
        public int Act { get; set; }

        [DisplayName("性别")]
        public int Gender { get; set; }

        [DisplayName("城市")]
        public string Province { get; set; }
        public string City { get; set; }

        public IEnumerable<string> AuthRoles { get; set; }

        public DateTime BirthTime { get; set; }
        public virtual void Creat() {
            BirthTime = DateTime.Now;
            Act = (int)eAct.Normal;
        }

        public DateTime DateLastLogin { get; set; }

        [DefaultValue("匿名")]
        [DisplayName("昵称")]
        public string NickName { get; set; }
        public string HeadUrl { get; set; }

        public string TagAssemblyId { get; set; }
    }
}
