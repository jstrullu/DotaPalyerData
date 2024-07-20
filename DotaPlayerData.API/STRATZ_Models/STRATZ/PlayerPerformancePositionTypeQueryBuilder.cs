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
    public partial class PlayerPerformancePositionTypeQueryBuilder : GraphQlQueryBuilder<PlayerPerformancePositionTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "roleType" },
                new FieldMetadata { Name = "roleMatchCount" },
                new FieldMetadata { Name = "roleWinCount" },
                new FieldMetadata { Name = "lanes", IsComplex = true, QueryBuilderType = typeof(PlayerPerformancePositionObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "PlayerPerformancePositionType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerPerformancePositionTypeQueryBuilder WithRoleType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("roleType", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionTypeQueryBuilder ExceptRoleType()
        {
            return ExceptField("roleType");
        }

        public PlayerPerformancePositionTypeQueryBuilder WithRoleMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("roleMatchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionTypeQueryBuilder ExceptRoleMatchCount()
        {
            return ExceptField("roleMatchCount");
        }

        public PlayerPerformancePositionTypeQueryBuilder WithRoleWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("roleWinCount", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionTypeQueryBuilder ExceptRoleWinCount()
        {
            return ExceptField("roleWinCount");
        }

        public PlayerPerformancePositionTypeQueryBuilder WithLanes(PlayerPerformancePositionObjectTypeQueryBuilder playerPerformancePositionObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("lanes", alias, playerPerformancePositionObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public PlayerPerformancePositionTypeQueryBuilder ExceptLanes()
        {
            return ExceptField("lanes");
        }
    }
}
