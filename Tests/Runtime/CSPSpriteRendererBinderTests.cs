using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CSPSpriteRendererBinderTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void CSPSpriteRendererBinderTestsSimplePasses()
    {
        Assert.AreEqual(1 == 1);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CSPSpriteRendererBinderTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
