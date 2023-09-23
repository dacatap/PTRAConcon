using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public static string selectedLevel;
    public int level;
    public Text levelText;
    void Start()
    {
        switch(level){
            case 1:
                levelText.text = "Dunas";
                break;
            case 2:
                levelText.text = "Humedales";
                break;
            case 3:
                levelText.text = "Cubo";
                break;
            case 4:
                levelText.text = "Cilindro";
                break;
        }
    }

    public void OpenScene(){
        selectedLevel = level.ToString();
        SceneManager.LoadScene("ARScene"+selectedLevel);
    }
}
