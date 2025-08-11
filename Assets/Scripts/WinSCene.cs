using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerTextWin;
    public float WinTime;
    public int minutes, seconds;

    void Start()
    {
        //total time 
        WinTime = Scoredisplay.time;

        // Convert total seconds into minutes and seconds
        minutes = Mathf.FloorToInt(WinTime / 60f);
        seconds = Mathf.FloorToInt(WinTime % 60f);

       
        TimerTextWin.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
