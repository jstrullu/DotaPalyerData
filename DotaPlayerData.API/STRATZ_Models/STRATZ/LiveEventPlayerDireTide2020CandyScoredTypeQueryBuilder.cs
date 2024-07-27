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
    public partial class LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(DireTide2020CustomGameMatchTypeQueryBuilder) },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "candyScored", IsComplex = true }
            };

        protected override string TypeName { get { return "LiveEventPlayerDireTide2020CandyScoredType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder WithMatch(DireTide2020CustomGameMatchTypeQueryBuilder direTide2020CustomGameMatchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, direTide2020CustomGameMatchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder WithCandyScored(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("candyScored", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerDireTide2020CandyScoredTypeQueryBuilder ExceptCandyScored()
        {
            return ExceptField("candyScored");
        }
    }
}