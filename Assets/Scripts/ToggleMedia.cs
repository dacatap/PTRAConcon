using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMedia : MonoBehaviour
{
    public GameObject Dump;
    public GameObject Media;
    public bool isShown;
    // Start is called before the first frame update
    void Start()
    {
        Media.SetActive(false);
        isShown = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Mediaclick(){
        if(isShown == false){
            MediaActive();
        }
        else{
            MediaUnactive();
        }
    }
    public void MediaActive(){
        Media.SetActive(true);
        Dump.SetActive(false);
        isShown = true;
    }

    public void MediaUnactive(){
        Media.SetActive(false);
        Dump.SetActive(true);
        isShown = false;
    }
    
}
