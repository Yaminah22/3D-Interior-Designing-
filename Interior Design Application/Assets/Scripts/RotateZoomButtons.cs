using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RotateZoomButtons : MonoBehaviour,IPointerClickHandler
{
    public GameObject room;
    public GameObject[] walls;

    public GameObject floor;
    public Renderer rendererFloor;
    public Texture TextureDefaultFloor;

    public Renderer[] rendererWalls;
    public Texture TextureDefaultWalls;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.name == "rotateButton")
        {
            room.transform.Rotate(0f, 90f, 0f, Space.World);
        }
        else if (this.name == "wallDown")
        {
            if (walls[0].activeInHierarchy == true)
            {
                foreach(GameObject wall in walls)
                {
                    wall.SetActive(false);
                }
            }
            else
            {
                foreach (GameObject wall in walls)
                {
                    wall.SetActive(true);
                }
            }
        }
        else if (this.name == "removeTile")
        {
            rendererFloor.material.SetTexture("_MainTex", TextureDefaultFloor);
        }
        else if (this.name == "removePaint")
        {
            int count = 0;
            foreach (GameObject wall in walls)
            {
                rendererWalls[count].material.SetTexture("_MainTex", TextureDefaultWalls);
                count++;
            }
            
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("floor");
        rendererFloor = floor.GetComponent<Renderer>();
        int count = 0;
        foreach(GameObject wall in walls)
        {
            rendererWalls[count] = wall.GetComponent<Renderer>();
            count++;
        }
    }

}
