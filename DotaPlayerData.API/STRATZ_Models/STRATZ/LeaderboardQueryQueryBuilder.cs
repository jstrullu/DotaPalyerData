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
    public partial class LeaderboardQueryQueryBuilder : GraphQlQueryBuilder<LeaderboardQueryQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "season", IsComplex = true, QueryBuilderType = typeof(SteamAccountSeasonActiveLeaderboardTypeQueryBuilder) },
                new FieldMetadata { Name = "dotaPlus", IsComplex = true, QueryBuilderType = typeof(PlayerHeroDotaPlusLeaderboardRankResponseTypeQueryBuilder) },
                new FieldMetadata { Name = "dotaPlusWeek", IsComplex = true, QueryBuilderType = typeof(DotaPlusWeekTypeQueryBuilder) },
                new FieldMetadata { Name = "dotaPlusTopLevels", IsComplex = true, QueryBuilderType = typeof(HeroDotaPlusLeaderboardRankTopTypeQueryBuilder) },
                new FieldMetadata { Name = "battlePass", IsComplex = true, QueryBuilderType = typeof(PlayerBattlePassResponseTypeQueryBuilder) },
                new FieldMetadata { Name = "battlePassGroupBy", IsComplex = true, QueryBuilderType = typeof(PlayerBattlePassGroupByTypeQueryBuilder) },
                new FieldMetadata { Name = "coaching", IsComplex = true, QueryBuilderType = typeof(PlayerCoachingLeaderboardResponseTypeQueryBuilder) },
                new FieldMetadata { Name = "guild", IsComplex = true, QueryBuilderType = typeof(GuildTypeQueryBuilder) },
                new FieldMetadata { Name = "hero", IsComplex = true, QueryBuilderType = typeof(PlayerLeaderBoardByHeroTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LeaderboardQuery"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeaderboardQueryQueryBuilder WithSeason(SteamAccountSeasonActiveLeaderboardTypeQueryBuilder steamAccountSeasonActiveLeaderboardTypeQueryBuilder, QueryBuilderParameter<FilterSeasonLeaderboardRequestType> request = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (request != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );

            return WithObjectField("season", alias, steamAccountSeasonActiveLeaderboardTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptSeason()
        {
            return ExceptField("season");
        }

        public LeaderboardQueryQueryBuilder WithDotaPlus(PlayerHeroDotaPlusLeaderboardRankResponseTypeQueryBuilder playerHeroDotaPlusLeaderboardRankResponseTypeQueryBuilder, QueryBuilderParameter<object> heroId = null, QueryBuilderParameter<FilterLeaderboardOrder?> orderBy = null, QueryBuilderParameter<object> level = null, QueryBuilderParameter<int?> skip = null, QueryBuilderParameter<int?> take = null, string alias = null, IncludeDirective include = null, SkipDirective skipDirective = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (heroId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "heroId", ArgumentValue = heroId} );

            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "orderBy", ArgumentValue = orderBy} );

            if (level != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "level", ArgumentValue = level} );

            if (skip != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "skip", ArgumentValue = skip} );

            if (take != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "take", ArgumentValue = take} );

            return WithObjectField("dotaPlus", alias, playerHeroDotaPlusLeaderboardRankResponseTypeQueryBuilder, new GraphQlDirective[] { include, skipDirective }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptDotaPlus()
        {
            return ExceptField("dotaPlus");
        }

        public LeaderboardQueryQueryBuilder WithDotaPlusWeek(DotaPlusWeekTypeQueryBuilder dotaPlusWeekTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("dotaPlusWeek", alias, dotaPlusWeekTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeaderboardQueryQueryBuilder ExceptDotaPlusWeek()
        {
            return ExceptField("dotaPlusWeek");
        }

        public LeaderboardQueryQueryBuilder WithDotaPlusTopLevels(HeroDotaPlusLeaderboardRankTopTypeQueryBuilder heroDotaPlusLeaderboardRankTopTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("dotaPlusTopLevels", alias, heroDotaPlusLeaderboardRankTopTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeaderboardQueryQueryBuilder ExceptDotaPlusTopLevels()
        {
            return ExceptField("dotaPlusTopLevels");
        }

        public LeaderboardQueryQueryBuilder WithBattlePass(PlayerBattlePassResponseTypeQueryBuilder playerBattlePassResponseTypeQueryBuilder, QueryBuilderParameter<object> eventId = null, QueryBuilderParameter<string> countryCode = null, QueryBuilderParameter<IEnumerable<int?>> levels = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (eventId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "eventId", ArgumentValue = eventId} );

            if (countryCode != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "countryCode", ArgumentValue = countryCode} );

            if (levels != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "levels", ArgumentValue = levels} );

            return WithObjectField("battlePass", alias, playerBattlePassResponseTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptBattlePass()
        {
            return ExceptField("battlePass");
        }

        public LeaderboardQueryQueryBuilder WithBattlePassGroupBy(PlayerBattlePassGroupByTypeQueryBuilder playerBattlePassGroupByTypeQueryBuilder, QueryBuilderParameter<PlayerBattlePassGroupByEnum> groupBy, QueryBuilderParameter<int> playerCountAt, QueryBuilderParameter<object> eventId = null, QueryBuilderParameter<string> countryCode = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "groupBy", ArgumentValue = groupBy} );
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "playerCountAt", ArgumentValue = playerCountAt} );
            if (eventId != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "eventId", ArgumentValue = eventId} );

            if (countryCode != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "countryCode", ArgumentValue = countryCode} );

            return WithObjectField("battlePassGroupBy", alias, playerBattlePassGroupByTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptBattlePassGroupBy()
        {
            return ExceptField("battlePassGroupBy");
        }

        public LeaderboardQueryQueryBuilder WithCoaching(PlayerCoachingLeaderboardResponseTypeQueryBuilder playerCoachingLeaderboardResponseTypeQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> levels = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (levels != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "levels", ArgumentValue = levels} );

            return WithObjectField("coaching", alias, playerCoachingLeaderboardResponseTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptCoaching()
        {
            return ExceptField("coaching");
        }

        public LeaderboardQueryQueryBuilder WithGuild(GuildTypeQueryBuilder guildTypeQueryBuilder, QueryBuilderParameter<FilterLeaderboardGuildRequestType> request = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (request != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );

            return WithObjectField("guild", alias, guildTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptGuild()
        {
            return ExceptField("guild");
        }

        public LeaderboardQueryQueryBuilder WithHero(PlayerLeaderBoardByHeroTypeQueryBuilder playerLeaderBoardByHeroTypeQueryBuilder, QueryBuilderParameter<FilterLeaderboardHeroRequestType> request = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            var args = new List<QueryBuilderArgumentInfo>();
            if (request != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "request", ArgumentValue = request} );

            return WithObjectField("hero", alias, playerLeaderBoardByHeroTypeQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public LeaderboardQueryQueryBuilder ExceptHero()
        {
            return ExceptField("hero");
        }
    }
}
