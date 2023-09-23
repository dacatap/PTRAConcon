using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public GameObject TextDump;
    public bool isShown;
    // Start is called before the first frame update
    void Start()
    {
        TextDump.SetActive(false);
        isShown = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PopUpActive(){
        TextDump.SetActive(true);
        isShown = true;
    }

    public void PopUpUnactive(){
        TextDump.SetActive(false);
        isShown= false;
    }
}
