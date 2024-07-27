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
    public partial class SteamApiDetailOutageTypeQueryBuilder : GraphQlQueryBuilder<SteamApiDetailOutageTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "secondsOffline" },
                new FieldMetadata { Name = "dateTime", IsComplex = true }
            };

        protected override string TypeName { get { return "SteamApiDetailOutageType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public SteamApiDetailOutageTypeQueryBuilder WithSecondsOffline(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("secondsOffline", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamApiDetailOutageTypeQueryBuilder ExceptSecondsOffline()
        {
            return ExceptField("secondsOffline");
        }

        public SteamApiDetailOutageTypeQueryBuilder WithDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("dateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public SteamApiDetailOutageTypeQueryBuilder ExceptDateTime()
        {
            return ExceptField("dateTime");
        }
    }
}