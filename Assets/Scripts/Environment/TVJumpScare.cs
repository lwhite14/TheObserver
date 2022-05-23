using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class TVJumpScare : MonoBehaviour
{
    public GameObject sound;
    public GameObject overlay;
    public GameObject[] lensFlareObjs;
    public float overlayTime = 0.25f;

    void Start() 
    {
        overlayTime = sound.GetComponent<AudioSource>().clip.length;
    }

    public void JumpScare(Trigger trigger)
    {
        Instantiate(sound);
        StartCoroutine(DisplayOverlay(trigger));
    }

    public void AfterJumpScare(Trigger trigger)
    {
        // Destroy Objects
        foreach (GameObject obj in lensFlareObjs) 
        {
            Destroy(obj);
        }
        // Open Next Area

        // Destroy Self
        Destroy(gameObject);
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
