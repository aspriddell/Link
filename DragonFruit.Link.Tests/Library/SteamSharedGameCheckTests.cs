﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Library.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Library
{
    [TestClass]
    public class SteamSharedGameCheckTests : SteamApiTest
    {
        [TestMethod]
        public void SharedGameCheckTest()
        {
            var result = Client.GetSharedGameOwner(SteamApps.RainbowSix, 76561198304799248);

            //0 = not shared
            Assert.IsTrue(result == 0);
        }
    }
}