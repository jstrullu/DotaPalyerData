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
    public partial class RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder : GraphQlQueryBuilder<RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "difficulty" },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "maxScore" }
            };

        protected override string TypeName { get { return "ROSHCaptainJackIdentityStatDifficultyType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder WithDifficulty(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("difficulty", alias, new GraphQlDirective[] { include, skip });
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder ExceptDifficulty()
        {
            return ExceptField("difficulty");
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder WithMaxScore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("maxScore", alias, new GraphQlDirective[] { include, skip });
        }

        public RoshCaptainJackIdentityStatDifficultyTypeQueryBuilder ExceptMaxScore()
        {
            return ExceptField("maxScore");
        }
    }
}