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
    public partial class ItemTypeQueryBuilder : GraphQlQueryBuilder<ItemTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "name" },
                new FieldMetadata { Name = "displayName" },
                new FieldMetadata { Name = "shortName" },
                new FieldMetadata { Name = "isSupportFullItem" },
                new FieldMetadata { Name = "language", IsComplex = true, QueryBuilderType = typeof(ItemLanguageTypeQueryBuilder) },
                new FieldMetadata { Name = "stat", IsComplex = true, QueryBuilderType = typeof(ItemStatTypeQueryBuilder) },
                new FieldMetadata { Name = "attributes", IsComplex = true, QueryBuilderType = typeof(ItemAttributeTypeQueryBuilder) },
                new FieldMetadata { Name = "components", IsComplex = true, QueryBuilderType = typeof(ItemComponentTypeQueryBuilder) },
                new FieldMetadata { Name = "image" }
            };

        protected override string TypeName { get { return "ItemType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ItemTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public ItemTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public ItemTypeQueryBuilder WithDisplayName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displayName", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptDisplayName()
        {
            return ExceptField("displayName");
        }

        public ItemTypeQueryBuilder WithShortName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("shortName", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptShortName()
        {
            return ExceptField("shortName");
        }

        public ItemTypeQueryBuilder WithIsSupportFullItem(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isSupportFullItem", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptIsSupportFullItem()
        {
            return ExceptField("isSupportFullItem");
        }

        public ItemTypeQueryBuilder WithLanguage(ItemLanguageTypeQueryBuilder itemLanguageTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("language", alias, itemLanguageTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptLanguage()
        {
            return ExceptField("language");
        }

        public ItemTypeQueryBuilder WithStat(ItemStatTypeQueryBuilder itemStatTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("stat", alias, itemStatTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptStat()
        {
            return ExceptField("stat");
        }

        public ItemTypeQueryBuilder WithAttributes(ItemAttributeTypeQueryBuilder itemAttributeTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("attributes", alias, itemAttributeTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptAttributes()
        {
            return ExceptField("attributes");
        }

        public ItemTypeQueryBuilder WithComponents(ItemComponentTypeQueryBuilder itemComponentTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("components", alias, itemComponentTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptComponents()
        {
            return ExceptField("components");
        }

        public ItemTypeQueryBuilder WithImage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("image", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemTypeQueryBuilder ExceptImage()
        {
            return ExceptField("image");
        }
    }
}