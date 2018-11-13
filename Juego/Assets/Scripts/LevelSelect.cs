using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class LevelSelect : MonoBehaviour {
    public string Menu;


    public void PlayMenu()
    {
        SceneManager.LoadScene("Menu");
        
    }

    public void PlayLevel(int level)
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", level }   }
       );
        SceneManager.LoadScene("Level" + level);

    }

   
}
