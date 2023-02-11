using UnityEngine;

public class PersonajePrueba : MonoBehaviour
{
    public bool pistolaInvestigada = false;
    public DialogueTrigger trigger;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            talk();
        }
    }

    private void talk()
    {
        //Activar ui
        trigger.TriggerDialogue();
        if (pistolaInvestigada)
        {
            Debug.Log("pium");
        }
    }
    public void updated(string s)
    {
        switch (s)
        {
            case "pistola":
                pistolaInvestigada=true;
                break;
            default: break;
        }
    }
}