using UnityEngine;

public abstract class PersonajePrueba :  MonoBehaviour, IPersonaje
{
    protected bool pistolaInvestigada = false;
    protected bool wherePistola = false;
    protected bool crucifijoInvestigado = false;
    protected bool sogaInvestigada = false;
    protected bool missingCuchillo = false;

    protected bool moratonJuanInvestigado = false;
    protected bool narizRotaPedroInvestigada = false;
    protected bool nudillosMiguelAInvestigados = false;
    protected bool heridaJoseManuel = false;

    protected bool horaMimirEstandar = false;
    protected bool horaMimirAna = false;
    protected bool horaMimirJoseManuel = false;

    protected bool anaTestigoJoseManuel = false;
    protected bool anaTestigoMiguelA = false;
    protected bool apareceJoseManuel = false;
    protected bool joseCatalinaParranda = false;
    protected bool pedroLlamo = false;

    public DialogueTrigger trigger;

    private GameObject _player;

    bool IPersonaje.PistolaInvestigada { get => pistolaInvestigada; set => pistolaInvestigada = value; }

    private void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    protected void OnMouseOver()
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

    public abstract void Talk();

    public abstract void Updated(string s);
    
}