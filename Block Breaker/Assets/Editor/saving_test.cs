﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;


namespace Tests
{
public class saving_test 
{
    [Test]
        public void TestUnitaire_SavingLevelSimplePasses()
        {
            var sceneLoader = new SceneLoader();
            int ActualLevl = SceneLoader.ActualLevel();
            Assert.AreEqual(1,ActualLevl);
        }

        [Test]
        public void TestUnitaire_SavingScoreSimplePasses()
        {
            var sceneLoader = new SceneLoader();
            int Actualscore = SceneLoader.ActualScore();
            Assert.AreEqual(144,Actualscore);
        }
}
}
