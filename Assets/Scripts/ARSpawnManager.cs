using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class ARSpawnManager : MonoBehaviour
{

    public GameObject arObjectToSpawn;
    public GameObject Placementindicator;

    private Pose PlacementPose;
    // Start is called before the first frame update
    void Start()
    {
        string level = LevelSelector.selectedLevel;
        Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
