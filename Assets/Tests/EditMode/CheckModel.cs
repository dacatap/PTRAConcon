using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class CheckModel : MonoBehaviour
{
    public string Scene = SceneManager.GetActiveScene().name;
    public GameObject Model;

    [Test]
    public void CheckModel3d()
    {   
        switch(Scene){
            case "ARScene1":
                Model = GameObject.Find("dunas");
                Assert.That(Model.activeInHierarchy, Is.True);
                break;
            case "ARScene2":
                Model = GameObject.Find("humedales");
                Assert.That(Model.activeInHierarchy, Is.True);
                break;
            case "ARScene3":
                Model = GameObject.Find("muni");
                Assert.That(Model.activeInHierarchy, Is.True);
                break;
            case "ARScene4":
                Model = GameObject.Find("museo");
                Assert.That(Model.activeInHierarchy, Is.True);
                break;
            case "ARScene5":
                Model = GameObject.Find("rocaoceanica01");
                Assert.That(Model.activeInHierarchy, Is.True);
                break;
        }
    }
}
