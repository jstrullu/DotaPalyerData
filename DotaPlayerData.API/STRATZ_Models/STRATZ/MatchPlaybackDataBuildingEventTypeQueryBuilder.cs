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
    public partial class MatchPlaybackDataBuildingEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlaybackDataBuildingEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "indexId" },
                new FieldMetadata { Name = "type" },
                new FieldMetadata { Name = "hp" },
                new FieldMetadata { Name = "maxHp" },
                new FieldMetadata { Name = "positionX" },
                new FieldMetadata { Name = "positionY" },
                new FieldMetadata { Name = "isRadiant" },
                new FieldMetadata { Name = "npcId" },
                new FieldMetadata { Name = "didShrineActivate" }
            };

        protected override string TypeName { get { return "MatchPlaybackDataBuildingEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithIndexId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("indexId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptIndexId()
        {
            return ExceptField("indexId");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptType()
        {
            return ExceptField("type");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithHp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptHp()
        {
            return ExceptField("hp");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithMaxHp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("maxHp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptMaxHp()
        {
            return ExceptField("maxHp");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithIsRadiant(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isRadiant", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptIsRadiant()
        {
            return ExceptField("isRadiant");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithNpcId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("npcId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptNpcId()
        {
            return ExceptField("npcId");
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder WithDidShrineActivate(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("didShrineActivate", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlaybackDataBuildingEventTypeQueryBuilder ExceptDidShrineActivate()
        {
            return ExceptField("didShrineActivate");
        }
    }
}
