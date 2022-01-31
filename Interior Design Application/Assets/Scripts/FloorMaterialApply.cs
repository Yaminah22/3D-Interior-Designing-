using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMaterialApply : MonoBehaviour
{
    public GameObject floor;
    public Renderer render;
    public Texture TextureNew;
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("floor");
        render = floor.GetComponent<Renderer>();
    }

   
    public void applyFloorTexture()
    {
        render.material.SetTexture("_MainTex", TextureNew);
    }
}
