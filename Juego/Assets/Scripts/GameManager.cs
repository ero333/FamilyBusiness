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
  public static float timecont1;
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
    
  public static float tiempoNivel1;
    public static float tiempoNivel2;
    public static float tiempoNivel3;
    public static float tiempoNivel4;
    public static float tiempoNivel5;
    public static float tiempoNivel6;
    public static float tiempoNivel7;
    public static float tiempoNivel8;
    public static float tiempoNivel9;
    public static float tiempoNivel10;
 
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
            VideoPlay.showoOne = true;
            curScore1 = 0;
            
                 
        }
    else if (sceneName == "Level2")
        {
            VideoPlay.showoOne = true;
            curScore2 = 0;
            
        }
    else if (sceneName == "Level3")
        {
            VideoPlay.showoOne = true;
            curScore3 = 0;
            
        }
    else if (sceneName == "Level4")
        {
            VideoPlay.showoOne = true;
            curScore4 = 0;
            
        }
    else if (sceneName == "Level5")
        {
            VideoPlay.showoOne = true;
            curScore5 = 0;
            
        }
    else if (sceneName == "Level6")
        {
            VideoPlay.showoOne = true;
            curScore6 = 0;
            
        }
    else if (sceneName == "Level7")
        {
            VideoPlay.showoOne = true;
            curScore7 = 0;
            
        }
    else if (sceneName == "Level8")
        {
            VideoPlay.showoOne = true;
            curScore8 = 0;
            
        }
    else if (sceneName == "Level9")
        {
            VideoPlay.showoOne = true;
            curScore9 = 0;
            
        }
    else if (sceneName == "Level10")
        {
            VideoPlay.showoOne = true;
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

        else if (sceneName == "Level1")
        {
          
        }        

    }

    private void FixedUpdate()
    {
        if (sceneName == "Menu")
        {

        }

        else if (sceneName == "Tutorial")
        {

        }

        else if (sceneName == "Level1")
        {
            tiempoNivel1 = Time.timeSinceLevelLoad;
            

        }
        else if (sceneName == "Level2")
        {
            tiempoNivel2 = Time.timeSinceLevelLoad;
            
        }
        else if (sceneName == "Level3")
        {
            tiempoNivel3 = Time.timeSinceLevelLoad;

        }
        else if (sceneName == "Level4")
        {
            tiempoNivel4 = Time.timeSinceLevelLoad;

        }
        else if (sceneName == "Level5")
        {
            tiempoNivel5 = Time.timeSinceLevelLoad;

        }
        else if (sceneName == "Level6")
        {
            tiempoNivel6 = Time.timeSinceLevelLoad;

        }
        else if (sceneName == "Level7")
        {
            tiempoNivel7 = Time.timeSinceLevelLoad;

        }
        else if (sceneName == "Level8")
        {
            tiempoNivel8 = Time.timeSinceLevelLoad;
        }
        else if (sceneName == "Level9")
        {
            tiempoNivel9 = Time.timeSinceLevelLoad;
        }
        else if (sceneName == "Level10")
        {
            tiempoNivel10 = Time.timeSinceLevelLoad;           
       
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
