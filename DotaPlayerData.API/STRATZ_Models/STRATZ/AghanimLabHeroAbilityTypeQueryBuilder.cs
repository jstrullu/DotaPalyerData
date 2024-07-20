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
    public partial class AghanimLabHeroAbilityTypeQueryBuilder : GraphQlQueryBuilder<AghanimLabHeroAbilityTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "difficulty" },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "customAbilityId", IsComplex = true },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "pickCount" }
            };

        protected override string TypeName { get { return "AghanimLabHeroAbilityType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AghanimLabHeroAbilityTypeQueryBuilder WithDifficulty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("difficulty", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroAbilityTypeQueryBuilder ExceptDifficulty()
        {
            return ExceptField("difficulty");
        }

        public AghanimLabHeroAbilityTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroAbilityTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public AghanimLabHeroAbilityTypeQueryBuilder WithCustomAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("customAbilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroAbilityTypeQueryBuilder ExceptCustomAbilityId()
        {
            return ExceptField("customAbilityId");
        }

        public AghanimLabHeroAbilityTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroAbilityTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public AghanimLabHeroAbilityTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroAbilityTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public AghanimLabHeroAbilityTypeQueryBuilder WithPickCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("pickCount", alias, new GraphQlDirective[] { include, skip });
        }

        public AghanimLabHeroAbilityTypeQueryBuilder ExceptPickCount()
        {
            return ExceptField("pickCount");
        }
    }
}
