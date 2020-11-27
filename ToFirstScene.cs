using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToFirstScene : MonoBehaviour
{
    private int nextSceneToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = 3;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
    
    public void next()
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
