using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePanel : MonoBehaviour
{
    public static StatePanel instance = null;

    Animator anim;

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
}
