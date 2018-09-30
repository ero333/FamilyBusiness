using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour {

    public static bool ganoTuto = false;
    public static bool ganoNivel1 = false;
    public static bool ganoNivel2 = false;
    public static bool ganoNivel3 = false;
    public GameObject menuGanar;
    public Button menu;
    public Button sigNivel;
    private string sceneName;
    public GameObject cartelWin;

    // Use this for initialization
    void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        menuGanar.SetActive(false);
        menu.onClick.AddListener(cargarMenu);
        sigNivel.onClick.AddListener(siguienteNivel);
	}



    void cargarMenu()
    {
        SceneManager.LoadScene("Menu");        

    }    

    void siguienteNivel()
    {
        if (sceneName == "Tutorial")
        {
            SceneManager.LoadScene("Level1");
        }
        else if (sceneName == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (sceneName == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (sceneName == "Level3")
        {
            SceneManager.LoadScene("Level4");
        }
        else if (sceneName == "Level4")
        {
            SceneManager.LoadScene("Level5");
        }
        else if (sceneName == "Level5")
        {
            SceneManager.LoadScene("Level6");
        }
        else if (sceneName == "Level6")
        {
            SceneManager.LoadScene("Level7");
        }
        else if (sceneName == "Level7")
        {
            SceneManager.LoadScene("Level8");
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            menuGanar.SetActive(true);
            cartelWin.SetActive(false);
            if (sceneName == "Tutorial")
            {
                ganoTuto = true;
            }
            else if (sceneName == "Level1")
            {
                ganoNivel1 = true;
            }
            else if (sceneName == "Level2")
            {
                ganoNivel2 = true;
            }
            else if (sceneName == "Level3")
            {
                ganoNivel3 = true;
            }
            
            
        }
    }


}
