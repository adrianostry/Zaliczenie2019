﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WielkieKino.Dane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WielkieKino.Dane.Tests
{
    [TestClass()]
    public class MetodyPomocniczeTests
    {
        [TestMethod()]
        public void CzyMoznaKupicBiletTest()
        {
            MetodyPomocnicze metodyPomocnicze = new MetodyPomocnicze();
            bool czyMoznaKupicBilet = metodyPomocnicze.CzyMoznaKupicBilet(SkladDanych.Bilety, SkladDanych.Seanse[0], 10, 10);
            Assert.AreEqual(true, czyMoznaKupicBilet);
        }

        [TestMethod()]
        public void CzyMoznaDodacSeansTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LiczbaWolnychMiejscWSaliTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalkowitePrzychodyZBiletowTest()
        {
            Assert.Fail();
        }
    }
}