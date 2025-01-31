using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinSCene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerTextWin;
    public float WinTime;
    public int minutes, seconds;

    // Start is called before the first frame update
    void Start()
    {
        WinTime = Scoredisplay.time;
        TimerTextWin.text = WinTime.ToString();
        //TimerTextWin.text = ToString().Format("{0:00}:{1:00}", minutes, seconds);

        Debug.Log(WinTime);

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
