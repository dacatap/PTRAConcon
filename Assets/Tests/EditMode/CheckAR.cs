using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CheckAR
{
    public GameObject ARSession;
    public GameObject ArSessionOrigin;
    // A Test behaves as an ordinary method
    [Test]
    public void CheckARSession(){
        ARSession = GameObject.Find("AR Session");
        Assert.That(ARSession.activeInHierarchy, Is.True);
    }
    [Test]
    public void CheckARSessionOrigin(){
        ArSessionOrigin = GameObject.Find("AR Session Origin");
        Assert.That(ArSessionOrigin.activeInHierarchy, Is.True);
    }
}
