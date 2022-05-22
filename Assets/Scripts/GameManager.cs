using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int level = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        CursorMode();
    }

    public void Restart() 
    {
        string sceneToLoad = "Level" + level;
        SceneManager.LoadScene(sceneToLoad);
    }

    void CursorMode()
    {
        if (Cursor.lockState != CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Cursor.visible == true)
        {
            Cursor.visible = false;
        }
    }
}
