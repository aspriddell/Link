﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamSharedGameCheckExtensions
    {
        /// <summary>
        /// Get the Steam Id of the owner of a shared/borrowed game, if it is being actively shared with the user (i.e. they're playing it).
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to check</param>
        /// <param name="steamId">The SteamID64 of the User "borrowing" the game</param>
        /// <returns>The Game Owners' SteamID64</returns>
        /// <remarks>The user must be currently playing the game for this to return a valid result. If 0 is returned the user either owns the game or they aren't currently playing it.</remarks>
        public static ulong GetSharedGameOwner(this SteamApiClient client, uint appId, ulong steamId)
        {
            var request = new SteamSharedGameCheckRequest(steamId, appId);
            return client.Perform<SteamSharedGameCheckResponse>(request).LenderInfo.LenderSteamId;
        }
    }
}