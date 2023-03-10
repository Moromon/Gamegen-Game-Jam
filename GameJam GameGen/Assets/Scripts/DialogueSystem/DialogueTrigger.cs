using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dialogue;

    public void TriggerDialogue(IPersonaje personaje)
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, personaje);
        GameManager.onDialogue = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
