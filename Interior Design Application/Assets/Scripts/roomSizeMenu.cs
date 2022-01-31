using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roomSizeMenu : MonoBehaviour
{
    public void load(string size)
    {
        StaticVariable.size = size;
        SceneManager.LoadScene("Design Window");
    }
}
