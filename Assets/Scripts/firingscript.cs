using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firingscript : MonoBehaviour
{
    public float speed;
    public GameObject fireBall,enem1,enem2,enem3,enem4,enem5;
    public Protagonist lifethree;
    public int Total;
   
    public float ebdistance1,ebdistance2,ebdistance3,ebdistance4,ebdistance5; //Enemy-FireBall Distance


    // Start is called before the first frame update
    void Start()
    {
        fireBall.transform.Rotate(10,0,0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.forward * speed * Time.deltaTime);


       ebdistance1 = Vector3.Distance(enem1.transform.position, fireBall.transform.position);
       ebdistance2 = Vector3.Distance(enem2.transform.position, fireBall.transform.position);
       ebdistance3 = Vector3.Distance(enem3.transform.position, fireBall.transform.position);
       ebdistance4 = Vector3.Distance(enem4.transform.position, fireBall.transform.position);
       ebdistance5 = Vector3.Distance(enem5.transform.position, fireBall.transform.position);


        if (ebdistance1 > 50 && ebdistance1 <100)
        {
            Destroy(gameObject);
        }

        if (ebdistance2 > 50 && ebdistance2 < 100)
        {
            Destroy(gameObject);
        }
        if (ebdistance3 > 50 && ebdistance3 < 100)
        {
            Destroy(gameObject);
        }
        if (ebdistance4 > 50 && ebdistance4 < 100)
        {
            Destroy(gameObject);
        }
        if (ebdistance5 > 50 && ebdistance5 < 100)
        {
            Destroy(gameObject);
        }
    }

    
}
