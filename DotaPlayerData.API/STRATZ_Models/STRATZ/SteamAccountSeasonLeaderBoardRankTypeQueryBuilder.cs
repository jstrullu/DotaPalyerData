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
    public partial class SteamAccountSeasonLeaderBoardRankTypeQueryBuilder : GraphQlQueryBuilder<SteamAccountSeasonLeaderBoardRankTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "seasonRankId", IsComplex = true },
                new FieldMetadata { Name = "asOfDateTime", IsComplex = true },
                new FieldMetadata { Name = "seasonLeaderBoardDivisionId" },
                new FieldMetadata { Name = "rank", IsComplex = true }
            };

        protected override string TypeName { get { return "SteamAccountSeasonLeaderBoardRankType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder WithSeasonRankId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seasonRankId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder ExceptSeasonRankId()
        {
            return ExceptField("seasonRankId");
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder WithAsOfDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("asOfDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder ExceptAsOfDateTime()
        {
            return ExceptField("asOfDateTime");
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder WithSeasonLeaderBoardDivisionId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("seasonLeaderBoardDivisionId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder ExceptSeasonLeaderBoardDivisionId()
        {
            return ExceptField("seasonLeaderBoardDivisionId");
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder WithRank(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("rank", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountSeasonLeaderBoardRankTypeQueryBuilder ExceptRank()
        {
            return ExceptField("rank");
        }
    }
}