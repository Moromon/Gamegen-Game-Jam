using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Libreta : MonoBehaviour
{
    public int maxChild;

    private int childActual = 0;

    public Button prev;

    public Button next;

    public Button resolve;

    public TMP_Dropdown dropDown;

    public TMP_Dropdown dropDown2;

    public TMP_Dropdown dropDown3;

    public TMP_Dropdown dropDown4;

    public TMP_Dropdown dropDown5;

    public TMP_Dropdown dropDown6;

    public TMP_Dropdown dropDown7;

    public TMP_Dropdown dropDown8;

    public void nextPage()
    {
        if (childActual < maxChild)
        {
            bool paco = false;

            transform.GetChild(childActual).gameObject.SetActive(false);
            if (childActual == 0 && !paco)
            { childActual++; }
            childActual++;
            transform.GetChild(childActual).gameObject.SetActive(true);
            if (transform.GetChild(maxChild).gameObject.activeSelf)
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
        if (childActual - 1 >= 0)
        {
            transform.GetChild(childActual).gameObject.SetActive(false);
            bool paco = false;
            if(childActual == 2 && !paco)
            {
                childActual--;
            }
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

    public void Check()
    {
        if (dropDown.value != 0 && dropDown2.value != 0 && dropDown3.value != 0 && dropDown4.value != 0 && dropDown5.value != 0 && dropDown6.value != 0 && dropDown7.value != 0 && dropDown8.value != 0)
        {
            resolve.gameObject.SetActive(true);
        }
        else
        {
            resolve.gameObject.SetActive(false);
        }
    }
}