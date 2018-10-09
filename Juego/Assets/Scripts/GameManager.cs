using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour {
  public GameObject objMain;
  public GameObject objSecondary;
  public Button inicioJuego;
  public Button niveles;
  public Button volverMenu;
  public Button Jugar;
  public int contEmpezar = 0;
  public static int maxScore1 = 0;
  public static int maxScore2 = 0;
  public static int maxScore3 = 0;
  public static int maxScore4 = 0;
  public static int maxScore5 = 0;
  public static int maxScore6 = 0;
  public static int maxScore7 = 0;
  public static int maxScore8 = 0;
  public static int maxScore9 = 0;
  public static int maxScore10 = 0;
  public static int curScore1;
  public static int curScore2;
  public static int curScore3;
  public static int curScore4;
  public static int curScore5;
  public static int curScore6;
  public static int curScore7;
  public static int curScore8;
  public static int curScore9;
  public static int curScore10;
  
  private string sceneName;  

    private void Awake()
    {
        Time.timeScale = 1;
        
    }

    // Use this for initialization
    void Start () {                
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;    
        
        if (sceneName == "Menu")
        {
             objMain.SetActive(true);          

        }
    else if (sceneName == "Level1")
        {
            curScore1 = 0;
        }
    else if (sceneName == "Level2")
        {
            curScore2 = 0;
        }
    else if (sceneName == "Level3")
        {
            curScore3 = 0;
        }
    else if (sceneName == "Level4")
        {
            curScore4 = 0;
        }
    else if (sceneName == "Level5")
        {
            curScore5 = 0;
        }
    else if (sceneName == "Level6")
        {
            curScore6 = 0;
        }
    else if (sceneName == "Level7")
        {
            curScore7 = 0;
        }
    else if (sceneName == "Level8")
        {
            curScore8 = 0;
        }
    else if (sceneName == "Level9")
        {
            curScore9 = 0;
        }
    else if (sceneName == "Level10")
        {
            curScore10 = 0;
        }
        


    
	}
	
	// Update is called once per frame
	void Update () {
        if (sceneName == "Menu")
        {
        
            if (objMain.activeSelf == true)
            {
            inicioJuego.onClick.AddListener(sig);
            niveles.onClick.AddListener(seleccion);
            MenuScreen.menu = true;
            MenuScreen.play = false;
            }

            else
            {
            
            volverMenu.onClick.AddListener(volverMain);
            Jugar.onClick.AddListener(empezarJuego);
            MenuScreen.menu = false;
            MenuScreen.play = true;
            
            }
        }             

        else if (sceneName == "Tutorial")
        {            
           
        }

    }

    void seleccion()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    void sig()
    {       
        objMain.SetActive(false);
        objSecondary.SetActive(true);
    }

    void volverMain()
    {
        objMain.SetActive(true);
        objSecondary.SetActive(false);
    }

    void empezarJuego()
    {
        Analytics.CustomEvent("Empezar", new Dictionary<string, object>
        {  { "Vez", contEmpezar }   }
       );
        contEmpezar += 1;
        SceneManager.LoadScene("Tutorial");
        
    }
}
