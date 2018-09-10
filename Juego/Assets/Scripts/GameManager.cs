using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject objMain;
    public GameObject objSecondary;
    public Button inicioJuego;
    public Button volverMenu;
    public Button Jugar;

    private void Awake()
    {
        
        Time.timeScale = 1;
    }

    // Use this for initialization
    void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;    
        
        if (sceneName == "Menu")
        {
             objMain.SetActive(true);
            
        }
    else if (sceneName == "Tutorial")
        {
            
        }
        
    
	}
	
	// Update is called once per frame
	void Update () {

        if (objMain.activeSelf == true)
        {
            inicioJuego.onClick.AddListener(sig);
 
        }

        else
        {
            
            volverMenu.onClick.AddListener(volverMain);
            Jugar.onClick.AddListener(empezarJuego);
            MenuScreen.menu = false;
            MenuScreen.play = true;
            
        }

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
        SceneManager.LoadScene("Video");
    }
}
