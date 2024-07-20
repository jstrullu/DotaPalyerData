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
    public partial class SteamAccountTeamMemberTypeQueryBuilder : GraphQlQueryBuilder<SteamAccountTeamMemberTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "player", IsComplex = true, QueryBuilderType = typeof(PlayerTypeQueryBuilder) },
                new FieldMetadata { Name = "teamId" },
                new FieldMetadata { Name = "firstMatchId", IsComplex = true },
                new FieldMetadata { Name = "firstMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "lastMatchId", IsComplex = true },
                new FieldMetadata { Name = "lastMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "team", IsComplex = true, QueryBuilderType = typeof(TeamTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "SteamAccountTeamMemberType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamAccountTeamMemberTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithPlayer(PlayerTypeQueryBuilder playerTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("player", alias, playerTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptPlayer()
        {
            return ExceptField("player");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithTeamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("teamId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptTeamId()
        {
            return ExceptField("teamId");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithFirstMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptFirstMatchId()
        {
            return ExceptField("firstMatchId");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithLastMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchId", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptLastMatchId()
        {
            return ExceptField("lastMatchId");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public SteamAccountTeamMemberTypeQueryBuilder WithTeam(TeamTypeQueryBuilder teamTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("team", alias, teamTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public SteamAccountTeamMemberTypeQueryBuilder ExceptTeam()
        {
            return ExceptField("team");
        }
    }
}
