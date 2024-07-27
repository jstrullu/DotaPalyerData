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
    public partial class MatchPlayerStatsTowerDamageReportTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerStatsTowerDamageReportTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "npcId" },
                new FieldMetadata { Name = "damage" },
                new FieldMetadata { Name = "damageCreeps" },
                new FieldMetadata { Name = "damageFromAbility" }
            };

        protected override string TypeName { get { return "MatchPlayerStatsTowerDamageReportType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder WithNpcId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("npcId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder ExceptNpcId()
        {
            return ExceptField("npcId");
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder WithDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder ExceptDamage()
        {
            return ExceptField("damage");
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder WithDamageCreeps(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damageCreeps", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder ExceptDamageCreeps()
        {
            return ExceptField("damageCreeps");
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder WithDamageFromAbility(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damageFromAbility", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsTowerDamageReportTypeQueryBuilder ExceptDamageFromAbility()
        {
            return ExceptField("damageFromAbility");
        }
    }
}