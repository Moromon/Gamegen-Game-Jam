using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObject : MonoBehaviour,ISubject<int>
{
    public string nameObj;
    public int id;
    [TextArea(10, 15)]
    public string description = "";
    public bool investigado;
    public GameObject preview;


    private List<IObserver<int>> _observers = new List<IObserver<int>>();
    public void AddObserver(IObserver<int> observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver<int> observer in _observers)
        {
            observer?.UpdateObserver(id);
        }
    }

    public void RemoveObserver(IObserver<int> observer)
    {
        _observers.Remove(observer);
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            NotifyObservers();
        }
    }
}
