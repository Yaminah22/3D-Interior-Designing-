using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyingWallPaint : MonoBehaviour
{
    public GameObject[] walls;
    public Renderer[] render;
    public Texture NewColor;

    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach(GameObject wall in walls)
        {
           render[i]=wall.GetComponent<Renderer>();
            i++;
        }
    }

    public void changePaint()
    {
        int i = 0;
        foreach (GameObject wall in walls)
        {
            render[i].material.SetTexture("_MainTex", NewColor);
            i++;
        }
        
    }
}
