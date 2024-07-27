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
    public partial class DireTide2020CustomGamePlayerTypeQueryBuilder : GraphQlQueryBuilder<DireTide2020CustomGamePlayerTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "matchId", IsComplex = true },
                new FieldMetadata { Name = "playerSlot", IsComplex = true },
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "isVictory" },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "hero", IsComplex = true, QueryBuilderType = typeof(HeroTypeQueryBuilder) },
                new FieldMetadata { Name = "kills", IsComplex = true },
                new FieldMetadata { Name = "deaths", IsComplex = true },
                new FieldMetadata { Name = "assists", IsComplex = true },
                new FieldMetadata { Name = "leaverStatus", IsComplex = true },
                new FieldMetadata { Name = "numLastHits", IsComplex = true },
                new FieldMetadata { Name = "goldPerMinute", IsComplex = true },
                new FieldMetadata { Name = "goldSpent" },
                new FieldMetadata { Name = "level", IsComplex = true },
                new FieldMetadata { Name = "heroDamage" },
                new FieldMetadata { Name = "heroHealing" },
                new FieldMetadata { Name = "networth" },
                new FieldMetadata { Name = "item0Id", IsComplex = true },
                new FieldMetadata { Name = "item1Id", IsComplex = true },
                new FieldMetadata { Name = "item2Id", IsComplex = true },
                new FieldMetadata { Name = "item3Id", IsComplex = true },
                new FieldMetadata { Name = "item4Id", IsComplex = true },
                new FieldMetadata { Name = "item5Id", IsComplex = true },
                new FieldMetadata { Name = "backpack0Id", IsComplex = true },
                new FieldMetadata { Name = "backpack1Id", IsComplex = true },
                new FieldMetadata { Name = "backpack2Id", IsComplex = true },
                new FieldMetadata { Name = "neutral0Id", IsComplex = true },
                new FieldMetadata { Name = "partyId", IsComplex = true },
                new FieldMetadata { Name = "candyLost", IsComplex = true },
                new FieldMetadata { Name = "candyPickedUp", IsComplex = true },
                new FieldMetadata { Name = "candyScored", IsComplex = true }
            };

        protected override string TypeName { get { return "DireTide2020CustomGamePlayerType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchId", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptMatchId()
        {
            return ExceptField("matchId");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithPlayerSlot(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("playerSlot", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptPlayerSlot()
        {
            return ExceptField("playerSlot");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithIsVictory(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isVictory", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptIsVictory()
        {
            return ExceptField("isVictory");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithHero(HeroTypeQueryBuilder heroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("hero", alias, heroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptHero()
        {
            return ExceptField("hero");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("kills", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptKills()
        {
            return ExceptField("kills");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deaths", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptDeaths()
        {
            return ExceptField("deaths");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("assists", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptAssists()
        {
            return ExceptField("assists");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithLeaverStatus(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leaverStatus", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptLeaverStatus()
        {
            return ExceptField("leaverStatus");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithNumLastHits(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("numLastHits", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptNumLastHits()
        {
            return ExceptField("numLastHits");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptGoldPerMinute()
        {
            return ExceptField("goldPerMinute");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithGoldSpent(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldSpent", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptGoldSpent()
        {
            return ExceptField("goldSpent");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithHeroDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptHeroDamage()
        {
            return ExceptField("heroDamage");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithHeroHealing(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroHealing", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptHeroHealing()
        {
            return ExceptField("heroHealing");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithNetworth(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("networth", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptNetworth()
        {
            return ExceptField("networth");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithItem0Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item0Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptItem0Id()
        {
            return ExceptField("item0Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithItem1Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item1Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptItem1Id()
        {
            return ExceptField("item1Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithItem2Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item2Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptItem2Id()
        {
            return ExceptField("item2Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithItem3Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item3Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptItem3Id()
        {
            return ExceptField("item3Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithItem4Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item4Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptItem4Id()
        {
            return ExceptField("item4Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithItem5Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item5Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptItem5Id()
        {
            return ExceptField("item5Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithBackpack0Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("backpack0Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptBackpack0Id()
        {
            return ExceptField("backpack0Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithBackpack1Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("backpack1Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptBackpack1Id()
        {
            return ExceptField("backpack1Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithBackpack2Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("backpack2Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptBackpack2Id()
        {
            return ExceptField("backpack2Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithNeutral0Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("neutral0Id", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptNeutral0Id()
        {
            return ExceptField("neutral0Id");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithPartyId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("partyId", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptPartyId()
        {
            return ExceptField("partyId");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithCandyLost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyLost", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptCandyLost()
        {
            return ExceptField("candyLost");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithCandyPickedUp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyPickedUp", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptCandyPickedUp()
        {
            return ExceptField("candyPickedUp");
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder WithCandyScored(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyScored", alias, new GraphQlDirective[] { include, skip });
        }

        public DireTide2020CustomGamePlayerTypeQueryBuilder ExceptCandyScored()
        {
            return ExceptField("candyScored");
        }
    }
}