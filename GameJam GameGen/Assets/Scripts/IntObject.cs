using System.Collections.Generic;
using UnityEngine;

public class IntObject : PersonajePrueba, ISubject<int>
{
    public string nameObj;
    public int id;

    [TextArea(10, 15)]
    public string description = "";

    public bool investigado;
    public bool highlighted;

    public GameObject padre;

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

    //private void OnMouseOver()
    //{
    //    if (Input.GetKeyDown(KeyCode.F))
    //    {
    //        Vector3 a = new Vector3(transform.position.x, 0, transform.position.z);
    //        Vector3 b = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
    //        if (Vector3.Distance(a, b) < 3f)
    //        {
    //            Debug.Log("in range");
    //            NotifyObservers();
    //        }
    //    }
    //}

    public override void Talk()
    {
        NotifyObservers();
        trigger.TriggerDialogue(this);
        if(nameObj == "PuertaSótano")
        {
            Destroy(padre);
        }
    }

    public override void Updated(string s)
    {
        
    }
}