using SpiderMan.Unity;
namespace Baozou.Entity {
    public enum eSoccerCap {
        [AttachData(DescripCap.Chinese, "英超")]
        [AttachData(DescripCap.Hot, true)]
        EnglishPremier = 0,
        [AttachData(DescripCap.Chinese, "西甲")]
        [AttachData(DescripCap.Hot, true)]
        SpanishSerieA = 1,
        [AttachData(DescripCap.Chinese, "德甲")]
        [AttachData(DescripCap.Hot, true)]
        GermanSerieA = 2,
        [AttachData(DescripCap.Chinese, "意甲")]
        [AttachData(DescripCap.Hot, true)]
        ItalianSerieA = 3,
        [AttachData(DescripCap.Chinese, "法甲")]
        FrenchSerieA = 4,
        [AttachData(DescripCap.Chinese, "中超")]
        [AttachData(DescripCap.Hot, true)]
        ChinesePremier = 5,

        [AttachData(DescripCap.Chinese, "世界杯")]
        WorldCap = 6,
        [AttachData(DescripCap.Chinese, "欧洲杯")]
        EuropeanCup = 7,
        [AttachData(DescripCap.Chinese, "美洲杯")]
        AmericaCap = 8,
        [AttachData(DescripCap.Chinese, "亚洲杯")]
        AsiaCap = 9,
        [AttachData(DescripCap.Chinese, "欧冠")]
        Champions = 10,
        [AttachData(DescripCap.Chinese, "欧联杯")]
        EuropeanLeagueCup = 18,
        [AttachData(DescripCap.Chinese, "亚冠")]
        AsiaChampions = 11,
        [AttachData(DescripCap.Chinese, "足总杯")]
        EnglandFACup = 12,
        [AttachData(DescripCap.Chinese, "联赛杯")]
        EnglandSerieCup = 13,
        [AttachData(DescripCap.Chinese, "意大利杯")]
        ItalianCap = 14,
        [AttachData(DescripCap.Chinese, "德国杯")]
        GermanCap = 15,
        [AttachData(DescripCap.Chinese, "国王杯")]
        CopaDelRey = 16,
        [AttachData(DescripCap.Chinese, "足协杯")]
        ChineseFACup = 17,
        [AttachData(DescripCap.Chinese, "土伦杯")]
        Toulon = 20,

        [AttachData(DescripCap.Chinese, "足球友谊赛")]
        Friendly = 19,

        [AttachData(DescripCap.Chinese, "解放者杯")]
        LibertadoresCup = 21,

        [AttachData(DescripCap.Chinese, "慈善盾杯")]
        CharityShield = 22,

        [AttachData(DescripCap.Chinese, "国际冠军杯")]
         UnChampions = 23
    }
}