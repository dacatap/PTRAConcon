using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DynamicBackground : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public RectTransform background;

    public int paddingX;
    public int paddingY;
    // Update is called once per frame
    void Update()
    {
        UpdateBackgroundSize();   
    }

    void UpdateBackgroundSize(){
        
        Vector2 textSize = textMesh.GetRenderedValues();

        background.sizeDelta = textSize + new Vector2(paddingX, paddingY);
    }
}
