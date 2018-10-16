using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class WinLevel : MonoBehaviour
{

    // APLICAR SOLO PARA DESBLOQUEAR NIVELES
    public static bool ganoTuto = false;
    /*public static bool ganoNivel1 = false;
    public static bool ganoNivel2 = false;
    public static bool ganoNivel3 = false;*/
    public GameObject menuGanar;
    public Button menu;
    public Button sigNivel;
    private string sceneName;
    public GameObject cartelWin;
    public GameObject Score;    
    public Text curScore;

    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        menuGanar.SetActive(false);
        menu.onClick.AddListener(cargarMenu);
        sigNivel.onClick.AddListener(siguienteNivel);
        Score.SetActive(false);



    }

    private void Update()
    {
        if (sceneName == "Level1")
        {
            if (GameManager.curScore1 >= GameManager.maxScore1)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore1 == GameManager.minScore1)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore1 > GameManager.minScore1 && GameManager.curScore1 <= (GameManager.minScore1 + GameManager.maxScore1) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore1 < GameManager.maxScore1 && GameManager.curScore1 >= (GameManager.minScore1 + GameManager.maxScore1) / 2){
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }

        }
        else if (sceneName == "Level2")
        {

            if (GameManager.curScore2 >= GameManager.maxScore2)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore2 == GameManager.minScore2)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore2 > GameManager.minScore2 && GameManager.curScore2 <= (GameManager.minScore2 + GameManager.maxScore2) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore2 < GameManager.maxScore2 && GameManager.curScore2 >= (GameManager.minScore2 + GameManager.maxScore2) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level3")
        {

            if (GameManager.curScore3 >= GameManager.maxScore3)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore3 == GameManager.minScore3)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore3 > GameManager.minScore3 && GameManager.curScore3 <= (GameManager.minScore3 + GameManager.maxScore3) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore3 < GameManager.maxScore3 && GameManager.curScore3 >= (GameManager.minScore3 + GameManager.maxScore3) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level4")
        {

            if (GameManager.curScore4 >= GameManager.maxScore4)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore4 == GameManager.minScore4)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore4 > GameManager.minScore4 && GameManager.curScore4 <= (GameManager.minScore4 + GameManager.maxScore4) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore4 < GameManager.maxScore4 && GameManager.curScore4 >= (GameManager.minScore4 + GameManager.maxScore4) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level5")
        {

            if (GameManager.curScore5 >= GameManager.maxScore5)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore5 == GameManager.minScore5)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore5 > GameManager.minScore5 && GameManager.curScore5 <= (GameManager.minScore5 + GameManager.maxScore5) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore5 < GameManager.maxScore5 && GameManager.curScore5 >= (GameManager.minScore5 + GameManager.maxScore5) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level6")
        {

            if (GameManager.curScore6 >= GameManager.maxScore6)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore6 == GameManager.minScore6)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore6 > GameManager.minScore6 && GameManager.curScore6 <= (GameManager.minScore6 + GameManager.maxScore6) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore6 < GameManager.maxScore6 && GameManager.curScore6 >= (GameManager.minScore6 + GameManager.maxScore6) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level7")
        {

            if (GameManager.curScore7 >= GameManager.maxScore7)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore7 == GameManager.minScore7)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore7 > GameManager.minScore7 && GameManager.curScore7 <= (GameManager.minScore7 + GameManager.maxScore7) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore7 < GameManager.maxScore7 && GameManager.curScore7 >= (GameManager.minScore7 + GameManager.maxScore7) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level8")
        {

            if (GameManager.curScore8 >= GameManager.maxScore8)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore8 == GameManager.minScore8)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore8 > GameManager.minScore8 && GameManager.curScore8 <= (GameManager.minScore8 + GameManager.maxScore8) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore8 < GameManager.maxScore8 && GameManager.curScore8 >= (GameManager.minScore8 + GameManager.maxScore8) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level9")
        {

            if (GameManager.curScore9 >= GameManager.maxScore9)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore9 == GameManager.minScore9)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore9 > GameManager.minScore9 && GameManager.curScore9 <= (GameManager.minScore9 + GameManager.maxScore9) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore9 < GameManager.maxScore9 && GameManager.curScore9 >= (GameManager.minScore9 + GameManager.maxScore9) / 2)
            {
                curScore.text = "Obtuviste una B. Puntaje por arriba de la mitad";
            }
        }
        else if (sceneName == "Level10")
        {

            if (GameManager.curScore10 >= GameManager.maxScore10)
            {
                curScore.text = "Obtuviste una A. Puntaje perfecto!!";
            }

            else if (GameManager.curScore10 == GameManager.minScore10)
            {
                curScore.text = "Obtuviste una D. Puntaje mínimo.";
            }

            else if (GameManager.curScore10 > GameManager.minScore10 && GameManager.curScore10 <= (GameManager.minScore10 + GameManager.maxScore10) / 2)
            {
                curScore.text = "Obtuviste una C. Puntaje por arriba del mínimo";
            }

            else if (GameManager.curScore10 < GameManager.maxScore10 && GameManager.curScore10 >= (GameManager.minScore10 + GameManager.maxScore10) / 2)
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
            

            if (sceneName == "Tutorial")
            {
                ganoTuto = true;
            }
            else if (sceneName == "Level1")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 1 }   }
                );
                
            }
            else if (sceneName == "Level2")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );
                
            }
            else if (sceneName == "Level3")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );
                
            }
            else if (sceneName == "Level4")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );
                
            }
            else if (sceneName == "Level5")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );
                
            }
            else if (sceneName == "Level6")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );
                
            }
            else if (sceneName == "Level7")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );
                
            }
            else if (sceneName == "Level8")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );
                
            }
            else if (sceneName == "Level9")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );
                
            }
            else if (sceneName == "Level10")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 10}   }
                );
                
            }

        }
    }

    void siguienteNivel()
    {
        if (sceneName == "Tutorial")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 1 }   }
        );

            SceneManager.LoadScene("Level1");
        }
        else if (sceneName == "Level1")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", 2 }   }
        );
            SceneManager.LoadScene("Level2");
        }
        else if (sceneName == "Level2")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 3 }   }
            );
            SceneManager.LoadScene("Level3");
        }
        else if (sceneName == "Level3")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 4 }   }
            );
            SceneManager.LoadScene("Level4");
        }
        else if (sceneName == "Level4")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 5 }   }
            );
            SceneManager.LoadScene("Level5");
        }
        else if (sceneName == "Level5")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 6 }   }
            );
            SceneManager.LoadScene("Level6");
        }
        else if (sceneName == "Level6")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 7 }   }
            );
            SceneManager.LoadScene("Level7");
        }
        else if (sceneName == "Level7")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 8 }   }
            );
            SceneManager.LoadScene("Level8");
        }
        else if (sceneName == "Level8")
        {
            Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
                {  { "nivel", 9 }   }
            );
            SceneManager.LoadScene("Level9");
        }

    }
}
