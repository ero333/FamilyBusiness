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
    public Text highScore;
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
            highScore.text = "Max High Score: " + GameManager.maxScore1;
            curScore.text = "Current Score: " + GameManager.curScore1;
        }
        else if (sceneName == "Level2")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore2;
            curScore.text = "Current Score: " + GameManager.curScore2;
        }
        else if (sceneName == "Level3")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore3;
            curScore.text = "Current Score: " + GameManager.curScore3;
        }
        else if (sceneName == "Level4")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore4;
            curScore.text = "Current Score: " + GameManager.curScore4;
        }
        else if (sceneName == "Level5")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore5;
            curScore.text = "Current Score: " + GameManager.curScore5;
        }
        else if (sceneName == "Level6")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore6;
            curScore.text = "Current Score: " + GameManager.curScore6;
        }
        else if (sceneName == "Level7")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore7;
            curScore.text = "Current Score: " + GameManager.curScore7;
        }
        else if (sceneName == "Level8")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore8;
            curScore.text = "Current Score: " + GameManager.curScore8;
        }
        else if (sceneName == "Level9")
        {
            highScore.text = "Max High Score: " + GameManager.maxScore9;
            curScore.text = "Current Score: " + GameManager.curScore9;
        }
    }


    void cargarMenu()
    {
        SceneManager.LoadScene("Menu");

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
                //ganoNivel1 = true;
            }
            else if (sceneName == "Level2")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );
                //ganoNivel2 = true;
            }
            else if (sceneName == "Level3")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );
                //ganoNivel3 = true;
            }
            else if (sceneName == "Level4")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );
                //ganoNivel4 = true;
            }
            else if (sceneName == "Level5")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );
                //ganoNivel5 = true;
            }
            else if (sceneName == "Level6")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );
                //ganoNivel6 = true;
            }
            else if (sceneName == "Level7")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );
                //ganoNivel7 = true;
            }
            else if (sceneName == "Level8")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );
                //ganoNivel8 = true;
            }
            else if (sceneName == "Level9")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );
                //ganoNivel9 = true;
            }
            else if (sceneName == "Level10")
            {
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 10}   }
                );
                //ganoNivel10 = true;
            }

        }
    }


}
