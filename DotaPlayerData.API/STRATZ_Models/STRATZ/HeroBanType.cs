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
    public partial class HeroBanType
    {
        public short? HeroId { get; set; }
        public int? Day { get; set; }
        public RankBracketBasicEnum? BracketBasicIds { get; set; }
        public long? MatchCount { get; set; }
        public long? WinCount { get; set; }
    }
}
