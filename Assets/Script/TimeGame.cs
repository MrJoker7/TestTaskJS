using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeGame : MonoBehaviour
{
    private float timeOnLevel = 30;
    private Text timeText;

    private float time;
    public Action endTime;

    private void Start()
    {
        timeText = GetComponent<Text>();
        StartTime();
    }
    public void StartTime()
    {
        time = timeOnLevel;
    }

    private void Update()
    {
        time -= Time.deltaTime;
        timeText.text = time.ToString("f0");
        if (time <= 0) endTime();
    }
}
