using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
  public class ScoreTest
  {
    [Test]
    public void AddTest()
    {
      // given: two scores
      var score1 = new Score() { Hundreds = 3, Tens = 1, Ones = 5 };
      var score2 = new Score() { Hundreds = 8, Tens = 1, Ones = 8 };

      // when: adding the scores
      var score3 = score1 + score2;

      // then: correctly added
      Assert.That(score3.Thousands, Is.EqualTo(1));
      Assert.That(score3.Hundreds, Is.EqualTo(1));
      Assert.That(score3.Tens, Is.EqualTo(3));
      Assert.That(score3.Ones, Is.EqualTo(3));
    }
  }
}
