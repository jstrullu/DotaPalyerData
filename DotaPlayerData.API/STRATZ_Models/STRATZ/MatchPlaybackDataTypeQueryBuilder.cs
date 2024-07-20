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
    public partial class MatchPlaybackDataTypeQueryBuilder : GraphQlQueryBuilder<MatchPlaybackDataTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "courierEvents", IsComplex = true, QueryBuilderType = typeof(MatchPlaybackDataCourierEventTypeQueryBuilder) },
                new FieldMetadata { Name = "runeEvents", IsComplex = true, QueryBuilderType = typeof(MatchPlaybackDataRuneEventTypeQueryBuilder) },
                new FieldMetadata { Name = "wardEvents", IsComplex = true, QueryBuilderType = typeof(MatchPlaybackDataWardEventTypeQueryBuilder) },
                new FieldMetadata { Name = "buildingEvents", IsComplex = true, QueryBuilderType = typeof(MatchPlaybackDataBuildingEventTypeQueryBuilder) },
                new FieldMetadata { Name = "towerDeathEvents", IsComplex = true, QueryBuilderType = typeof(MatchPlaybackDataTowerDeathEventTypeQueryBuilder) },
                new FieldMetadata { Name = "roshanEvents", IsComplex = true, QueryBuilderType = typeof(MatchPlaybackDataRoshanEventTypeQueryBuilder) },
                new FieldMetadata { Name = "radiantCaptainHeroId", IsComplex = true },
                new FieldMetadata { Name = "direCaptainHeroId", IsComplex = true }
            };

        protected override string TypeName { get { return "MatchPlaybackDataType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlaybackDataTypeQueryBuilder WithCourierEvents(MatchPlaybackDataCourierEventTypeQueryBuilder matchPlaybackDataCourierEventTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("courierEvents", alias, matchPlaybackDataCourierEventTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptCourierEvents()
        {
            return ExceptField("courierEvents");
        }

        public MatchPlaybackDataTypeQueryBuilder WithRuneEvents(MatchPlaybackDataRuneEventTypeQueryBuilder matchPlaybackDataRuneEventTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("runeEvents", alias, matchPlaybackDataRuneEventTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptRuneEvents()
        {
            return ExceptField("runeEvents");
        }

        public MatchPlaybackDataTypeQueryBuilder WithWardEvents(MatchPlaybackDataWardEventTypeQueryBuilder matchPlaybackDataWardEventTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("wardEvents", alias, matchPlaybackDataWardEventTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptWardEvents()
        {
            return ExceptField("wardEvents");
        }

        public MatchPlaybackDataTypeQueryBuilder WithBuildingEvents(MatchPlaybackDataBuildingEventTypeQueryBuilder matchPlaybackDataBuildingEventTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("buildingEvents", alias, matchPlaybackDataBuildingEventTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptBuildingEvents()
        {
            return ExceptField("buildingEvents");
        }

        public MatchPlaybackDataTypeQueryBuilder WithTowerDeathEvents(MatchPlaybackDataTowerDeathEventTypeQueryBuilder matchPlaybackDataTowerDeathEventTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("towerDeathEvents", alias, matchPlaybackDataTowerDeathEventTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptTowerDeathEvents()
        {
            return ExceptField("towerDeathEvents");
        }

        public MatchPlaybackDataTypeQueryBuilder WithRoshanEvents(MatchPlaybackDataRoshanEventTypeQueryBuilder matchPlaybackDataRoshanEventTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("roshanEvents", alias, matchPlaybackDataRoshanEventTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptRoshanEvents()
        {
            return ExceptField("roshanEvents");
        }

        public MatchPlaybackDataTypeQueryBuilder WithRadiantCaptainHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("radiantCaptainHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptRadiantCaptainHeroId()
        {
            return ExceptField("radiantCaptainHeroId");
        }

        public MatchPlaybackDataTypeQueryBuilder WithDireCaptainHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("direCaptainHeroId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataTypeQueryBuilder ExceptDireCaptainHeroId()
        {
            return ExceptField("direCaptainHeroId");
        }
    }
}
