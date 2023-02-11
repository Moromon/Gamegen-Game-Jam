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
            Talk();
        }
    }

    private void Talk()
    {
        //Activar ui
        if (pistolaInvestigada)
        {
            
        }
        trigger.TriggerDialogue(this);
        
    }
    public void Updated(string s)
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