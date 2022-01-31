using UnityEngine;

public class FurniturePlacement : MonoBehaviour
{
    [SerializeField]
    private GameObject placeableObjectPrefab;
    private Vector3 pos;
    float width = StaticVariable.width;
    float length = StaticVariable.length;
    float height = StaticVariable.height;
    public GameObject room;
    private int count=0;
    public void spawn()
    {
        pos = new Vector3(Random.Range(-length / 2, length / 2), 0, Random.Range(-width / 2, width / 2));
    }

    public void clickAddButton()
    {
        count += 1;
        spawn();
        GameObject newObjectForScene = Instantiate(placeableObjectPrefab);
        newObjectForScene.name = this.name + "object-"+count;
        newObjectForScene.transform.localPosition = new Vector3(400,174.30f,-1f)+pos;
       
       
    }
    private void Start()
    {
        room = GameObject.Find("floor");
    }
}