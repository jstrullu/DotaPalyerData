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
    public partial class Ti2020CustomGamePlayerBlessingObjectTypeQueryBuilder : GraphQlQueryBuilder<Ti2020CustomGamePlayerBlessingObjectTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "type" },
                new FieldMetadata { Name = "value", IsComplex = true }
            };

        protected override string TypeName { get { return "TI2020CustomGamePlayerBlessingObjectType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public Ti2020CustomGamePlayerBlessingObjectTypeQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGamePlayerBlessingObjectTypeQueryBuilder ExceptType()
        {
            return ExceptField("type");
        }

        public Ti2020CustomGamePlayerBlessingObjectTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public Ti2020CustomGamePlayerBlessingObjectTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }
    }
}
