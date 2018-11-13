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
  public static int contEmpezar = 0;
  public static int contCreditos = 0;
  public static int contControles = 0;
  public static int level;   
  public static int lifeBoss = 10;  
  public static float timecont1;
  public static int muertes = 0;
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
  public static int curScore;
   
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
  
    public static float tiempoNivel;
    public static float tiempoNivelTutorial;
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
    public static float tiempoTotalNivel;

    public static bool SaltearNivel0 = false;
    public static bool SaltearNivel1 = false;
    public static bool SaltearNivel2 = false;
    public static bool SaltearNivel3 = false;
    public static bool SaltearNivel4 = false;
    public static bool SaltearNivel5 = false;
    public static bool SaltearNivel6 = false;
    public static bool SaltearNivel7 = false;
    public static bool SaltearNivel8 = false;
    public static bool SaltearNivel9 = false;
    public static bool SaltearNivel10 = false;
    public static bool check10;
    public GameObject contador;
    private string sceneName;
    public static Vector3 playerPosition;

    private void Awake()
    {
        Time.timeScale = 1;

    }

    // Use this for initialization
    void Start () {                
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;        
        if (Time.timeScale == 0)
        {
            contador.SetActive(false);
        }

        curScore = 0;

        switch (sceneName)
        {
            case "Menu":
                objMain.SetActive(true);
                niveles.onClick.AddListener(seleccion);
                Jugar.onClick.AddListener(empezarJuego);
                Controles.onClick.AddListener(verControles);
                Creditos.onClick.AddListener(verCreditos);
                Debug.Log("Verificacion variable de checkpoint: " + check10);
                break;
            case "Tutorial":                
                break;
            case "Credits":                
                break;
            case "Controls":                
                break;
            case "Level1":
                //VideoPlay.showoOne = true;                
                break;
            case "Level2":
                //VideoPlay.showoOne = true;                
                break;
            case "Level3":
                //VideoPlay.showoOne = true;                
                break;
            case "Level4":
                //VideoPlay.showoOne = true;                
                break;
            case "Level5":
                //VideoPlay.showoOne = true;                
                break;
            case "Level6":
                //VideoPlay.showoOne = true;                
                break;
            case "Level7":
                //VideoPlay.showoOne = true;                
                break;
            case "Level8":
                //VideoPlay.showoOne = true;                
                break;
            case "Level9":
                //VideoPlay.showoOne = true;                
                break;
            case "Level10":
                //VideoPlay.showoOne = true;                
                break;
        }
        
    
	}
	
	// Update is called once per frame
	void Update () {
        

        if (sceneName == "Menu")
        {            
            //Debug.Log("Variable para verificar checkpoint: " + check10);            
        }             

        else if (sceneName == "Tutorial")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level1")
        {            
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level2")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level3")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level4")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level5")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level6")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level7")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level8")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }
        else if (sceneName == "Level9")
        {
            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
        }        

        else if (sceneName == "Level10")
        {
            Debug.Log(check10);

            if (Time.timeScale != 0)
            {
                contador.SetActive(true);
            }
            else
            {
                contador.SetActive(false);
            }
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
        contEmpezar++;
        Debug.Log("aqui se llama al evento Empezar. El contador es: " + contEmpezar);
        SceneManager.LoadScene("Tutorial");
        check10 = false;
    }

    void verControles()
    {
        contControles++;
        Debug.Log("aqui se llama al evento VerControles. El contador es: " + contControles);
        SceneManager.LoadScene("Controls");
    }

    void verCreditos()
    {
        contCreditos++;
        Debug.Log("aqui se llama al evento VerCreditos. El contador es: " + contCreditos);
        SceneManager.LoadScene("Credits");

       
    }
}
