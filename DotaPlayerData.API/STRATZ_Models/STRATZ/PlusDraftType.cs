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
    public partial class PlusDraftType
    {
        public decimal? MidOutcome { get; set; }
        public decimal? SafeOutcome { get; set; }
        public decimal? OffOutcome { get; set; }
        public IList<object> WinValues { get; set; }
        public IList<object> DurationValues { get; set; }
        public IList<PlusDraftPlayerType> Players { get; set; }
    }
}
