﻿using System.Linq;
using eZet.EveLib.EveXmlModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eZet.EveLib.Test {
    /// <summary>
    ///     Summary description for MapTest
    /// </summary>
    [TestClass]
    public class Map_Tests {
        private readonly Map _api = new Map();


        [TestMethod]
        public void TestFacWarSystems_ValidRequest_HasResult() {
            var res = _api.GetFactionWarSystems();
            Assert.IsNotNull(res.Result.SolarSystems.First());
        }

        [TestMethod]
        public void TestJumps_ValidRequest_HasResult() {
            var res = _api.GetJumps();
            Assert.AreNotEqual(0, res.Result.SolarSystems.First());
        }

        [TestMethod]
        public void TestKills_ValidRequest_HasResult() {
            var res = _api.GetKills();
            Assert.AreNotEqual(0, res.Result.SolarSystems.First());
        }

        [TestMethod]
        public void TestSovereignty_ValidRequest_HasResult() {
            var res = _api.GetSovereignty();
            Assert.IsNotNull(res.Result.SolarSystems.First());
        }

        /// <summary>
        ///     Disabled by CCP
        /// </summary>
        [TestMethod]
        public void TestSovereigntyStatus_ValidRequest_HasResult() {
            //Assert.Inconclusive("Disabled by CCP.");
            //var res = _api.GetSovereigntyStatus();
        }
    }
}