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
    public partial class MatchStatsPickBanType
    {
        public bool? IsPick { get; set; }
        public short? HeroId { get; set; }
        public int? Order { get; set; }
        public short? BannedHeroId { get; set; }
        public bool? IsRadiant { get; set; }
        public int? PlayerIndex { get; set; }
        public bool? WasBannedSuccessfully { get; set; }
        public bool? IsCaptain { get; set; }
        public byte? BaseWinRate { get; set; }
        public byte? AdjustedWinRate { get; set; }
        public int? Letter { get; set; }
    }
}