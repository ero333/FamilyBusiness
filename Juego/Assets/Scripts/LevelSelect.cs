using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class LevelSelect : MonoBehaviour {

    public string Level1;
    public string Level2;
    public string Level3;
    public string Level4;
    public string Level5;
    public string Level6;
    public string Level7;
    public string Level8;
    public string Level9;
    public string Level10;


    public void PlayLevel1()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 1 }   }
       );
        Application.LoadLevel(Level1);
    }

    public void PlayLevel2()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 2 }   }
       );
        Application.LoadLevel(Level2);
    }

    public void PlayLevel3()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 3 }   }
       );
        Application.LoadLevel(Level3);
    }

    public void PlayLevel4()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 4 }   }
       );
        Application.LoadLevel(Level4);
    }

    public void PlayLevel5()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 5 }   }
       );
        Application.LoadLevel(Level5);
    }

    public void PlayLevel6()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 6 }   }
       );
        Application.LoadLevel(Level6);
    }

    public void PlayLevel7()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 7 }   }
       );
        Application.LoadLevel(Level7);
    }

    public void PlayLevel8()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 8 }   }
       );
        Application.LoadLevel(Level8);
    }

    public void PlayLevel9()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 9 }   }
       );
        Application.LoadLevel(Level9);
    }

    public void PlayLevel10()
    {
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 10 }   }
       );
        Application.LoadLevel(Level10);
    }









    public void QuitGame()
    {
        Application.Quit();
    }

}
