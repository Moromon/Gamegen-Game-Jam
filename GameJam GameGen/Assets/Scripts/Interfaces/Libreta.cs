using UnityEngine;
using UnityEngine.UI;

public class Libreta : MonoBehaviour
{
    public int maxChild;

    private int childActual = 0;

    public Button prev;

    public Button next;
    
    public void nextPage()
    {
        if (childActual+1 < maxChild)
        {
            transform.GetChild(childActual).gameObject.SetActive(false);
            childActual++;
            transform.GetChild(childActual).gameObject.SetActive(true);
            if(transform.GetChild(maxChild-1).gameObject.activeSelf)
            {
                next.gameObject.SetActive(false);
            }
            else
            {
                next.gameObject.SetActive(true);
                prev.gameObject.SetActive(true);
            }
        }
    }

    public void prevPage()
    {
        if (childActual-1 >= 0)
        {
            transform.GetChild(childActual).gameObject.SetActive(false);
            childActual--;
            transform.GetChild(childActual).gameObject.SetActive(true);
            
            if (transform.GetChild(0).gameObject.activeSelf)
            {
                prev.gameObject.SetActive(false);
            }
            else
            {
                next.gameObject.SetActive(true);
                prev.gameObject.SetActive(true);
            }
        }
    }
}