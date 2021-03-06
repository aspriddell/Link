﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Objects
{
    public class SteamSharedGameLenderInfo
    {
        /// <summary>
        /// Lender's SteamID64
        /// </summary>
        [JsonProperty("lender_steamid")]
        public ulong LenderSteamId { get; set; }
    }
}
