using SpiderMan.Unity;
namespace Baozou.Entity {
    public enum eTennisCap {
        [AttachData(DescripCap.Chinese, "法网")]
        [AttachData(DescripCap.Hot, true)]
        Franch = 0,
        [AttachData(DescripCap.Chinese, "澳网")]
        [AttachData(DescripCap.Hot, true)]
        Australia = 1,
        [AttachData(DescripCap.Chinese, "美网")]
        [AttachData(DescripCap.Hot, true)]
        America = 2,
        [AttachData(DescripCap.Chinese, "温网")]
        [AttachData(DescripCap.Hot, true)]
        Wimbledon = 3,

        [AttachData(DescripCap.Chinese, "WTA迈阿密")]
        WTA_Miami = 4,
        [AttachData(DescripCap.Chinese, "WTA马德里")]
        WTA_Madrid = 5,
        [AttachData(DescripCap.Chinese, "WTA罗马")]
        WTA_Rome = 6,
        [AttachData(DescripCap.Chinese, "WTA中国")]
        WTA_China = 7,
        [AttachData(DescripCap.Chinese, "WTA卡塔尔")]
        WTA_Qatar = 8,
        [AttachData(DescripCap.Chinese, "WTA年终总决赛")]
        WTA_Final = 9,
        [AttachData(DescripCap.Chinese, "中网")]
        Chinese = 10
    }
}