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
    public partial class MatchplaybackDataCourierEventObjectTypeQueryBuilder : GraphQlQueryBuilder<MatchplaybackDataCourierEventObjectTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "positionX" },
                new FieldMetadata { Name = "positionY" },
                new FieldMetadata { Name = "hp" },
                new FieldMetadata { Name = "isFlying" },
                new FieldMetadata { Name = "respawnTime" },
                new FieldMetadata { Name = "didCastBoost" },
                new FieldMetadata { Name = "item0Id" },
                new FieldMetadata { Name = "item1Id" },
                new FieldMetadata { Name = "item2Id" },
                new FieldMetadata { Name = "item3Id" },
                new FieldMetadata { Name = "item4Id" },
                new FieldMetadata { Name = "item5Id" }
            };

        protected override string TypeName { get { return "MatchplaybackDataCourierEventObjectType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithPositionX(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionX", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptPositionX()
        {
            return ExceptField("positionX");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithPositionY(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("positionY", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptPositionY()
        {
            return ExceptField("positionY");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithHp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptHp()
        {
            return ExceptField("hp");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithIsFlying(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isFlying", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptIsFlying()
        {
            return ExceptField("isFlying");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithRespawnTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("respawnTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptRespawnTime()
        {
            return ExceptField("respawnTime");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithDidCastBoost(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("didCastBoost", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptDidCastBoost()
        {
            return ExceptField("didCastBoost");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithItem0Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item0Id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptItem0Id()
        {
            return ExceptField("item0Id");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithItem1Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item1Id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptItem1Id()
        {
            return ExceptField("item1Id");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithItem2Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item2Id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptItem2Id()
        {
            return ExceptField("item2Id");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithItem3Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item3Id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptItem3Id()
        {
            return ExceptField("item3Id");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithItem4Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item4Id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptItem4Id()
        {
            return ExceptField("item4Id");
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder WithItem5Id(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("item5Id", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchplaybackDataCourierEventObjectTypeQueryBuilder ExceptItem5Id()
        {
            return ExceptField("item5Id");
        }
    }
}