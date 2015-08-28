using SpiderMan.Unity;
namespace Baozou.Entity {
    public enum eMatchType {
        [AttachData(DescripCap.Chinese, "足球")]
        Soccer = 1,
        [AttachData(DescripCap.Chinese, "NBA")]
        Nba = 2,
        [AttachData(DescripCap.Chinese, "网球")]
        Tennis = 3,
        [AttachData(DescripCap.Chinese, "台球")]
        Billiards = 4,
        [AttachData(DescripCap.Chinese, "乒羽")]
        Pingpong = 5,
        //[AttachData(DescripCap.Chinese, "高尔夫")]
        //Golf = 6,
        [AttachData(DescripCap.Chinese, "F1")]
        F1 = 7,
        [AttachData(DescripCap.Chinese, "电子竞技")]
        Esports = 8,
        //[AttachData(DescripCap.Chinese, "围棋")]
        //Go = 9,
        [AttachData(DescripCap.Chinese, "综艺")]
        Arts = 10
    }
}