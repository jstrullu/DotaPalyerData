// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class LeaderboardQuery
    {
        public SteamAccountSeasonActiveLeaderboardType Season { get; set; }
        public PlayerHeroDotaPlusLeaderboardRankResponseType DotaPlus { get; set; }
        public IList<DotaPlusWeekType> DotaPlusWeek { get; set; }
        public IList<HeroDotaPlusLeaderboardRankTopType> DotaPlusTopLevels { get; set; }
        public PlayerBattlePassResponseType BattlePass { get; set; }
        public IList<PlayerBattlePassGroupByType> BattlePassGroupBy { get; set; }
        public PlayerCoachingLeaderboardResponseType Coaching { get; set; }
        public IList<GuildType> Guild { get; set; }
        public IList<PlayerLeaderBoardByHeroType> Hero { get; set; }
    }
}
