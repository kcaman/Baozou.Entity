using SpiderMan.Unity;

namespace Baozou.Entity {
    public enum eBasketballCap {
        [AttachData(DescripCap.Chinese, "NBA")]
        [AttachData(DescripCap.Hot, true)]
        NBA = 0,
        [AttachData(DescripCap.Chinese, "CBA")]
        [AttachData(DescripCap.Hot, true)]
        CBA = 1,

        [AttachData(DescripCap.Chinese, "男篮世锦赛")]
        FIBAWorldChampion = 2,
        [AttachData(DescripCap.Chinese, "男篮亚锦赛")]
        FIBAAsianCap = 3,

        [AttachData(DescripCap.Chinese, "篮球友谊赛")]
        Friendly = 4,

        [AttachData(DescripCap.Chinese, "男篮亚洲杯")]
        FIBAAsiaCap = 5,

        [AttachData(DescripCap.Chinese, "斯坦科维奇杯")]
        Stankovic = 6,

        [AttachData(DescripCap.Chinese, "男篮世界杯")]
        FIBAWorldCap = 7,

        [AttachData(DescripCap.Chinese, "女篮世锦赛")]
        FIBAWorldCapFemale = 8
    }
}