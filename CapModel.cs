using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SpiderMan.Unity;

namespace Baozou.Entity {
    public class CapModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int MatchType { get; set; } //eMatchType
        public bool Hot { get; set; }
        public bool Subscribe { get; set; }
    }

    public static class CapFunc {

        public static IEnumerable<CapModel> GetItems(eMatchType matchType) {
            switch (matchType) {
                case eMatchType.Nba:
                    return CapFunc.GetItems<eBasketballCap>(matchType);
                case eMatchType.Soccer:
                    return CapFunc.GetItems<eSoccerCap>(matchType);
                case eMatchType.Tennis:
                    return CapFunc.GetItems<eTennisCap>(matchType);
                default:
                    return new List<CapModel>();
            }
        }

        private static IEnumerable<CapModel> GetItems<TEnum>(eMatchType matchType) {
            return from TEnum e in Enum.GetValues(typeof(TEnum))
                   select new CapModel() {
                       Name = e.GetAttachedDataFromObj<string>(DescripCap.Chinese),
                       Hot = e.GetAttachedDataFromObj<bool>(DescripCap.Hot),
                       Code = e.ToString(),
                       Id = Convert.ToInt32(e),
                       MatchType = (int)matchType,
                   };
        }

        public static string GetString(eMatchType matchType, int capId) {
            switch (matchType) {
                case eMatchType.Nba:
                    return ((eBasketballCap)capId).ToString();
                case eMatchType.Soccer:
                    return ((eSoccerCap)capId).ToString();
                case eMatchType.Tennis:
                    return ((eTennisCap)capId).ToString();
                default:
                    return string.Empty;
            }
        }

        public static string GetChineseString(eMatchType matchType, int capId) {
            switch (matchType) {
                case eMatchType.Nba:
                    return ((eBasketballCap)capId).GetAttachedDataFromObj<string>(DescripCap.Chinese);
                case eMatchType.Soccer:
                    return ((eSoccerCap)capId).GetAttachedDataFromObj<string>(DescripCap.Chinese);
                case eMatchType.Tennis:
                    return ((eTennisCap)capId).GetAttachedDataFromObj<string>(DescripCap.Chinese);
                default:
                    return matchType.GetAttachedDataFromObj<string>(DescripCap.Chinese);
            }
        }

        public static void GetInteger(string capString, out int capTypeId, out int capId) {
            capTypeId = capId = 0;
            eMatchType etype;
            eBasketballCap ebasket;
            eSoccerCap esoccer;
            eTennisCap etennis;
            if (Enum.TryParse(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(capString), out etype)) {
                capTypeId = (int)etype;
                capId = -1;
            } else if (Enum.TryParse(capString, out ebasket)) {
                capTypeId = (int)eMatchType.Nba;
                capId = (int)ebasket;
            } else if (Enum.TryParse(capString, out esoccer)) {
                capTypeId = (int)eMatchType.Soccer;
                capId = (int)esoccer;
            } else if (Enum.TryParse(capString, out etennis)) {
                capTypeId = (int)eMatchType.Tennis;
                capId = (int)etennis;
            }
        }
    }
}
