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
    public partial class BattlepassPredictionIdValueTypeQueryBuilder : GraphQlQueryBuilder<BattlepassPredictionIdValueTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "matchCount" }
            };

        protected override string TypeName { get { return "BattlepassPredictionIdValueType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public BattlepassPredictionIdValueTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionIdValueTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public BattlepassPredictionIdValueTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public BattlepassPredictionIdValueTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }
    }
}
