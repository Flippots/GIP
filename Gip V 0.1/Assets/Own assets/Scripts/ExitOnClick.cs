using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour
{
    //De functie ExitGame zal bij het On Click
    //event van de QuitButton geconfigureerd worden.
    public void ExitGame()
    {
        //Deze instructie sluit de toepassing af.
        Application.Quit();
    }
}

