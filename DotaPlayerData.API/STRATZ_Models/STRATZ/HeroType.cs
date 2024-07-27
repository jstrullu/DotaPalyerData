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
    public partial class HeroType
    {
        public short? Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ShortName { get; set; }
        public IList<string> Aliases { get; set; }
        public short? GameVersionId { get; set; }
        public IList<HeroAbilityType> Abilities { get; set; }
        public IList<HeroRoleType> Roles { get; set; }
        public HeroLanguageType Language { get; set; }
        public IList<HeroTalentType> Talents { get; set; }
        public HeroStatType Stats { get; set; }
    }
}