using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public static string selectedLevel;
    public string level;
    public Text levelText;
    void Start()
    {
        levelText.text = level.ToString();
    }

    public void OpenScene(){
        selectedLevel = level;
        SceneManager.LoadScene("ARScene");
    }
}
