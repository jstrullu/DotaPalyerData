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
    public partial class PlayerConductResponseTypeQueryBuilder : GraphQlQueryBuilder<PlayerConductResponseTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "lastIncidentDateTime", IsComplex = true },
                new FieldMetadata { Name = "lastIncidentMatchId", IsComplex = true },
                new FieldMetadata { Name = "recentMatchIncidents", IsComplex = true },
                new FieldMetadata { Name = "behaviorScore", IsComplex = true }
            };

        protected override string TypeName { get { return "PlayerConductResponseType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerConductResponseTypeQueryBuilder WithLastIncidentDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastIncidentDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerConductResponseTypeQueryBuilder ExceptLastIncidentDateTime()
        {
            return ExceptField("lastIncidentDateTime");
        }

        public PlayerConductResponseTypeQueryBuilder WithLastIncidentMatchId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastIncidentMatchId", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerConductResponseTypeQueryBuilder ExceptLastIncidentMatchId()
        {
            return ExceptField("lastIncidentMatchId");
        }

        public PlayerConductResponseTypeQueryBuilder WithRecentMatchIncidents(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("recentMatchIncidents", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerConductResponseTypeQueryBuilder ExceptRecentMatchIncidents()
        {
            return ExceptField("recentMatchIncidents");
        }

        public PlayerConductResponseTypeQueryBuilder WithBehaviorScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("behaviorScore", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerConductResponseTypeQueryBuilder ExceptBehaviorScore()
        {
            return ExceptField("behaviorScore");
        }
    }
}