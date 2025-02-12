using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
//using static UnityEditor.Experimental.GraphView.GraphView;
using System;
using Random = UnityEngine.Random;
using UnityEngine.Experimental.GlobalIllumination;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
using Unity.Mathematics;

public class Protagonist : MonoBehaviour
{
    public int life;


    float speed = 30;
    public GameObject[] spots;
    public GameObject[] Savepos;
    public GameObject woodlogs, boat, boatspott, Sophie;
   // public GameObject SavedPosition1,SavedPosition2,SavedPosition3,SavedPosition4,SavedPosition5;
    public Animator SophieAnimator;
    public int score = 0;
    public BoxCollider playerBox;

    public int[] arrayCheck = new int[5];

    int index1,c,index2;
    private bool boatSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        spaawner();
        life = 10;


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("mone life " +life);

        //DEFAULT ANIMATION

        SophieAnimator.SetBool("stand", true);
        SophieAnimator.SetBool("run", false);
        SophieAnimator.SetBool("walk", false);
        SophieAnimator.SetBool("dead", false);
        SophieAnimator.SetBool("walkback", false);



        //PLAYER MOVEMENTS

        SomeFunction();

        //FORWARD

       

        if(Input.GetAxis("Vertical") > 0)
        {
            SophieAnimator.SetBool("walk", true);
            SophieAnimator.SetBool("stand", false);
            SophieAnimator.SetBool("run", false);
            SophieAnimator.SetBool("dead", false);
            SophieAnimator.SetBool("walkback", false);
           

            speed = 3.5f;

            if(Input.GetKey(KeyCode.LeftShift))
            {
                speed = 10f;
                SophieAnimator.SetBool("run", true);
                SophieAnimator.SetBool("walk", false);
                SophieAnimator.SetBool("stand", false);
                SophieAnimator.SetBool("dead", false);
                SophieAnimator.SetBool("walkback", false);
                

            }
        }



        if (Input.GetAxis("Vertical") < 0)
        {
            SophieAnimator.SetBool("walkback", true);
            SophieAnimator.SetBool("walk", false);
            SophieAnimator.SetBool("stand", false);
            SophieAnimator.SetBool("run", false);
            SophieAnimator.SetBool("dead", false);
            SophieAnimator.SetBool("rightwalk", false);
            SophieAnimator.SetBool("leftwalk", false);


            speed = 3f;
        }

        

        
        

        

        //PLAYER RESPAWN 

        if (Sophie.transform.position.y < -4f)
        {
            index2 = UnityEngine.Random.Range(0, Savepos.Length);


            Sophie.transform.position = Savepos[index2].transform.position;


            
        }


        //BOAT SPAWNER

        if (score >= 5)
        {
            boatSpawn = true;
            if(Input.GetKeyDown(KeyCode.B))
            {
                if(boatSpawn == true)
                {
                    boatspawner();
                    boatSpawn = false;
                    score = 0;

                }
                /*if(boatSpawn == true & score == 0)
                {
                    SceneChanger3();
                }*/
            }
        }


        //PLAYER DEAD SCENE

        if (life <= 0)
        {
            SceneChanger2();
        }

    }


    public void SomeFunction()
    {
        //float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        //float Jumpp = Input.GetAxis("Mouse Y");

        transform.Translate(0, 0, VerticalInput * speed * Time.deltaTime);

        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0 ,MouseX * speed * Time.deltaTime, 0);

    }

    //WOODEN LOGS SPAWNER 

    void spaawner()
    {
        for (int i = 0; i < spots.Length - 5; i++)
        {
            index1 = Random.Range(0, spots.Length);
            



            // arrayCheck[i] = index;

            Debug.Log(arrayCheck[i]);

            //Debug.Log(c);
            //Debug.Log(index);


            Instantiate(woodlogs, spots[index1].transform.position, Quaternion.identity);
            

        }
        

    }





    

    //BOAT SPAWNER

    void boatspawner()
    {

        Instantiate(boat, boatspott.transform.position, Quaternion.identity);
    }

    //LIFE ++ & LOGS COLLECTOR

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("logs"))
        {
            
            Destroy(other.gameObject);
            
            score = score + 1;

            Debug.Log("Logs Collected = " + score);
        }

        if (other.CompareTag("lifee"))
        {
            if (life >= 0 && life < 10)
            {
                life = life + 2;
                Destroy(other.gameObject);
                Debug.Log("protag " + life);

            }

        }

        if (other.CompareTag("hitt"))
        {
            if (life > 0 && life <= 10)
            {
                life -= 2;
                Debug.Log(life);

            }
            else
            {
                Debug.Log(life);
            }


        }

        if (other.CompareTag("boat"))
        {
            SceneChanger3();
        }

    }

    public void SceneChanger2()
    {
        SceneManager.LoadScene(2);
    }
    public void SceneChanger3()
    {
        SceneManager.LoadScene(3);
    }

}
