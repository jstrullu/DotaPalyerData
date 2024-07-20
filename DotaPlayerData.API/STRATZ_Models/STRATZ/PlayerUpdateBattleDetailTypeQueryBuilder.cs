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
    public partial class PlayerUpdateBattleDetailTypeQueryBuilder : GraphQlQueryBuilder<PlayerUpdateBattleDetailTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "damageMinMax" },
                new FieldMetadata { Name = "damageBonus" },
                new FieldMetadata { Name = "hpRegen" },
                new FieldMetadata { Name = "mpRegen" }
            };

        protected override string TypeName { get { return "PlayerUpdateBattleDetailType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerUpdateBattleDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder WithDamageMinMax(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damageMinMax", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder ExceptDamageMinMax()
        {
            return ExceptField("damageMinMax");
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder WithDamageBonus(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("damageBonus", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder ExceptDamageBonus()
        {
            return ExceptField("damageBonus");
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder WithHpRegen(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("hpRegen", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder ExceptHpRegen()
        {
            return ExceptField("hpRegen");
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder WithMpRegen(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("mpRegen", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerUpdateBattleDetailTypeQueryBuilder ExceptMpRegen()
        {
            return ExceptField("mpRegen");
        }
    }
}
