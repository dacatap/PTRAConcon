using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public static string selectedLevel;
    public int level;

    public void OpenScene(){
        selectedLevel = level.ToString();
        SceneManager.LoadScene("ARScene"+selectedLevel);
    }
}
