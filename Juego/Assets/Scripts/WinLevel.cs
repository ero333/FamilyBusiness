using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class WinLevel : MonoBehaviour
{    
    public GameObject menuGanar;
    public Button menu;
    public Button sigNivel;
    private string sceneName;
    public GameObject cartelWin;
    public GameObject Score;    
    public Text curScore;
    public Text Calificar;

    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        menuGanar.SetActive(false);        
        menu.onClick.AddListener(cargarMenu);        
        sigNivel.onClick.AddListener(siguienteNivel);
        Score.SetActive(false);
        
        switch (sceneName)
        {
            case "Menu":                
                break;
            case "Tutorial":
                break;
            case "Credits":
                break;
            case "Controls":
                break;
            case "Level1":
                break;
            case "Level2":
                break;
            case "Level3":
                break;
            case "Level4":
                break;
            case "Level5":
                break;
            case "Level6":
                break;
            case "Level7":
                break;
            case "Level8":
                break;
            case "Level9":
                break;
            case "Level10":
                Calificar.text = "Calificar Juego";
                break;
        }      

    }

    private void Update()
    {
        
        if (sceneName == "Level1")
        {
            if (GameManager.curScore >= GameManager.maxScore1)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore1)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore1 && GameManager.curScore <= (GameManager.minScore1 + GameManager.maxScore1) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore1 && GameManager.curScore >= (GameManager.minScore1 + GameManager.maxScore1) / 2){
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }

        }
        else if (sceneName == "Level2")
        {

            if (GameManager.curScore >= GameManager.maxScore2)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore2)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore2 && GameManager.curScore <= (GameManager.minScore2 + GameManager.maxScore2) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore2 && GameManager.curScore >= (GameManager.minScore2 + GameManager.maxScore2) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level3")
        {

            if (GameManager.curScore >= GameManager.maxScore3)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore3)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore3 && GameManager.curScore <= (GameManager.minScore3 + GameManager.maxScore3) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore3 && GameManager.curScore >= (GameManager.minScore3 + GameManager.maxScore3) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level4")
        {

            if (GameManager.curScore >= GameManager.maxScore4)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore4)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore4 && GameManager.curScore <= (GameManager.minScore4 + GameManager.maxScore4) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore4 && GameManager.curScore >= (GameManager.minScore4 + GameManager.maxScore4) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level5")
        {

            if (GameManager.curScore >= GameManager.maxScore5)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore5)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore5 && GameManager.curScore <= (GameManager.minScore5 + GameManager.maxScore5) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore5 && GameManager.curScore >= (GameManager.minScore5 + GameManager.maxScore5) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level6")
        {

            if (GameManager.curScore >= GameManager.maxScore6)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore6)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore6 && GameManager.curScore <= (GameManager.minScore6 + GameManager.maxScore6) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore6 && GameManager.curScore >= (GameManager.minScore6 + GameManager.maxScore6) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level7")
        {

            if (GameManager.curScore >= GameManager.maxScore7)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore7)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore7 && GameManager.curScore <= (GameManager.minScore7 + GameManager.maxScore7) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore7 && GameManager.curScore >= (GameManager.minScore7 + GameManager.maxScore7) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level8")
        {

            if (GameManager.curScore >= GameManager.maxScore8)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore8)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore8 && GameManager.curScore <= (GameManager.minScore8 + GameManager.maxScore8) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore8 && GameManager.curScore >= (GameManager.minScore8 + GameManager.maxScore8) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level9")
        {

            if (GameManager.curScore >= GameManager.maxScore9)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore9)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore9 && GameManager.curScore <= (GameManager.minScore9 + GameManager.maxScore9) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore9 && GameManager.curScore >= (GameManager.minScore9 + GameManager.maxScore9) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level10")
        {

            if (GameManager.curScore >= GameManager.maxScore10)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore == GameManager.minScore10)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore > GameManager.minScore10 && GameManager.curScore <= (GameManager.minScore10 + GameManager.maxScore10) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore < GameManager.maxScore10 && GameManager.curScore >= (GameManager.minScore10 + GameManager.maxScore10) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
    }


    void cargarMenu()
    {
        SceneManager.LoadScene("Menu");

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            menuGanar.SetActive(true);
            cartelWin.SetActive(false);
            Score.SetActive(true);            
            GameManager.tiempoTotalNivel += Time.timeSinceLevelLoad;
            
            
            int level;
            if (sceneName == "Tutorial")
            {
                level = 0;
            }
            else
            {
                level = Utils.LevelFromSceneName(sceneName);

            }
            Debug.Log("nivel de TerminarNivel es: " + level);
            Debug.Log("tiempo de TerminarNivel es: " + GameManager.tiempoTotalNivel);
            Debug.Log("tiempoultimoreintento de TerminarNivel es: " + Time.timeSinceLevelLoad);
            Debug.Log("puntos de TerminarNivel es: " + GameManager.curScore);
            Debug.Log("muertes de TerminarNivel es: " + GameManager.muertes);            
            Debug.Log("Insertar evento de TerminarNivel");

            Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
            {   { "nivel", level },
                { "tiempo", GameManager.tiempoTotalNivel },
                { "tiempoultimoreintento", Time.timeSinceLevelLoad },
                { "puntos", GameManager.curScore },
                { "muertes", GameManager.muertes }
            }
            );
            


        }
    }

    void siguienteNivel()
    {
        int level;

       if(sceneName == "Tutorial")
       {
            level = 0;
       }
       else
       {
            level = Utils.LevelFromSceneName(sceneName);
           
        }


        level++;
        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", level }   }
        );        
        Debug.Log("EmpezarNivel: " + level);

        SceneManager.LoadScene("Level"  + level);
        
        GameManager.tiempoTotalNivel = 0; //Resetea la variable a cero para el proximo nivel
        GameManager.muertes = 0; //Resetea la variable a cero para el proximo nivel
        //GameManager.curScore = 0; //Resetea la variable a cero para el proximo nivel

    }
}
