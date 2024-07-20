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
    public partial class LeagueTableTypeQueryBuilder : GraphQlQueryBuilder<LeagueTableTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "leagueId" },
                new FieldMetadata { Name = "tableTeams", IsComplex = true, QueryBuilderType = typeof(LeagueTableTeamTypeQueryBuilder) },
                new FieldMetadata { Name = "tableHeroes", IsComplex = true, QueryBuilderType = typeof(LeagueTableHeroTypeQueryBuilder) },
                new FieldMetadata { Name = "tablePlayers", IsComplex = true, QueryBuilderType = typeof(LeagueTablePlayerTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LeagueTableType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTableTypeQueryBuilder WithLeagueId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leagueId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTypeQueryBuilder ExceptLeagueId()
        {
            return ExceptField("leagueId");
        }

        public LeagueTableTypeQueryBuilder WithTableTeams(LeagueTableTeamTypeQueryBuilder leagueTableTeamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("tableTeams", alias, leagueTableTeamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTypeQueryBuilder ExceptTableTeams()
        {
            return ExceptField("tableTeams");
        }

        public LeagueTableTypeQueryBuilder WithTableHeroes(LeagueTableHeroTypeQueryBuilder leagueTableHeroTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("tableHeroes", alias, leagueTableHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTypeQueryBuilder ExceptTableHeroes()
        {
            return ExceptField("tableHeroes");
        }

        public LeagueTableTypeQueryBuilder WithTablePlayers(LeagueTablePlayerTypeQueryBuilder leagueTablePlayerTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("tablePlayers", alias, leagueTablePlayerTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTypeQueryBuilder ExceptTablePlayers()
        {
            return ExceptField("tablePlayers");
        }
    }
}
