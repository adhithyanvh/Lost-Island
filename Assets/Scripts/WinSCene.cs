using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerTextWin;
    public float WinTime;
    public int minutes, seconds;

    // Start is called before the first frame update
    void Start()
    {
        WinTime = Scoredisplay.time;
        TimerTextWin.text = WinTime.ToString();
       

        Debug.Log(WinTime);

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
