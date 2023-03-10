using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public GameObject notebook;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!optionsMenu.activeSelf &&GameManager.onMenu && pauseMenu.activeSelf)
            {
                ResumeGame();
            }
            else if (optionsMenu.activeSelf)
            {
                ExitOptions();
            }
            else
            {
                PauseGame();
                Cursor.lockState = CursorLockMode.None;
            }
        }
        if (Input.GetKeyDown(KeyCode.J) && !GameManager.onMenu)
        {
            notebook.SetActive(!notebook.activeSelf);
            GameManager.onMenu = notebook.activeSelf;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameManager.onMenu = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        GameManager.onMenu = false;
        if (!notebook.activeSelf && !GameManager.onDialogue)
        {
 
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }

    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Options()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void ExitOptions()
    {
       pauseMenu.SetActive(true);
       optionsMenu.SetActive(false); 
    }
    public void exitNotebook()
    {
       notebook.SetActive(false);
       GameManager.onMenu= false;
        if(!GameManager.onDialogue)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }
}
