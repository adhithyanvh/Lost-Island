using System;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class brutescript : MonoBehaviour
{

    public int speed;
    public float pedist1, pedist2, pedist3, pedist4, pedist5; //Player - Enemy Distance
    public GameObject playerr;
    public GameObject abeEnem1, abeEnem2, abeEnem3, abeEnem4, abeEnem5; //Abee - the enemy
    public Animator abeAnimator, abeAnimator2, abeAnimator3, abeAnimator4, abeAnimator5;
    public Transform faceto;
    public GameObject fireBall;
    Vector3 abeposition, abeposition2, abeposition3, abeposition4, abeposition5; //Positions of the enemy
    public float offsety, offsetx;
    bool bolpresent = false, bolpresent2 = false, bolpresent3 = false, bolpresent4 = false, bolpresent5 = false;



    // Start is called before the first frame update
    void Start()
    {
        abeAnimator.SetBool("idle", true);
        abeAnimator2.SetBool("idle", true);
        abeAnimator3.SetBool("idle", true);
        abeAnimator4.SetBool("idle", true);
        abeAnimator5.SetBool("idle", true);

        abeposition = new Vector3(abeEnem1.transform.position.x + offsetx, abeEnem1.transform.position.y + offsety, abeEnem1.transform.position.z);
        abeposition2 = new Vector3(abeEnem2.transform.position.x + offsetx, abeEnem2.transform.position.y + offsety, abeEnem2.transform.position.z);
        abeposition3 = new Vector3(abeEnem3.transform.position.x + offsetx, abeEnem3.transform.position.y + offsety, abeEnem3.transform.position.z);
        abeposition4 = new Vector3(abeEnem4.transform.position.x + offsetx, abeEnem4.transform.position.y + offsety, abeEnem4.transform.position.z);
        abeposition5 = new Vector3(abeEnem5.transform.position.x + offsetx, abeEnem5.transform.position.y + offsety, abeEnem5.transform.position.z);






    }

    // Update is called once per frame
    void Update()
    {

        pedist1 = Vector3.Distance(abeEnem1.transform.position, playerr.transform.position);
        pedist2 = Vector3.Distance(abeEnem2.transform.position, playerr.transform.position);
        pedist3 = Vector3.Distance(abeEnem3.transform.position, playerr.transform.position);
        pedist4 = Vector3.Distance(abeEnem4.transform.position, playerr.transform.position);
        pedist5 = Vector3.Distance(abeEnem5.transform.position, playerr.transform.position);

        //===========================ENEMY 01==================================

        if (pedist1 < 20)
        {
            abeEnem1.transform.LookAt(new Vector3(faceto.position.x, transform.position.y, faceto.position.z));

            abeAnimator.SetBool("fire", true);
            abeAnimator.SetBool("idle", false);

            if (bolpresent == false && pedist1 < 20)
            {
                InvokeRepeating("firebolattack", 0.7f, 1.35f);
                bolpresent = true;

            }

        }
        else
        {
            abeAnimator.SetBool("fire", false);
            abeAnimator.SetBool("idle", true);
            CancelInvoke("firebolattack");

            bolpresent = false;
        }

        //===========================ENEMY 02==================================


        if (pedist2 < 20)
        {
            abeEnem2.transform.LookAt(new Vector3(faceto.position.x, transform.position.y, faceto.position.z));

            abeAnimator2.SetBool("fire", true);
            abeAnimator2.SetBool("idle", false);

            if (bolpresent2 == false && pedist2 < 20)
            {
                Debug.Log("hehehehe");
                InvokeRepeating("firebolattack2", 0.7f, 1.35f);
                bolpresent2 = true;

            }
        }
        else
        {
            abeAnimator2.SetBool("fire", false);
            abeAnimator2.SetBool("idle", true);

            CancelInvoke("firebolattack2");

            bolpresent2 = false;

        }

        //===========================ENEMY 03==================================


        if (pedist3 < 20)
        {
            abeEnem3.transform.LookAt(new Vector3(faceto.position.x, transform.position.y, faceto.position.z));

            abeAnimator3.SetBool("fire", true);
            abeAnimator3.SetBool("idle", false);

            if (bolpresent3 == false && pedist3 < 20)
            {
                InvokeRepeating("firebolattack3", 0.7f, 1.35f);
                bolpresent3 = true;

            }
        }
        else
        {
            abeAnimator3.SetBool("fire", false);
            abeAnimator3.SetBool("idle", true);
            CancelInvoke("firebolattack3");

            bolpresent3 = false;
        }

        //===========================ENEMY 04==================================


        if (pedist4 < 20)
        {
            abeEnem4.transform.LookAt(new Vector3(faceto.position.x, transform.position.y, faceto.position.z));

            abeAnimator4.SetBool("fire", true);
            abeAnimator4.SetBool("idle", false);

            if (bolpresent4 == false && pedist4 < 20)
            {
                InvokeRepeating("firebolattack4", 0.7f, 1.35f);
                bolpresent4 = true;

            }
        }

        else
        {
            abeAnimator4.SetBool("fire", false);
            abeAnimator4.SetBool("idle", true);
            CancelInvoke("firebolattack4");

            bolpresent4 = false;
        }

        //===========================ENEMY 05==================================


        if (pedist5 < 20)
        {
            abeEnem5.transform.LookAt(new Vector3(faceto.position.x, transform.position.y, faceto.position.z));

            abeAnimator5.SetBool("fire", true);
            abeAnimator5.SetBool("idle", false);

            if (bolpresent5 == false && pedist5 < 20)
            {
                InvokeRepeating("firebolattack5", 0.7f, 1.35f);
                bolpresent5 = true;

            }

        }
        else
        {
            abeAnimator5.SetBool("fire", false);
            abeAnimator5.SetBool("idle", true);
            CancelInvoke("firebolattack5");

            bolpresent5 = false;
        }





    }

    //-------------ENEMY ATTACK------------------------ 

    void firebolattack()
    {
        Instantiate(fireBall, abeposition, abeEnem1.transform.rotation);
        //firebol.transform.SetParent(abeEnem1.transform, true);


    }
    void firebolattack2()
    {

        Instantiate(fireBall, abeposition2, abeEnem2.transform.rotation);
        //firebol.transform.SetParent(abeEnem2.transform, true);
    }

    void firebolattack3()
    {

        Instantiate(fireBall, abeposition3, abeEnem3.transform.rotation);
        //firebol.transform.SetParent(abeEnem2.transform, true);
    }

    void firebolattack4()
    {

        Instantiate(fireBall, abeposition4, abeEnem4.transform.rotation);
        //firebol.transform.SetParent(abeEnem2.transform, true);
    }

    void firebolattack5()
    {

        Instantiate(fireBall, abeposition5, abeEnem5.transform.rotation);
        //firebol.transform.SetParent(abeEnem2.transform, true);
    }


}


