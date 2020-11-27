using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFinalScene : MonoBehaviour
{
    private int nextSceneToLoad;
    
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = 6;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
