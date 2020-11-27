using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToGameOver : MonoBehaviour
{
    private int nextSceneToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = 2;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
    
    public void over()
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
