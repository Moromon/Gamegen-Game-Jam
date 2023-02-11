using UnityEngine;

public class PersonajePrueba : MonoBehaviour
{
    public bool pistolaInvestigada = false;
    public DialogueTrigger trigger;

    private GameObject _player;
    private void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 a = new Vector3(transform.position.x, 0, transform.position.z);
            Vector3 b = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
            if (Vector3.Distance(a, b) < 4f)
            {
                Talk();
            }
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