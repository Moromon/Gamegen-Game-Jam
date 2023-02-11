using UnityEngine;

public class PersonajePrueba : MonoBehaviour
{
    public bool pistolaInvestigada = false;

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
        Debug.Log("Hablo");
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