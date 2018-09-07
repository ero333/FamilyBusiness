using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour {

    public static bool ganoTuto = false;
    public Canvas canvas;
    public Button menu, quit;
    
	// Use this for initialization
	void Start () {
        canvas.enabled = false;
        menu.onClick.AddListener(cargarMenu);
        quit.onClick.AddListener(salir);        
	}

    void cargarMenu()
    {
        SceneManager.LoadScene("Testing");        

    }

    void salir()
    {
        Application.Quit();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            ganoTuto = true;
            canvas.enabled = true;
        }
    }


}
