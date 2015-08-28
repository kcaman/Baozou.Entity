using SpiderMan.Unity;
namespace Baozou.Entity {
    public enum eLeague {
        [AttachData(DescripByLang.Chinese, "英超")]
        EnglishPremier,
        [AttachData(DescripByLang.Chinese, "西甲")]
        SpanishSerieA,
        [AttachData(DescripByLang.Chinese, "意甲")]
        ItalianSerieA,
        [AttachData(DescripByLang.Chinese, "德甲")]
        GermanSerieA,
        [AttachData(DescripByLang.Chinese, "法甲")]
        FrenchSerieA,
        [AttachData(DescripByLang.Chinese, "中超")]
        ChinesePremier,
        [AttachData(DescripByLang.Chinese, "国际足联")]
        FIFA,
        [AttachData(DescripByLang.Chinese, "NBA")]
        NBA,
        [AttachData(DescripByLang.Chinese, "CBA")]
        CBA,
        [AttachData(DescripByLang.Chinese, "国际篮联")]
        FIBA,
        [AttachData(DescripByLang.Chinese, "ATP")]
        ATP
    }
}