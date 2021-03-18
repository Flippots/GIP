using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Deze extra library is nodig om de instructie
//LoadScene() te kunnen werken.
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    //Deze functie zullen we in Unity koppelen aan de On Click
    //event van de Start button. Dit is mogelijk omdat dit een
    //public functie is. In Unity zullen we eveneens de waarde
    //voor het argument sceneIndex meegeven.
    public void StartScene(int sceneIndex)
    {
        //De scene met index sceneIndex wordt geladen.
        SceneManager.LoadScene(sceneIndex);
    }
}

