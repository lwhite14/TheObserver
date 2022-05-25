using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoundFootageUI : MonoBehaviour
{
    public Text dateText;
    public Text timeText;
    public Text recordingText;
    public Text recordingSpotText;
    public float fadeSpeed = 0.4f;
    TimeSpan startTime;

    void Start() 
    {
        StartCoroutine(RecordingTurnOff());
        startTime = new TimeSpan(8, 13, 13);
    }

    void Update() 
    {
        TimeSpan currentTime = TimeSpan.FromSeconds(Time.time);
        TimeSpan outputTime = currentTime + startTime;
        timeText.text = "PM " + outputTime.ToString("hh':'mm':'ss");
    }

    IEnumerator RecordingTurnOff()
    {
        while (recordingText.color.a > 0)
        {
            recordingText.color = new Color(recordingText.color.r, recordingText.color.g, recordingText.color.b, recordingText.color.a - (Time.deltaTime * fadeSpeed));
            recordingSpotText.color = new Color(recordingSpotText.color.r, recordingSpotText.color.g, recordingSpotText.color.b, recordingSpotText.color.a - (Time.deltaTime * fadeSpeed));
            yield return null;
        }
        yield return StartCoroutine(RecordingTurnOn());
    }

    IEnumerator RecordingTurnOn() 
    {
        while (recordingText.color.a < 1)
        {
            recordingText.color = new Color(recordingText.color.r, recordingText.color.g, recordingText.color.b, recordingText.color.a + (Time.deltaTime * fadeSpeed));
            recordingSpotText.color = new Color(recordingSpotText.color.r, recordingSpotText.color.g, recordingSpotText.color.b, recordingSpotText.color.a + (Time.deltaTime * fadeSpeed));
            yield return null;
        }
        yield return StartCoroutine(RecordingTurnOff());
    }
}
