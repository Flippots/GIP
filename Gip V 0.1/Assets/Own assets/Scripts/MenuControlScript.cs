using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Deze extra library is nodig om met de instructie
//LoadScene() te kunnen werken.
using UnityEngine.SceneManagement;

public class MenuControlScript : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        //Als er op de toets Escape geklikt wordt,
        //wordt de scene met index 0 geladen. In de 
        //Build settings van Unity is ingesteld dat
        //dit de scene met het StartMenu is.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}

