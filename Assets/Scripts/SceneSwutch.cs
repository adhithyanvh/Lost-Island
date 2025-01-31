using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwutch : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void SceneChanger()
    {
        SceneManager.LoadScene(1);

       
    }
    public void StorySceneChanger()
    {
        SceneManager.LoadScene(4);
    }
    public void StorySceneBackChanger()
    {
        SceneManager.LoadScene(0);
    }
}
