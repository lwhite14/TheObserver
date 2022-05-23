using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class TVJumpScare : MonoBehaviour
{
    [Header("Jump Scare Objects")]
    public GameObject sound;
    public GameObject overlay;

    [Header("Currently In Scene")]
    public GameObject lensFlare;
    public GameObject pointLight;
    public GameObject playerTrigger;

    [Header("Distance To Appear")]
    public float appearDistance = 20.0f;

    [Header("TV Screen Material")]
    public MeshRenderer tvMeshRenderer;
    public Material staticMaterial;

    float overlayTime = 0.25f;
    Transform playerTransform;
    Camera worldCamera;

    void Start() 
    {
        overlayTime = sound.GetComponent<AudioSource>().clip.length;

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

    public void JumpScare(Trigger trigger)
    {
        Instantiate(sound);
        Viewmodel.instance.Disappear();
        StartCoroutine(DisplayOverlay(trigger));
    }

    public void AfterJumpScare(Trigger trigger)
    {
        // Destroy Objects
        Destroy(lensFlare);
        Destroy(pointLight);

        // Change TV
        tvMeshRenderer.material = staticMaterial;

        // Set Viewmodel
        Viewmodel.instance.Appear();

        // Open Next Area


        // Destroy Self
        Destroy(playerTrigger);
    }

    IEnumerator DisplayOverlay(Trigger trigger) 
    {
        GameObject tempOverlay = Instantiate(overlay, GameObject.Find("CanvasWorld").transform) as GameObject;
        yield return new WaitForSeconds(overlayTime);
        Destroy(tempOverlay);
        trigger.AfterEvent();
        yield return null;
    }
}
