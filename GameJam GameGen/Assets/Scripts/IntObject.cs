using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObject : MonoBehaviour
{
    public string nameObj;
    [TextArea(10, 15)]
    public string description = "";
    public bool recogido;
    public GameObject prefab;

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.LogWarning("Añadir recoger objeto y que aparezca por pantalla");
        }
    }
}
