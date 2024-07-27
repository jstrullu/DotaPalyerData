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
    public partial class MatchPlayerSpectatorTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerSpectatorTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamId", IsComplex = true },
                new FieldMetadata { Name = "isRadiantCoach" },
                new FieldMetadata { Name = "isVictory" }
            };

        protected override string TypeName { get { return "MatchPlayerSpectatorType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerSpectatorTypeQueryBuilder WithSteamId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerSpectatorTypeQueryBuilder ExceptSteamId()
        {
            return ExceptField("steamId");
        }

        public MatchPlayerSpectatorTypeQueryBuilder WithIsRadiantCoach(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRadiantCoach", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerSpectatorTypeQueryBuilder ExceptIsRadiantCoach()
        {
            return ExceptField("isRadiantCoach");
        }

        public MatchPlayerSpectatorTypeQueryBuilder WithIsVictory(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isVictory", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerSpectatorTypeQueryBuilder ExceptIsVictory()
        {
            return ExceptField("isVictory");
        }
    }
}