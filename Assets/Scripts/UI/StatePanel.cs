using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePanel : MonoBehaviour
{
    public static StatePanel instance = null;

    Animator anim;

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
        anim = GetComponent<Animator>();
    }

    public void Restart() 
    {
        anim.Play("Restart");
    }

    public void ManagerRestart() 
    {
        GameManager.instance.Restart();
    }

    public void EndGame() 
    {
        PlayerMovement.canMove = false;
        anim.Play("EndGame");
    }

    public void ManagerEndGame() 
    {
        GameManager.instance.EndGame();
    }
}
