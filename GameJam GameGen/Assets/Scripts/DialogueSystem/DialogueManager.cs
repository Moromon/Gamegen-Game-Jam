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

    private bool _identificacion = false;
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
    private bool _chusoSotano = false;
    private bool _anaMiguel = false;
    private bool _chaquetaAna = false;

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

    private int[] turnosBto1;
    private int[] turnosBto2;
    private int[] turnosBto3;
    private int[] turnosBto4;
    private int[] turnosBto5;
    private int[] turnosBto6;

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

        if (_chaquetaAna)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Pozo";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesChaqueta;
                turnosBto1 = _dialogue.turnosChaqueta;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Pozo";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesChaqueta;
                turnosBto2 = _dialogue.turnosChaqueta;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Pozo";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesChaqueta;
                turnosBto3 = _dialogue.turnosChaqueta;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Pozo";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesChaqueta;
                turnosBto4 = _dialogue.turnosChaqueta;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Pozo";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesChaqueta;
                turnosBto5 = _dialogue.turnosChaqueta;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Pozo";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesChaqueta;
                turnosBto6 = _dialogue.turnosChaqueta;
                written = true;
            }
            _chaquetaAna = false;
        }
        if (_anaMiguel)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Miguel";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesAnaMiguel;
                turnosBto1 = _dialogue.turnosAnaMiguel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Miguel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesAnaMiguel;
                turnosBto2 = _dialogue.turnosAnaMiguel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Miguel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesAnaMiguel;
                turnosBto3 = _dialogue.turnosAnaMiguel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Miguel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesAnaMiguel;
                turnosBto4 = _dialogue.turnosAnaMiguel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Miguel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesAnaMiguel;
                turnosBto5 = _dialogue.turnosAnaMiguel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Miguel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesAnaMiguel;
                turnosBto6 = _dialogue.turnosAnaMiguel;
                written = true;
            }
            _anaMiguel = false;
        }
        if (_chusoSotano)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Sotano";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesChusoSotano;
                turnosBto1 = _dialogue.turnosChusoSotano;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Sotano";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesChusoSotano;
                turnosBto2 = _dialogue.turnosChusoSotano;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Sotano";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesChusoSotano;
                turnosBto3 = _dialogue.turnosChusoSotano;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Sotano";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesChusoSotano;
                turnosBto4 = _dialogue.turnosChusoSotano;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Sotano";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesChusoSotano;
                turnosBto5 = _dialogue.turnosChusoSotano;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Sotano";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesChusoSotano;
                turnosBto6 = _dialogue.turnosChusoSotano;
                written = true;
            }
            _chusoSotano = false;
        }
        if (__pistolaInvestigada)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Escopeta";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesEscopeta;
                turnosBto1 = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Escopeta";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesEscopeta;
                turnosBto2 = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Escopeta";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesEscopeta;
                turnosBto3 = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Escopeta";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesEscopeta;
                turnosBto4 = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Escopeta";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesEscopeta;
                turnosBto5 = _dialogue.turnosEscopeta;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Escopeta";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesEscopeta;
                turnosBto6 = _dialogue.turnosEscopeta;
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
                turnosBto1 = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentecesPistola;
                turnosBto2 = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentecesPistola;
                turnosBto3 = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentecesPistola;
                turnosBto4 = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentecesPistola;
                turnosBto5 = _dialogue.turnosPistola;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "wherePistola";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentecesPistola;
                turnosBto6 = _dialogue.turnosPistola;
                written = true;
            }
            _wherePistola = false;
        }
        if (_identificacion)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "¿Quién eres?";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesIdentificacion;
                turnosBto1 = _dialogue.turnosIdentificacion;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "¿Quién eres?";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesIdentificacion;
                turnosBto2 = _dialogue.turnosIdentificacion;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "¿Quién eres?";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesIdentificacion;
                turnosBto3 = _dialogue.turnosIdentificacion;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "¿Quién eres?";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesIdentificacion;
                turnosBto4 = _dialogue.turnosIdentificacion;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "¿Quién eres?";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesIdentificacion;
                turnosBto5 = _dialogue.turnosIdentificacion;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "¿Quién eres?";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesIdentificacion;
                turnosBto6 = _dialogue.turnosIdentificacion;
                written = true;
            }
            _identificacion = false;
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
                turnosBto1 = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesCrucifijo;
                turnosBto2 = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesCrucifijo;
                turnosBto3 = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesCrucifijo;
                turnosBto4 = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesCrucifijo;
                turnosBto5 = _dialogue.turnosCrucifijo;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Crucifijo";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesCrucifijo;
                turnosBto6 = _dialogue.turnosCrucifijo;
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
                turnosBto1 = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesSoga;
                turnosBto2 = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesSoga;
                turnosBto3 = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesSoga;
                turnosBto4 = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesSoga;
                turnosBto5 = _dialogue.turnosSoga;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Soga";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesSoga;
                turnosBto6 = _dialogue.turnosSoga;
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
                turnosBto1 = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesCuchillo;
                turnosBto2 = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesCuchillo;
                turnosBto3 = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesCuchillo;
                turnosBto4 = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesCuchillo;
                turnosBto5 = _dialogue.turnosCuchillo;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Cuchillo";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesCuchillo;
                turnosBto6 = _dialogue.turnosCuchillo;
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
                turnosBto1 = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesMoraton;
                turnosBto2 = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesMoraton;
                turnosBto3 = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesMoraton;
                turnosBto4 = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesMoraton;
                turnosBto5 = _dialogue.turnosMoraton;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Moraton";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesMoraton;
                turnosBto6 = _dialogue.turnosMoraton;
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
                turnosBto1 = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesNarizRota;
                turnosBto2 = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesNarizRota;
                turnosBto3 = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesNarizRota;
                turnosBto4 = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesNarizRota;
                turnosBto5 = _dialogue.turnosNarizRota;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Nariz Rota";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesNarizRota;
                turnosBto6 = _dialogue.turnosNarizRota;
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
                turnosBto1 = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesNudillos;
                turnosBto2 = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesNudillos;
                turnosBto3 = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesNudillos;
                turnosBto4 = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesNudillos;
                turnosBto5 = _dialogue.turnosNudillos;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Nudillos";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesNudillos;
                turnosBto6 = _dialogue.turnosNudillos;
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
                turnosBto1 = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHerida;
                turnosBto2 = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHerida;
                turnosBto3 = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHerida;
                turnosBto4 = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHerida;
                turnosBto5 = _dialogue.turnosHerida;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Herida";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHerida;
                turnosBto6 = _dialogue.turnosHerida;
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
                turnosBto1 = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHoraEstandar;
                turnosBto2 = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHoraEstandar;
                turnosBto3 = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHoraEstandar;
                turnosBto4 = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHoraEstandar;
                turnosBto5 = _dialogue.turnosHoraEstandar;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHoraEstandar;
                turnosBto6 = _dialogue.turnosHoraEstandar;
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
                turnosBto1 = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHoraAna;
                turnosBto2 = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHoraAna;
                turnosBto3 = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHoraAna;
                turnosBto4 = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHoraAna;
                turnosBto5 = _dialogue.turnosHoraAna;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Hora Dormir";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHoraAna;
                turnosBto6 = _dialogue.turnosHoraAna;
                written = true;
            }
            _horaMimirAnaActivado = false;
        }
        if (_horaMimirJoseManuelActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Croata";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesHoraJoseManuel;
                turnosBto1 = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Croata";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesHoraJoseManuel;
                turnosBto2 = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Croata";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesHoraJoseManuel;
                turnosBto3 = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Croata";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesHoraJoseManuel;
                turnosBto4 = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Croata";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesHoraJoseManuel;
                turnosBto5 = _dialogue.turnosHoraJoseManuel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Croata";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesHoraJoseManuel;
                turnosBto6 = _dialogue.turnosHoraJoseManuel;
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
                turnosBto1 = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesAnaTestigoJoseManuel;
                turnosBto2 = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesAnaTestigoJoseManuel;
                turnosBto3 = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesAnaTestigoJoseManuel;
                turnosBto4 = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesAnaTestigoJoseManuel;
                turnosBto5 = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Jose Manuel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesAnaTestigoJoseManuel;
                turnosBto6 = _dialogue.turnosAnaTestigoJoseManuel;
                written = true;
            }
            _anaTestigoJoseManuelActivado = false;
        }
        if (_anaTestigoMiguelAActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel Ángel";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesAnaTestigoMiguel;
                turnosBto1 = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel Ángel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesAnaTestigoMiguel;
                turnosBto2 = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel Ángel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesAnaTestigoMiguel;
                turnosBto3 = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel Ángel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesAnaTestigoMiguel;
                turnosBto4 = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel Ángel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesAnaTestigoMiguel;
                turnosBto5 = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Testigo Miguel Ángel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesAnaTestigoMiguel;
                turnosBto6 = _dialogue.turnosAnaTestigoMiguel;
                written = true;
            }
            _anaTestigoMiguelAActivado = false;
        }
        if (_apareceJoseManuelActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Jose Manuel";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesApareceJoseManuel;
                turnosBto1 = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Jose Manuel";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesApareceJoseManuel;
                turnosBto2 = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Jose Manuel";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesApareceJoseManuel;
                turnosBto3 = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Jose Manuel";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesApareceJoseManuel;
                turnosBto4 = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Jose Manuel";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesApareceJoseManuel;
                turnosBto5 = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Jose Manuel";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesApareceJoseManuel;
                turnosBto6 = _dialogue.turnosApareceJoseManuel;
                written = true;
            }
            _apareceJoseManuelActivado = false;
        }
        if (_joseCatalinaParrandaActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Investigación";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesJoseCatalinaParranda;
                turnosBto1 = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Investigación";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesJoseCatalinaParranda;
                turnosBto2 = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Parranda";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesJoseCatalinaParranda;
                turnosBto3 = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Investigación";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesJoseCatalinaParranda;
                turnosBto4 = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Investigación";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesJoseCatalinaParranda;
                turnosBto5 = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Investigación";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesJoseCatalinaParranda;
                turnosBto6 = _dialogue.turnosJoseCatalinaParranda;
                written = true;
            }
            _joseCatalinaParrandaActivado = false;
        }
        if (_pedroLLamoActivado)
        {
            bool written = false;
            if (!bto1onUse)
            {
                bto1.GetComponentInChildren<TextMeshProUGUI>().text = "Llamada";
                bto1onUse = true;
                bto1.gameObject.SetActive(true);
                _dButton1 = _dialogue.sentencesPedroLlamo;
                turnosBto1 = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto2onUse && !written)
            {
                bto2.GetComponentInChildren<TextMeshProUGUI>().text = "Llamada";
                bto2onUse = true;
                bto2.gameObject.SetActive(true);
                _dButton2 = _dialogue.sentencesPedroLlamo;
                turnosBto2 = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto3onUse && !written)
            {
                bto3.GetComponentInChildren<TextMeshProUGUI>().text = "Llamada";
                bto3onUse = true;
                bto3.gameObject.SetActive(true);
                _dButton3 = _dialogue.sentencesPedroLlamo;
                turnosBto3 = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto4onUse && !written)
            {
                bto4.GetComponentInChildren<TextMeshProUGUI>().text = "Llamada";
                bto4onUse = true;
                bto4.gameObject.SetActive(true);
                _dButton4 = _dialogue.sentencesPedroLlamo;
                turnosBto4 = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto5onUse && !written)
            {
                bto5.GetComponentInChildren<TextMeshProUGUI>().text = "Llamada";
                bto5onUse = true;
                bto5.gameObject.SetActive(true);
                _dButton5 = _dialogue.sentencesPedroLlamo;
                turnosBto5 = _dialogue.turnosPedroLlamo;
                written = true;
            }
            else if (!bto6onUse && !written)
            {
                bto6.GetComponentInChildren<TextMeshProUGUI>().text = "Llamada";
                bto6onUse = true;
                bto6.gameObject.SetActive(true);
                _dButton6 = _dialogue.sentencesPedroLlamo;
                turnosBto6 = _dialogue.turnosPedroLlamo;
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


        if(dialogue.charactersNames[0] == "Miguel Ríos")
        {
            _gameManager.updateCharacter("Jose Manuel");
        }
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

            if (_personaje.Identificacion)
            {
                _identificacion = true;
            }
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
        _turnos = turnosBto1;
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
        _turnos = turnosBto2;
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
        _turnos = turnosBto3;
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
        _turnos = turnosBto4;
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
        _turnos = turnosBto5;
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
        _turnos = turnosBto6;
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
            case "¿Quién eres?":
                if(_dialogue.charactersNames[0] == "Jose Rodríguez")
                {
                    _gameManager.updateCharacter("Parranda");
                }
                break;
            case "Investigación":
                if(_dialogue.charactersNames[0] == "Catalina Mesías")
                {
                    _gameManager.updateCharacter("Sotano");
                }
                break;
            case "Jose Manuel":
                if(_dialogue.charactersNames[0] == "Jose Rodríguez" || _dialogue.charactersNames[0] == "Catalina Mesías")
                {
                    _gameManager.updateCharacter("Miguel");
                }
                break;
            case "Croata":
                if(_dialogue.charactersNames[0] == "Gonzalo Suárez")
                {
                    _gameManager.updateCharacter("Croata");
                }
                break;
            default:
                break;
        }
    }

}