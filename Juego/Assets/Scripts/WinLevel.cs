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
            //Debug.Log("El score final es de: " + GameManager.curScore);

            if (sceneName == "Tutorial")
            {                                
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
                {  { "nivel", 0}   }
                );

            }
            else if (sceneName == "Level1")
            {
                GameManager.tiempoTotalNivel1 += Time.timeSinceLevelLoad;
                Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 1}, 
						{ "puntos", GameManager.curScore1 },
						{ "muertes", GameManager.muertes1 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel1 } 

					}
                );                             


            }
            else if (sceneName == "Level2")
            {
                GameManager.tiempoTotalNivel2 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 2}, 
						{ "puntos", GameManager.curScore2 },
						{ "muertes", GameManager.muertes2 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel2 } 

					}
				);   


            }
            else if (sceneName == "Level3")
            {
                GameManager.tiempoTotalNivel3 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 3}, 
						{ "puntos", GameManager.curScore3 },
						{ "muertes", GameManager.muertes3 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel3 } 

					}
				);   

            }
            else if (sceneName == "Level4")
            {
                GameManager.tiempoTotalNivel4 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 4}, 
						{ "puntos", GameManager.curScore4 },
						{ "muertes", GameManager.muertes4 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel4 } 

					}
				);   

            }
            else if (sceneName == "Level5")
            {
                GameManager.tiempoTotalNivel5 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 5}, 
						{ "puntos", GameManager.curScore5 },
						{ "muertes", GameManager.muertes5 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel5 } 

					}
				);   

            }
            else if (sceneName == "Level6")
            {
                GameManager.tiempoTotalNivel6 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 6}, 
						{ "puntos", GameManager.curScore6 },
						{ "muertes", GameManager.muertes6 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel6 } 

					}
				);   

            }
            else if (sceneName == "Level7")
            {
                GameManager.tiempoTotalNivel7 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 7}, 
						{ "puntos", GameManager.curScore7 },
						{ "muertes", GameManager.muertes7 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel7 } 

					}
				);   

            }
            else if (sceneName == "Level8")
            {
                GameManager.tiempoTotalNivel8 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 8}, 
						{ "puntos", GameManager.curScore8 },
						{ "muertes", GameManager.muertes8 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel8 } 

					}
				);   

            }
            else if (sceneName == "Level9")
            {
                GameManager.tiempoTotalNivel9 += Time.timeSinceLevelLoad;               
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 9}, 
						{ "puntos", GameManager.curScore9 },
						{ "muertes", GameManager.muertes9 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel9 } 

					}
				);   

            }
            else if (sceneName == "Level10")
            {
                GameManager.tiempoTotalNivel10 += Time.timeSinceLevelLoad;
				Analytics.CustomEvent("TerminarNivel", new Dictionary<string, object>
					{  { "nivel", 10}, 
						{ "puntos", GameManager.curScore10 },
						{ "muertes", GameManager.muertes10 },
						{ "tiempoultimoreintento", Time.timeSinceLevelLoad },
						{ "tiempo", GameManager.tiempoTotalNivel10 } 

					}
				);   

            }

        }
    }

    void siguienteNivel()
    {
        int level;

       if(sceneName == "Tutorial")
       {
            level = 1;
       }
       else
       {
            if(!int.TryParse(sceneName.Substring(5), out level))
            {
                Debug.Log("Error: No es un numero");
                return;
            }
            level++;
        }

        

        Analytics.CustomEvent("EmpezarNivel", new Dictionary<string, object>
        {  { "nivel", level }   }
        );

        SceneManager.LoadScene("Level"  + level);
        
        GameManager.tiempoTotalNivel = 0;
                
    }
}
