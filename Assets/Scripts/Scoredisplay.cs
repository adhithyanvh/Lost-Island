using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Scoredisplay : MonoBehaviour
{
    public Protagonist scoreDis;
    public Protagonist lifetwo;


    public TMP_Text text;
    public TMP_Text text2;
    public TMP_Text text3;
    public UnityEngine.UI.Slider lifeBar;

    public GameObject boatspottt,playerr,woodlogs;
    private float dist1;
    public float woodplyrdist;
    public GameObject sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10;
    public float spdist1, spdist2, spdist3, spdist4, spdist5, spdist6, spdist7, spdist8, spdist9, spdist10;

    public UnityEngine.UI.Button infobut, resumebut;
    public GameObject MyPanel;

    //TIMER
    [SerializeField] TextMeshProUGUI TimerText;
    public static float time;
    int minutes,seconds;

    // Start is called before the first frame update
    void Start()
    {


        lifetwo.life = 10;
        MyPanel.gameObject.SetActive(false);

        resumebut.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        //TIMER

        time += Time.deltaTime;  
        TimerText.text = time.ToString();
        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);
        TimerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);


        lifeChanger();
        

        dist1 = Vector3.Distance(playerr.transform.position, boatspottt.transform.position);
        text.text = "Logs Collected: " + scoreDis.score;
        text2.text = "Collect 5 Logs to build the boat";
        if (scoreDis.score >= 5)
        {
            text.text = "Enough Logs acquired!!";

            text2.text = "Reach the beach to build the Boat";


        }
        if (dist1 < 40f)
        {
            text2.text = "Press B to build the Boat";

        }

    

        //HINTS

        //------Distance Calculator------
        
        spdist1 = Vector3.Distance(sp1.transform.position, playerr.transform.position);
        spdist2 = Vector3.Distance(sp2.transform.position,playerr.transform.position);
        spdist3 = Vector3.Distance(sp3.transform.position,playerr.transform.position);
        spdist4 = Vector3.Distance(sp4.transform.position, playerr.transform.position);
        spdist5 = Vector3.Distance(sp5.transform.position, playerr.transform.position);
        spdist6 = Vector3.Distance(sp6.transform.position, playerr.transform.position);
        spdist7 = Vector3.Distance(sp7.transform.position, playerr.transform.position);
        spdist8 = Vector3.Distance(sp8.transform.position, playerr.transform.position);
        spdist9 = Vector3.Distance(sp9.transform.position, playerr.transform.position);
        spdist10 = Vector3.Distance(sp10.transform.position, playerr.transform.position);

        //-------Hint Prompt-------------

        //01

        if (spdist1 < 50 )
        {
            text3.text = "Stay vigilant!!";

        }
        

        //02

        else if (spdist2 < 50 )
        {
            text3.text = "Stay vigilant!!";

        }
       

        //03

        else if (spdist3 < 50 )
        {
            text3.text = "Stay vigilant!!";

        }
        

        //04

        else if (spdist4 < 50 )
        {
            text3.text = "Stay vigilant!!";

        }
        

        //5

        else if (spdist5 < 50 )
        {
            text3.text = "Stay vigilant!!";

        }

        //6

        else if (spdist6 < 50)
        {
            text3.text = "Stay vigilant!!";

        }

        //7

        else if (spdist7 < 50)
        {
            text3.text = "Stay vigilant!!";

        }

        //8

        else if (spdist8 < 50)
        {
            text3.text = "Stay vigilant!!";

        }

        //9

        else if (spdist9 < 50)
        {
            text3.text = "Stay vigilant!!";

        }

        //10

        else if (spdist10 < 50)
        {
            text3.text = "Stay vigilant!!";

        }

        else
        {
            text3.text = "";
        }
       
    }

    

    public void lifeChanger()
    {
       // Debug.Log(lifetwo.life);

        if (lifetwo.life != lifeBar.value || lifetwo.life == lifeBar.value || lifeBar.value>=0 && lifeBar.value <=10)
        {
            //Debug.Log("vann mone");
            if(lifetwo.life >= 0 && lifetwo.life <= 10)
            {
                lifeBar.value = lifetwo.life;

            }
        }

        
    }

    public void InfoDisplay()
    {
        Time.timeScale = 0;
        infobut.gameObject.SetActive(false);
        resumebut.gameObject.SetActive(true);
        MyPanel.gameObject.SetActive(true);


    }

    public void Resume()
    {
        Time.timeScale = 1;
        infobut.gameObject.SetActive(true);

        resumebut.gameObject.SetActive(false);
        MyPanel.gameObject.SetActive(false);


    }
}
