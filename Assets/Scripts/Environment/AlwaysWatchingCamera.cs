using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysWatchingCamera : MonoBehaviour
{
    public float appearDistance = 20.0f;
    public GameObject lensFlare;
    public GameObject pointLight;
    public GameObject playerTrigger;

    Transform playerTransform;
    Camera worldCamera;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        worldCamera = GameObject.Find("WorldRenderer").GetComponent<Camera>();

        lensFlare.SetActive(false);
        pointLight.SetActive(false);
        playerTrigger.SetActive(false);
    }

    void Update()
    {
        if (lensFlare != null && pointLight != null) 
        {
            lensFlare.transform.LookAt(lensFlare.transform.position + worldCamera.transform.rotation * Vector3.forward, worldCamera.transform.rotation * Vector3.up);
            float distanceBetween = Vector3.Distance(playerTransform.position, lensFlare.transform.position);
            if (distanceBetween <= appearDistance)
            {
                lensFlare.SetActive(true);
                pointLight.SetActive(true);
                playerTrigger.SetActive(true);
            }
        }
    }
}
