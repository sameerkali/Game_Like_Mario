//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Finish : MonoBehaviour
//{
//    private AudioSource finishSound;

//    private bool levelCompleted = false;

//    private void Start()
//    {
//        finishSound = GetComponent<AudioSource>();
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.name == "Player" && !levelCompleted)
//        {
//            finishSound.Play();
//            levelCompleted = true;
//            Invoke("CompleteLevel", 2f);
//        }
//    }

//    private void CompleteLevel()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
//    }
//}



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Finish : MonoBehaviour
//{
//    private AudioSource finishSound;

//    private bool levelCompleted = false;

//    private void Start()
//    {
//        finishSound = GetComponent<AudioSource>();
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.name == "Player" && !levelCompleted)
//        {
//            finishSound.Play();
//            levelCompleted = true;
//            Invoke("CompleteLevel", 2f);
//        }
//    }

//    private void CompleteLevel()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
//    }
//}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(1);
        /*int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 4;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogError("Invalid scene index: " + nextSceneIndex);
        }*/
    }
}

