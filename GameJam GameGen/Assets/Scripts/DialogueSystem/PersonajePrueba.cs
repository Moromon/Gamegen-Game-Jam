using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.VFX;

public abstract class PersonajePrueba :  MonoBehaviour, IPersonaje
{
    protected bool identificacion = false;
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
    protected bool chusoSotano = false;
    protected bool anaMiguel = false;
    protected bool chaqueta = false;

    public DialogueTrigger trigger;

    private GameObject _player;

    bool IPersonaje.Identificacion { get => identificacion; set => identificacion = value; }
    bool IPersonaje.PistolaInvestigada { get => pistolaInvestigada; set => pistolaInvestigada = value; }
    bool IPersonaje.wherePistola { get => wherePistola; set => wherePistola = value; }
    bool IPersonaje.crucifijoInvestigado { get => crucifijoInvestigado; set => crucifijoInvestigado = value; }
    bool IPersonaje.sogaInvestigada { get => sogaInvestigada; set => sogaInvestigada = value; }
    bool IPersonaje.missingCuchillo { get => missingCuchillo; set => missingCuchillo = value; }
    bool IPersonaje.moratonJuanInvestigado { get => moratonJuanInvestigado; set => moratonJuanInvestigado = value; }
    bool IPersonaje.narizRotaPedroInvestigada { get => narizRotaPedroInvestigada; set => narizRotaPedroInvestigada = value; }
    bool IPersonaje.nudillosMiguelAInvestigados { get => nudillosMiguelAInvestigados; set => nudillosMiguelAInvestigados = value; }
    bool IPersonaje.heridaJoseManuel { get => heridaJoseManuel; set => heridaJoseManuel = value; }
    bool IPersonaje.horaMimirEstandar { get => horaMimirEstandar; set => horaMimirEstandar = value; }
    bool IPersonaje.horaMimirAna { get => horaMimirAna; set => horaMimirAna = value; }
    bool IPersonaje.horaMimirJoseManuel { get => horaMimirJoseManuel; set => horaMimirJoseManuel = value; }
    bool IPersonaje.anaTestigoJoseManuel { get => anaTestigoJoseManuel; set => anaTestigoJoseManuel = value; }
    bool IPersonaje.anaTestigoMiguelA { get => anaTestigoMiguelA; set => anaTestigoMiguelA = value; }
    bool IPersonaje.apareceJoseManuel { get => apareceJoseManuel; set => apareceJoseManuel = value; }
    bool IPersonaje.joseCatalinaParranda { get => joseCatalinaParranda; set => joseCatalinaParranda = value; }
    bool IPersonaje.pedroLlamo { get => pedroLlamo; set => pedroLlamo = value; }

    bool IPersonaje.chusoSotano { get => chusoSotano; set => chusoSotano = value; }

    bool IPersonaje.anaMiguel { get => anaMiguel; set => anaMiguel = value; }
    bool IPersonaje.chaqueta { get => chaqueta; set => chaqueta = value; }


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
        if (Input.GetKeyDown(KeyCode.F) && !GameManager.onDialogue)
        {
            Vector3 a = new Vector3(transform.position.x, 0, transform.position.z);
            Vector3 b = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
            if (Vector3.Distance(a, b) < 6f)
            {
                Talk();
            }
        }
    }

    public abstract void Talk();

    public abstract void Updated(string s);
    
}