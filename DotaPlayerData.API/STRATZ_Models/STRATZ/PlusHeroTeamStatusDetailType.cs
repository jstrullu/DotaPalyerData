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
    public partial class PlusHeroTeamStatusDetailType
    {
        public int? HeroId { get; set; }
        public RankBracketBasicEnum? BasicBracket { get; set; }
        public MatchPlayerPositionType? Position { get; set; }
        public PlusHeroTeamStatusAveragesType Averages { get; set; }
    }
}
