using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

[System.Serializable]
public class EscenaIntermediaScript : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] textosTutorial;
    public string[] personajes;
    public int[] turnos;

    private int cont = 0;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI textoPersonajes;

    public void Start()
    {
        texto.text = textosTutorial[cont];
        textoPersonajes.text = personajes[turnos[cont]];
    }
    public void SkipText()
    {
        if (cont >= textosTutorial.Length - 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (cont < textosTutorial.Length - 1)
        {
            cont++;
            texto.text = textosTutorial[cont];
            textoPersonajes.text = personajes[turnos[cont]];
        }
    }
}
