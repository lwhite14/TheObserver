using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewmodel : MonoBehaviour
{
    public static Viewmodel instance = null;

    public float smoothing = 5.0f;
    public GameObject lights;
    public GameObject click;

    Transform targetPositional;
    Transform targetRotational;

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
        targetPositional = GameObject.Find("ViewmodelTargetPos").transform;
        targetRotational = GameObject.Find("WorldRenderer").transform;
    }

    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, targetPositional.position, smoothing * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotational.rotation, smoothing * Time.deltaTime);
    }

    public void TurnOnOff() 
    {
        if (lights.activeSelf)
        {
            lights.SetActive(false);
        }
        else 
        {
            lights.SetActive(true);
        }
        Instantiate(click, transform.position, Quaternion.identity);
    }
}

