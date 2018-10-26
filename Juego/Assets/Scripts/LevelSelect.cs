using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class LevelSelect : MonoBehaviour {
    public string Menu;
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
    private string sceneName;


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    public void PlayMenu()
    {
        SceneManager.LoadScene("Menu");
        
    }

    public void PlayLevel1()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level1");
        
    }

    public void PlayLevel2()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level2");
        
    }

    public void PlayLevel3()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level3");
        
    }

    public void PlayLevel4()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level4");
        
    }

    public void PlayLevel5()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level5");
        
    }

    public void PlayLevel6()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level6");
        
    }

    public void PlayLevel7()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level7");
        
    }

    public void PlayLevel8()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level8");
        
    }

    public void PlayLevel9()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level9");
        
    }

    public void PlayLevel10()
    {
        Analytics.CustomEvent("SeleccionarNivel", new Dictionary<string, object>
        {  { "nivel", sceneName }   }
       );
        SceneManager.LoadScene("Level10");
        GameManager.check10 = false;
        
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
