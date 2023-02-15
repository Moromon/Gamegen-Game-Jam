using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

[System.Serializable]
public class WinLoseSceneScript : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] textosTutorial;
    private int cont = 0;
    public TextMeshProUGUI texto;
    public Button button;

    public void Start()
    {
        texto.text = textosTutorial[cont];
    }
    public void SkipText()
    {
        if (cont >= textosTutorial.Length - 1)
        {
            SceneManager.LoadScene(0);
        }
        else if (cont < textosTutorial.Length - 1)
        {
            cont++;
            texto.text = textosTutorial[cont];
        }
        if (cont == textosTutorial.Length - 1)
        {
            button.GetComponentInChildren<TextMeshProUGUI>().text = "Volver";
        }
    }
}
