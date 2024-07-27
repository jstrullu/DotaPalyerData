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
    public partial class HeroItemBootPurchaseTypeQueryBuilder : GraphQlQueryBuilder<HeroItemBootPurchaseTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId" },
                new FieldMetadata { Name = "week" },
                new FieldMetadata { Name = "bracketBasicIds" },
                new FieldMetadata { Name = "position" },
                new FieldMetadata { Name = "itemId" },
                new FieldMetadata { Name = "instance" },
                new FieldMetadata { Name = "time", IsComplex = true },
                new FieldMetadata { Name = "timeAverage", IsComplex = true },
                new FieldMetadata { Name = "matchCount", IsComplex = true },
                new FieldMetadata { Name = "winCount", IsComplex = true },
                new FieldMetadata { Name = "winAverage", IsComplex = true },
                new FieldMetadata { Name = "kills", IsComplex = true },
                new FieldMetadata { Name = "killsAverage", IsComplex = true },
                new FieldMetadata { Name = "deaths", IsComplex = true },
                new FieldMetadata { Name = "deathsAverage", IsComplex = true },
                new FieldMetadata { Name = "assists", IsComplex = true },
                new FieldMetadata { Name = "assistsAverage", IsComplex = true },
                new FieldMetadata { Name = "goldEarned", IsComplex = true },
                new FieldMetadata { Name = "goldEarnedAverage", IsComplex = true },
                new FieldMetadata { Name = "xp", IsComplex = true },
                new FieldMetadata { Name = "xpAverage", IsComplex = true },
                new FieldMetadata { Name = "activations", IsComplex = true },
                new FieldMetadata { Name = "activationsAverage", IsComplex = true },
                new FieldMetadata { Name = "activationTime", IsComplex = true },
                new FieldMetadata { Name = "activationsTimeAverage", IsComplex = true }
            };

        protected override string TypeName { get { return "HeroItemBootPurchaseType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HeroItemBootPurchaseTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithWeek(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("week", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptWeek()
        {
            return ExceptField("week");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptPosition()
        {
            return ExceptField("position");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithInstance(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("instance", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptInstance()
        {
            return ExceptField("instance");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithTimeAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("timeAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptTimeAverage()
        {
            return ExceptField("timeAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithWinAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptWinAverage()
        {
            return ExceptField("winAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("kills", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptKills()
        {
            return ExceptField("kills");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithKillsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("killsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptKillsAverage()
        {
            return ExceptField("killsAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deaths", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptDeaths()
        {
            return ExceptField("deaths");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithDeathsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("deathsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptDeathsAverage()
        {
            return ExceptField("deathsAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("assists", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptAssists()
        {
            return ExceptField("assists");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithAssistsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("assistsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptAssistsAverage()
        {
            return ExceptField("assistsAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithGoldEarned(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldEarned", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptGoldEarned()
        {
            return ExceptField("goldEarned");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithGoldEarnedAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("goldEarnedAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptGoldEarnedAverage()
        {
            return ExceptField("goldEarnedAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithXp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("xp", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptXp()
        {
            return ExceptField("xp");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithXpAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("xpAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptXpAverage()
        {
            return ExceptField("xpAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithActivations(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activations", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptActivations()
        {
            return ExceptField("activations");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithActivationsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activationsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptActivationsAverage()
        {
            return ExceptField("activationsAverage");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithActivationTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activationTime", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptActivationTime()
        {
            return ExceptField("activationTime");
        }

        public HeroItemBootPurchaseTypeQueryBuilder WithActivationsTimeAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("activationsTimeAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HeroItemBootPurchaseTypeQueryBuilder ExceptActivationsTimeAverage()
        {
            return ExceptField("activationsTimeAverage");
        }
    }
}