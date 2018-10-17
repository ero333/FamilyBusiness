using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour {
  //public static GameManager instance;
  public GameObject objMain;    
  public Button niveles;  
  public Button Jugar;
  public Button Controles;
  public Button Creditos;
  public Button Calificar;
  public static int muertes1 = 0;
  public static int muertes2 = 0;
  public static int muertes3 = 0;
  public static int muertes4 = 0;
  public static int muertes5 = 0;
  public static int muertes6 = 0;
  public static int muertes7 = 0;
  public static int muertes8 = 0;
  public static int muertes9 = 0;
  public static int muertes10 = 0;  
  public static int minScore1 = 5500;
  public static int minScore2 = 5500;
  public static int minScore3 = 7000;
  public static int minScore4 = 5500;
  public static int minScore5 = 5500;
  public static int minScore6 = 5500;
  public static int minScore7 = 5500;
  public static int minScore8 = 5500;
  public static int minScore9 = 5500;
  public static int minScore10 = 5500;
  public static int maxScore1 = 15000;
  public static int maxScore2 = 15000;
  public static int maxScore3 = 15000;
  public static int maxScore4 = 39000;
  public static int maxScore5 = 15000;
  public static int maxScore6 = 15000;
  public static int maxScore7 = 15000;
  public static int maxScore8 = 15000;
  public static int maxScore9 = 15000;
  public static int maxScore10 = 15000;
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
        /*if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);   */             


    }

    // Use this for initialization
    void Start () {                
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;        
        if (sceneName == "Menu")
        {
            
             objMain.SetActive(true);
            niveles.onClick.AddListener(seleccion);
            Jugar.onClick.AddListener(empezarJuego);
            Controles.onClick.AddListener(verControles);
            Creditos.onClick.AddListener(verCreditos);
            Calificar.onClick.AddListener(verCalificar);

        }
    else if (sceneName == "Tutorial")
        {
            ContEmpezar.contarEmpezar++;
            Analytics.CustomEvent("Empezar", new Dictionary<string, object>
        {  { "vez", ContEmpezar.contarEmpezar }   }
        );            
          

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
            
        }             

        else if (sceneName == "Tutorial")
        {
            
        }

    }

    void seleccion()
    {
        SceneManager.LoadScene("LevelSelect");
    }    

    void empezarJuego()
    {        
        SceneManager.LoadScene("Tutorial");
    }

    void verControles()
    {
        SceneManager.LoadScene("Controls");
    }

    void verCreditos()
    {
        SceneManager.LoadScene("Credits");
    }
    void verCalificar()
    {
        
    }
}
