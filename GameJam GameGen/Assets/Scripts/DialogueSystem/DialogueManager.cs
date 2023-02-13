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

    public Button continueButton;

    private TextMeshProUGUI _opcionArma;

    private TextMeshProUGUI _infoOpciones;

    private bool __pistolaInvestigada = false;
    private bool _wherePistola = false;
    private bool _crucifijoActivado = false;
    private bool _sogaActivada = false;
    private bool _missingCuchillo = false;
    private bool _moratonJuanActivado = false;
    private bool _narizRotaPedroActivado = false;
    private bool _nudillosMiguelAActivado = false;
    private bool _heridaJoseManuelActivado = false;
    private bool _horaMimirEstandarActivado = false;
    private bool _horaMimirAnaActivado = false;
    private bool _horaMimirJoseManuelActivado = false;
    private bool _anaTestigoJoseManuelActivado = false;
    private bool _anaTestigoMiguelAActivado = false;
    private bool _apareceJoseManuelActivado = false;
    private bool _joseCatalinaParrandaActivado = false;
    private bool _pedroLLamoActivado = false;

    //Testeo
    public Button bto1;
    public Button bto2;
    public Button bto3;
    public Button bto4;
    public Button bto5;
    public Button bto6;

    public bool bto1onUse;
    public bool bto2onUse;
    public bool bto3onUse;
    public bool bto4onUse;
    public bool bto5onUse;
    public bool bto6onUse;

    private string[] _dButton1;
    private string[] _dButton2;
    private string[] _dButton3;
    private string[] _dButton4;
    private string[] _dButton5;
    private string[] _dButton6;

    private Queue<string> sentences;

    private int _cuenta = 0;
    private int[] _turnos;
    private GameManager _gameManager;

    // Start is called before the first frame update
    private void Start()
    {
        
        _gameManager= GameObject.Find("GameManager").GetComponent<GameManager>();
        dialogueBox.SetActive(false);
        sentences = new Queue<string>();
        _infoOpciones = dialogueBox.transform.GetChild(6).GetComponent<TextMeshProUGUI>();
        _opcionArma = dialogueBox.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        #region terrorismo
        if (__pistolaInvestigada)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Pistola";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesEscopeta;
                _turnos = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Pistola";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesEscopeta;
                _turnos = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Pistola";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesEscopeta;
                _turnos = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Pistola";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesEscopeta;
                _turnos = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Pistola";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesEscopeta;
                _turnos = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Pistola";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesEscopeta;
                _turnos = _dialogue.turnosEscopeta;
                written = true;
            }
            __pistolaInvestigada = false;
        }
        if (_wherePistola)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentecesPistola;
                _turnos = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentecesPistola;
                _turnos = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentecesPistola;
                _turnos = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentecesPistola;
                _turnos = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentecesPistola;
                _turnos = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentecesPistola;
                _turnos = _dialogue.turnosPistola;
                written = true;
            }
            _wherePistola = false;
        }
        if (_crucifijoActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesCrucifijo;
                _turnos = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesCrucifijo;
                _turnos = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesCrucifijo;
                _turnos = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesCrucifijo;
                _turnos = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesCrucifijo;
                _turnos = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesCrucifijo;
                _turnos = _dialogue.turnosCrucifijo;
                written = true;
            }
            _crucifijoActivado = false;
        }
        if (_sogaActivada)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesSoga;
                _turnos = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesSoga;
                _turnos = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesSoga;
                _turnos = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesSoga;
                _turnos = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesSoga;
                _turnos = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesSoga;
                _turnos = _dialogue.turnosSoga;
                written = true;
            }
            _sogaActivada = false;
        }
        if (_missingCuchillo)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesCuchillo;
                _turnos = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesCuchillo;
                _turnos = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesCuchillo;
                _turnos = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesCuchillo;
                _turnos = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesCuchillo;
                _turnos = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesCuchillo;
                _turnos = _dialogue.turnosCuchillo;
                written = true;
            }
            _missingCuchillo = false;
        }
        if (_moratonJuanActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesMoraton;
                _turnos = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesMoraton;
                _turnos = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesMoraton;
                _turnos = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesMoraton;
                _turnos = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesMoraton;
                _turnos = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesMoraton;
                _turnos = _dialogue.turnosMoraton;
                written = true;
            }
            _moratonJuanActivado = false;
        }
        if (_narizRotaPedroActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesNarizRota;
                _turnos = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesNarizRota;
                _turnos = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesNarizRota;
                _turnos = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesNarizRota;
                _turnos = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesNarizRota;
                _turnos = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesNarizRota;
                _turnos = _dialogue.turnosNarizRota;
                written = true;
            }
            _narizRotaPedroActivado = false;
        }
        if (_nudillosMiguelAActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesNudillos;
                _turnos = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesNudillos;
                _turnos = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesNudillos;
                _turnos = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesNudillos;
                _turnos = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesNudillos;
                _turnos = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesNudillos;
                _turnos = _dialogue.turnosNudillos;
                written = true;
            }
            _nudillosMiguelAActivado = false;
        }
        if (_heridaJoseManuelActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesHerida;
                _turnos = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHerida;
                _turnos = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHerida;
                _turnos = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHerida;
                _turnos = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHerida;
                _turnos = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHerida;
                _turnos = _dialogue.turnosHerida;
                written = true;
            }
            _heridaJoseManuelActivado = false;
        }
        if (_horaMimirEstandarActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesHoraEstandar;
                _turnos = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHoraEstandar;
                _turnos = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHoraEstandar;
                _turnos = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHoraEstandar;
                _turnos = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHoraEstandar;
                _turnos = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHoraEstandar;
                _turnos = _dialogue.turnosHoraEstandar;
                written = true;
            }
            _horaMimirEstandarActivado = false;
        }
        
        if (_horaMimirAnaActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesHoraAna;
                _turnos = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHoraAna;
                _turnos = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHoraAna;
                _turnos = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHoraAna;
                _turnos = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHoraAna;
                _turnos = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHoraAna;
                _turnos = _dialogue.turnosHoraAna;
                written = true;
            }
            _horaMimirAnaActivado = false;
        }
        if (_horaMimirJoseManuelActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesHoraJoseManuel;
                _turnos = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHoraJoseManuel;
                _turnos = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHoraJoseManuel;
                _turnos = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHoraJoseManuel;
                _turnos = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHoraJoseManuel;
                _turnos = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHoraJoseManuel;
                _turnos = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            _horaMimirJoseManuelActivado = false;
        }
        if (_anaTestigoJoseManuelActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesAnaTestigoJoseManuel;
                _turnos = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesAnaTestigoJoseManuel;
                _turnos = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesAnaTestigoJoseManuel;
                _turnos = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesAnaTestigoJoseManuel;
                _turnos = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesAnaTestigoJoseManuel;
                _turnos = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesAnaTestigoJoseManuel;
                _turnos = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            _anaTestigoJoseManuelActivado = false;
        }
        if (_anaTestigoMiguelAActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel 햚gel";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesAnaTestigoMiguel;
                _turnos = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel 햚gel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesAnaTestigoMiguel;
                _turnos = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel 햚gel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesAnaTestigoMiguel;
                _turnos = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel 햚gel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesAnaTestigoMiguel;
                _turnos = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel 햚gel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesAnaTestigoMiguel;
                _turnos = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel 햚gel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesAnaTestigoMiguel;
                _turnos = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            _anaTestigoMiguelAActivado = false;
        }
        if (_apareceJoseManuelActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Cuerpo Jose Manuel";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesApareceJoseManuel;
                _turnos = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Cuerpo Jose Manuel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesApareceJoseManuel;
                _turnos = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Cuerpo Jose Manuel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesApareceJoseManuel;
                _turnos = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Cuerpo Jose Manuel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesApareceJoseManuel;
                _turnos = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Cuerpo Jose Manuel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesApareceJoseManuel;
                _turnos = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Cuerpo Jose Manuel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesApareceJoseManuel;
                _turnos = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            _apareceJoseManuelActivado = false;
        }
        if (_joseCatalinaParrandaActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesJoseCatalinaParranda;
                _turnos = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesJoseCatalinaParranda;
                _turnos = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesJoseCatalinaParranda;
                _turnos = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesJoseCatalinaParranda;
                _turnos = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesJoseCatalinaParranda;
                _turnos = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesJoseCatalinaParranda;
                _turnos = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            _joseCatalinaParrandaActivado = false;
        }
        if (_pedroLLamoActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "LLamada";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesPedroLlamo;
                _turnos = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "LLamada";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesPedroLlamo;
                _turnos = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "LLamada";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesPedroLlamo;
                _turnos = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "LLamada";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesPedroLlamo;
                _turnos = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "LLamada";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesPedroLlamo;
                _turnos = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "LLamada";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesPedroLlamo;
                _turnos = _dialogue.turnosPedroLlamo;
                written = true;
            }
            _pedroLLamoActivado = false;
        }
        #endregion
    }

    public void StartDialogue(Dialogue dialogue, IPersonaje personaje)
    {
        _dialogue = dialogue;
        _personaje = personaje;
        _turnos = dialogue.turnosBasic;
        dialogueBox.SetActive(true);
        nameText.text = dialogue.charactersNames[_turnos[0]];
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

            _cuenta = 0;
            EndDialogue();
            //_opcionArma.gameObject.SetActive(false);
            //_infoOpciones.gameObject.SetActive(false);
            //_armaActivada = false;
            return;
        }

        continueButton.GetComponentInChildren<TextMeshProUGUI>().text = "Continuar";
        string sentence = sentences.Dequeue();
        _cuenta++;
        nameText.text = _dialogue.charactersNames[_turnos[_cuenta-1]];
        dialogueText.text = sentence;

        if (sentences.Count == 0)
        {
            continueButton.GetComponentInChildren<TextMeshProUGUI>().text = "Salir";
            _cuenta = 0;
            #region Muchos ifs

            if (_personaje.PistolaInvestigada)
            {
                //_opcionArma.gameObject.SetActive(true);
                //_infoOpciones.gameObject.SetActive(true);
                __pistolaInvestigada = true;
            }
            if (_personaje.wherePistola)
            {
                _wherePistola = true;
            }
            if (_personaje.crucifijoInvestigado)
            {
                _crucifijoActivado = true;
            }
            if (_personaje.sogaInvestigada)
            {
                _sogaActivada = true;
            }
            if (_personaje.missingCuchillo)
            {
                _missingCuchillo = true;
            }
            if (_personaje.moratonJuanInvestigado)
            {
                _moratonJuanActivado = true;
            }
            if (_personaje.narizRotaPedroInvestigada)
            {
                _narizRotaPedroActivado = true;
            }
            if (_personaje.nudillosMiguelAInvestigados)
            {
                _nudillosMiguelAActivado = true;
            }
            if (_personaje.heridaJoseManuel)
            {
                _heridaJoseManuelActivado = true;
            }
            if (_personaje.horaMimirEstandar)
            {
                _horaMimirEstandarActivado = true;
            }
            if (_personaje.horaMimirAna)
            {
                _horaMimirAnaActivado = true;
            }
            if (_personaje.horaMimirJoseManuel)
            {
                _horaMimirJoseManuelActivado = true;
            }
            if (_personaje.anaTestigoJoseManuel)
            {
                _anaTestigoJoseManuelActivado = true;
            }
            if (_personaje.anaTestigoMiguelA)
            {
                _anaTestigoMiguelAActivado = true;
            }
            if (_personaje.apareceJoseManuel)
            {
                _apareceJoseManuelActivado = true;
            }
            if (_personaje.joseCatalinaParranda)
            {
                _joseCatalinaParrandaActivado = true;
            }
            if (_personaje.pedroLlamo)
            {
                _pedroLLamoActivado = true;
            }

            #endregion Muchos ifs
        }
    }

    public void EndDialogue()
    {
        dialogueBox.gameObject.SetActive(false);
        Debug.Log("End of conversation");
        Time.timeScale= 1.0f;
        GameManager.onDialogue = false;
        Cursor.lockState = CursorLockMode.Locked;
        Reset();
    }

    #region BotonesEleccion

    public void button1()
    {
        foreach (string sentence in _dButton1)
        {
            sentences.Enqueue(sentence);
        }
        UpdateCharBools(bto1.GetComponentInChildren<TextMeshProUGUI>().text);
        DisplayNextSentence();
        Reset();
    }

    public void button2()
    {
        foreach (string sentence in _dButton2)
        {
            sentences.Enqueue(sentence);
        }
        UpdateCharBools(bto2.GetComponentInChildren<TextMeshProUGUI>().text);
        DisplayNextSentence();
        Reset();
    }

    public void button3()
    {
        foreach (string sentence in _dButton3)
        {
            sentences.Enqueue(sentence);
        }
        UpdateCharBools(bto3.GetComponentInChildren<TextMeshProUGUI>().text);
        DisplayNextSentence();
        Reset();
    }

    public void button4()
    {
        foreach (string sentence in _dButton4)
        {
            sentences.Enqueue(sentence);
        }
        UpdateCharBools(bto4.GetComponentInChildren<TextMeshProUGUI>().text);
        DisplayNextSentence();
        Reset();
    }

    public void button5()
    {
        foreach (string sentence in _dButton5)
        {
            sentences.Enqueue(sentence);
        }
        UpdateCharBools(bto5.GetComponentInChildren<TextMeshProUGUI>().text);
        DisplayNextSentence();
        Reset();
    }

    public void button6()
    {
        foreach (string sentence in _dButton6)
        {
            sentences.Enqueue(sentence);
        }
        UpdateCharBools(bto6.GetComponentInChildren<TextMeshProUGUI>().text);
        DisplayNextSentence();
        Reset();
    }

    #endregion BotonesEleccion

    public void Reset()
    {
        bto1onUse = false;
        bto1.gameObject.SetActive(false);
        bto2onUse = false;
        bto2.gameObject.SetActive(false);
        bto3onUse = false;
        bto3.gameObject.SetActive(false);
        bto4onUse = false;
        bto4.gameObject.SetActive(false);
        bto5onUse = false;
        bto5.gameObject.SetActive(false);
        bto6onUse = false;
        bto6.gameObject.SetActive(false);
    }

    public void UpdateCharBools(string s)
    {
        switch (s)
        {
            case "Pistola":
                _gameManager.updateCharacter("Moraton");
                break;
            default:
                break;
        }
    }
}