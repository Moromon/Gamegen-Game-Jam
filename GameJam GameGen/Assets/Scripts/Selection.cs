using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selection : MonoBehaviour
{
    public Material highlightMaterial;
    public Material selectionMaterial;

    private Material originalMaterialHighlight;
    private Material originalMaterialSelection;
    private Transform highlight;
    private Transform selection;
    private RaycastHit raycastHit;

    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }

    void Update()
    {
        // Highlight
        if (highlight != null)
        {
            highlight.GetComponent<MeshRenderer>().sharedMaterial = originalMaterialHighlight;
            highlight = null;
        }
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit) && !GameManager.onDialogue) //Make sure you have EventSystem in the hierarchy before using EventSystem
        {
            highlight = raycastHit.transform;
            if (highlight.CompareTag("Selectables"))
            {
                Vector3 a = new Vector3(highlight.position.x, 0, highlight.position.z);
                Vector3 b = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
                float distance = Vector3.Distance(a, b);
  
                if (highlight.GetComponent<MeshRenderer>().material != highlightMaterial && distance<4f)
                {
                    originalMaterialHighlight = highlight.GetComponent<MeshRenderer>().material;
                    highlight.GetComponent<MeshRenderer>().material = highlightMaterial;
                }
                else
                {
                    highlight = null;
                }
            }
            else
            {
                highlight = null;
            }
        }

        //// Selection
        //if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        //{
        //    if (highlight)
        //    {
        //        if (selection != null)
        //        {
        //            selection.GetComponent<MeshRenderer>().material = originalMaterialSelection;
        //        }
        //        selection = raycastHit.transform;
        //        if (selection.GetComponent<MeshRenderer>().material != selectionMaterial)
        //        {
        //            originalMaterialSelection = originalMaterialHighlight;
        //            selection.GetComponent<MeshRenderer>().material = selectionMaterial;
        //        }
        //        highlight = null;
        //    }
        //    else
        //    {
        //        if (selection)
        //        {
        //            selection.GetComponent<MeshRenderer>().material = originalMaterialSelection;
        //            selection = null;
        //        }
        //    }
        //}

    }

}