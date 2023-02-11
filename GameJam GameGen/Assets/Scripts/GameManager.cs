using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour,IObserver<int>
{

    public IntObject[] intObjects;

    public PersonajePrueba[] personajes;

    private void Awake()
    {
        for(int i = 0; i < intObjects.Length; i++)
        {
            intObjects[i].AddObserver(this);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateObserver(int data)
    {
        intObjects[data].investigado = true;
        updateCharacter(intObjects[data].nameObj);
    }

    public void updateCharacter(string s)
    {
        for(int i =0; i<personajes.Length;i++) {
            personajes[i].updated(s);
        }
    }
}
