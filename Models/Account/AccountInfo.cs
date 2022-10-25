using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Coflnet.Sky.Core;

namespace Coflnet.Sky.Commands.Shared
{
    [DataContract]
    public class AccountInfo
    {
        [DataMember(Name = "userId")]
        public int UserId;
        [DataMember(Name = "mcIds")]
        public List<string> McIds = new List<string>();

        [DataMember(Name = "conIds")]
        public HashSet<string> ConIds = new HashSet<string>();

        [DataMember(Name = "tier")]
        public AccountTier Tier;
        [DataMember(Name = "expires")]
        public DateTime ExpiresAt;
        [DataMember(Name = "activeCon")]
        public string ActiveConnectionId;

        [DataMember(Name = "lastCaptchaSolve")]
        public DateTime LastCaptchaSolve { get; set; }
        [DataMember(Name = "locale")]
        public string Locale { get; set; }
        [DataMember(Name = "timeZoneString")]
        public string timeZone { get; set; }
    }
}