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
    public partial class MatchPlayerLivePlaybackDataType
    {
        public IList<MatchLivePlayerPositionDetailType> PositionEvents { get; set; }
        public IList<MatchLivePlayerGoldDetailType> GoldEvents { get; set; }
        public IList<MatchLivePlayerLevelDetailType> LevelEvents { get; set; }
        public IList<MatchLivePlayerKillDetailType> KillEvents { get; set; }
        public IList<MatchLivePlayerDeathDetailType> DeathEvents { get; set; }
        public IList<MatchLivePlayerAssistDetailType> AssistEvents { get; set; }
        public IList<MatchLivePlayerLastHitDetailType> CsEvents { get; set; }
        public IList<MatchLivePlayerDenyDetailType> DenyEvents { get; set; }
        public IList<MatchLivePlayerExperienceDetailType> ExperienceEvents { get; set; }
        public IList<MatchLivePlayerInventoryDetailType> InventoryEvents { get; set; }
    }
}
