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
    public partial class HomepageHeroDryadTypeQueryBuilder : GraphQlQueryBuilder<HomepageHeroDryadTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "mainHeroId", IsComplex = true },
                new FieldMetadata { Name = "comparisonHeroId", IsComplex = true },
                new FieldMetadata { Name = "bracketBasicIds" },
                new FieldMetadata { Name = "matchCount", IsComplex = true },
                new FieldMetadata { Name = "winCount", IsComplex = true },
                new FieldMetadata { Name = "synergy", IsComplex = true },
                new FieldMetadata { Name = "winsAverage", IsComplex = true },
                new FieldMetadata { Name = "comparisonHeroBaseWinRate", IsComplex = true }
            };

        protected override string TypeName { get { return "HomepageHeroDryadType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public HomepageHeroDryadTypeQueryBuilder WithMainHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mainHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptMainHeroId()
        {
            return ExceptField("mainHeroId");
        }

        public HomepageHeroDryadTypeQueryBuilder WithComparisonHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("comparisonHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptComparisonHeroId()
        {
            return ExceptField("comparisonHeroId");
        }

        public HomepageHeroDryadTypeQueryBuilder WithBracketBasicIds(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("bracketBasicIds", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptBracketBasicIds()
        {
            return ExceptField("bracketBasicIds");
        }

        public HomepageHeroDryadTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public HomepageHeroDryadTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public HomepageHeroDryadTypeQueryBuilder WithSynergy(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("synergy", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptSynergy()
        {
            return ExceptField("synergy");
        }

        public HomepageHeroDryadTypeQueryBuilder WithWinsAverage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winsAverage", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptWinsAverage()
        {
            return ExceptField("winsAverage");
        }

        public HomepageHeroDryadTypeQueryBuilder WithComparisonHeroBaseWinRate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("comparisonHeroBaseWinRate", alias, new GraphQlDirective[] { include, skip });
        }

        public HomepageHeroDryadTypeQueryBuilder ExceptComparisonHeroBaseWinRate()
        {
            return ExceptField("comparisonHeroBaseWinRate");
        }
    }
}