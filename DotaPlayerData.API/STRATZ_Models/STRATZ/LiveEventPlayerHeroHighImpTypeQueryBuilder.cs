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
    public partial class LiveEventPlayerHeroHighImpTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerHeroHighImpTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "imp", IsComplex = true }
            };

        protected override string TypeName { get { return "LiveEventPlayerHeroHighImpType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerHeroHighImpTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroHighImpTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }
    }
}