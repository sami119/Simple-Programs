﻿using System;
using NUnit.Framework;

[TestFixture]
public class RectangleStats
{
    [Test]
    public void TestMethod()
    {
        Type baseClass = typeof(Shape);
        Type derived = typeof(Circle);

        Assert.IsTrue(derived.BaseType == baseClass);
    }
}
