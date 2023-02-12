using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject dialogueBox;
    private IPersonaje _personaje;
    private Dialogue _dialogue;

    private TextMeshProUGUI _opcionArma;
    private TextMeshProUGUI _infoOpciones;
    private bool _armaActivada = false;



    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
        sentences = new Queue<string>();
        _infoOpciones = dialogueBox.transform.GetChild(4).GetComponent<TextMeshProUGUI>();
        _opcionArma = dialogueBox.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>();
        
    }

    private void Update()
    {
        if (_armaActivada)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _opcionArma.gameObject.SetActive(false);
                _infoOpciones.gameObject.SetActive(false);
                _armaActivada = false;
                foreach (string sentence in _dialogue.sentencesEscopeta)
                {
                    sentences.Enqueue(sentence);
                }
                DisplayNextSentence();
            }
        }
    }

    public void StartDialogue(Dialogue dialogue, IPersonaje personaje)
    {
        _dialogue = dialogue;
        _personaje = personaje;
        dialogueBox.SetActive(true);
        nameText.text = dialogue.characterName;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        
        if (sentences.Count == 0)
        {
            EndDialogue();
            _opcionArma.gameObject.SetActive(false);
            _infoOpciones.gameObject.SetActive(false);
            _armaActivada = false;
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

        if(sentences.Count == 0)
        {
            if (_personaje.PistolaInvestigada)
            {
                _opcionArma.gameObject.SetActive(true);
                _infoOpciones.gameObject.SetActive(true);
                _armaActivada = true;
            }
            
        }
        
    }

    public void EndDialogue()
    {
        dialogueBox.gameObject.SetActive(false);
        Debug.Log("End of conversation");
        GameManager.onDialogue = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
