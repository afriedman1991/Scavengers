using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager; //GameManager prefab to instantiate.
    //SoundManager prefab to instantiate.


    void Awake()
    {
        //Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
        if (GameManager.instance == null)
        {
            //Instantiate GameManager prefab
            Instantiate(gameManager);
        }

        //Check if a SoundManager has already been assigned to static variable SoundManager.instance or if it's still null

        //Instantiate SoundManager prefab
    }
}