using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectedMagenta : MonoBehaviour
{
    public Material highlightMaterial;
    public string tag;

    private Material[] originalMaterialHighlight;
    private Transform highlight;
    private RaycastHit raycastHit;

    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
        originalMaterialHighlight = new Material[4];
    }

    void Update()
    {
        // Highlight
        if (highlight != null)
        {
            if (highlight.childCount == 0)
            {
                highlight.GetComponent<MeshRenderer>().material = originalMaterialHighlight[0];
                highlight.GetComponent<IntObject>().highlighted = false;
            }
            else
            {
                for (int i = 0; i < highlight.childCount; i++)
                {
                    highlight.GetChild(i).GetComponent<MeshRenderer>().material = originalMaterialHighlight[i];
                }
                highlight.GetComponent<IntObject>().highlighted = false;
            }
            highlight = null;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit) && !GameManager.onDialogue) //Make sure you have EventSystem in the hierarchy before using EventSystem
        {
            highlight = raycastHit.transform;
            if (highlight.CompareTag(tag))
            {
                Vector3 a = new Vector3(highlight.position.x, 0, highlight.position.z);
                Vector3 b = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
                float distance = Vector3.Distance(a, b);

                if (!highlight.GetComponent<IntObject>().highlighted && distance < 4f)
                {
                    if (highlight.childCount == 0)
                    {
                        originalMaterialHighlight[0] = highlight.GetComponent<MeshRenderer>().material;
                        highlight.GetComponent<MeshRenderer>().material = highlightMaterial;
                        
                    }
                    else
                    {
                        for (int i = 0; i < highlight.childCount; i++)
                        {
                            originalMaterialHighlight[i] = highlight.GetChild(i).GetComponent<MeshRenderer>().material;
                            highlight.GetChild(i).GetComponent<MeshRenderer>().material = highlightMaterial;
                        }
                    }
                    highlight.GetComponent<IntObject>().highlighted = true;
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