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
    public partial class DotaUserMutation
    {
        public bool? ReadAllFeed { get; set; }
        public bool? ValidateEmail { get; set; }
        public bool? UnsubscribeEmail { get; set; }
        public bool? UpdateProfile { get; set; }
        public bool? FollowPlayer { get; set; }
        public bool? UnfollowPlayer { get; set; }
        public bool? UpdateFollowing { get; set; }
        public bool? UpdateAllFollowing { get; set; }
        public bool? UpdateFollowingFavorite { get; set; }
        public bool? FollowLeague { get; set; }
        public bool? UnfollowLeague { get; set; }
        public bool? ApplyStratzApiKey { get; set; }
        public bool? CheckPublicDotaAccount { get; set; }
    }
}
