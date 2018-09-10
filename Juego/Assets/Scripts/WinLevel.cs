using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour {

    public static bool ganoTuto = false;
    public GameObject menuGanar;
    public Button menu;
    public Button sigNivel;

    // Use this for initialization
    void Start () {
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
        SceneManager.LoadScene("Level1");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            ganoTuto = true;
            menuGanar.SetActive(true);
            
        }
    }


}
