using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuScreen : MonoBehaviour {

	static public MenuScreen mu;//new menu 2


	float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
	public bool display = false;    
    public GUIStyle text, boton;    
    public Texture2D bg; //  ELIMINAR SI NO SE APLICA BACKGROUND NEGRO AL SER SELECCIONADO
    //bool playSelect=true, exitSelect=false;
    bool play=false,menu=true;
	public LevelStore[] levels;
	int levelSelectCount = 0;
	static public string curLevel; //new for menu 2
	// Use this for initialization

	void awake()
	{
		if (mu ==null) {//new for menu part 2
			mu = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy(this);
		}

	
	}

	void Start () {        

        if (SceneManager.GetActiveScene ().name.Equals ("Menu")) {
			display = true;
		} else {
			display = false;
		}
		checkForLevelUnlocked ();


	}

	public void saveHighScore()//new for menu 2
	{
		
		LevelStore ls = new LevelStore ();
		for (int x = 0; x < levels.Length; x++) {
			if (levels [x].levelName==curLevel) {
				ls = levels [x];


			}
		}

		ScoreController sc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreController> ();
		Debug.Log ("Saving high score " + sc.getScore () + " For level " + curLevel);
		ls.save (sc.getScore ());
		checkForLevelUnlocked ();
	}
	
	// Update is called once per frame
	void Update () {
		if (display == true) {//all display stuff new for menu part 2
			inputController ();
		}




	}

	void checkForLevelUnlocked()
	{
		for (int x = 1; x <= levels.Length; x++) {
			if (levels [x - 1].highScore > 0) {
				levels [x].unlocked = true;
			}
		}
	}

	void inputController()
    {/*
		if (menu == true) {
            
            if (Input.GetKeyDown (KeyCode.S) && playSelect == true || Input.GetKeyDown (KeyCode.W) && playSelect == true) {
				exitSelect = true;
				playSelect = false;
			} else if (Input.GetKeyDown (KeyCode.S) && exitSelect == true || Input.GetKeyDown (KeyCode.W) && exitSelect == true) {
				exitSelect = false;
				playSelect = true;
			}

            
			if (Input.GetKeyDown (KeyCode.Return)  && playSelect == true) {
				menu = false;
				play = true;
			}
            
            
			else if(Input.GetKeyDown (KeyCode.Return) && exitSelect==true)
			{
				Application.Quit ();
			}

        }
        else */
        if (play == true) {
			curLevel = levels [levelSelectCount].levelName;
            /*
			if (Input.GetKeyDown (KeyCode.Escape)) {
				play = false;
				menu = true;
			}*/

			if (Input.GetKeyDown (KeyCode.D) && levelSelectCount < levels.Length - 1) {
				levelSelectCount++;
				checkForLevelUnlocked ();
			}

			if (Input.GetKeyDown (KeyCode.A) && levelSelectCount > 0) {
				levelSelectCount--;
				checkForLevelUnlocked ();
			}      
                        

           
			if (Input.GetKeyDown (KeyCode.Return) && levels [levelSelectCount].unlocked == true) {
				
				SceneManager.LoadScene (levels [levelSelectCount].sceneManagerName);
				display = false;
			}
		}




	}

	void OnGUI()
	{
		GUI.depth = 0;
		scale.x = Screen.width/originalWidth;
		scale.y = Screen.height/originalHeight;
		scale.z =1;
		var svMat = GUI.matrix;

		GUI.matrix = Matrix4x4.TRS(Vector3.zero,Quaternion.identity,scale);

		if (display == true) {
			//Rect titlePos = new Rect (originalWidth / 2 - 400, originalHeight - originalHeight, 800, 300);
			if (menu == true) {
				play = false;

                //titlePos = new Rect (originalWidth / 2 - 400, originalHeight - originalHeight, 800, 300); ELIMINAR 
                //GUI.Box (titlePos, "Cloneline Miami", titleShadow); ELIMINAR


                //titlePos = new Rect (originalWidth / 2 - 405, originalHeight - originalHeight - 5, 800, 300); ELIMINAR
                //GUI.Box (titlePos, "Cloneline Miami", titleText); ELIMINAR
                

                if (GUI.Button(new Rect(originalWidth / 2 - 230, originalHeight - originalHeight + 600, 500, 100), "Jugar", boton))
                {                    
                    menu = false;
                    play = true;
                }

                /*
                Rect menuPos = new Rect (originalWidth / 2 - 230, originalHeight - originalHeight + 600, 500, 100);
				if (playSelect == true) {                    
                    
                    GUI.Box (menuPos, "NEW GAME", titleText);
				} else if (playSelect == false) {
					GUI.Box (menuPos, "NEW GAME", text);
				}*/

                if (GUI.Button(new Rect(originalWidth / 2 - 230, originalHeight - originalHeight + 750, 500, 100), "Salir", boton))
                {
                    Application.Quit();
                }
                /*
                Rect exitPos = new Rect (originalWidth / 2 - 230, originalHeight - originalHeight + 750, 500, 100);
				if (exitSelect == true) {                  
                    GUI.Box (exitPos, "EXIT", titleText);
				} else if (exitSelect == false) {
					GUI.Box (exitPos, "EXIT", text);
				}*/

                // Este es el segundo menu que aparece

			} else if (play == true) {
                
                // Comienza título de regresar menú
                if ((GUI.Button(new Rect(originalWidth - originalWidth + 900, originalHeight - 250, 500, 100), "Volver", boton)) || (Input.GetKeyDown(KeyCode.Escape)))
                {
                    play = false;
                    menu = true;
                    
                }
                               
                
                /*Rect backToRet = new Rect (originalWidth - originalWidth + 900, originalHeight - 250, 500, 100);
                //GUI.DrawTexture (backToRet, bg); ELIMINAR SI NO SE APLICA BACKGROUND NEGRO AL SER SELECCIONADO                
                GUI.Box (backToRet, "Volver", boton);
                */

                // Termina título de regresar menú

                //titlePos = new Rect (originalWidth / 2 - 400, originalHeight - originalHeight, 800, 300);
                //GUI.Box (titlePos, "Cloneline Miami", titleShadow);


                //titlePos = new Rect (originalWidth / 2 - 405, originalHeight - originalHeight - 5, 800, 300);
                //GUI.Box (titlePos, "Cloneline Miami", titleText);

                if (levels [levelSelectCount].unlocked == true) {

                    // Comienza título de Nivel 1

					Rect levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 600, 500, 100);

					GUI.Box (levelTitlePos, levels [levelSelectCount].levelName, text);

                    // Termina título de nivel

                    //Comienza titulo de High Score

                    levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 725, 500, 100);
                    GUI.Box (levelTitlePos, "High Score : " + levels [levelSelectCount].highScore, text);

                    // Termina titulo de High Score

                    /*
                    // comienza MAPA

                    

                    levelTitlePos = new Rect (originalWidth / 2 - 700, originalHeight - originalHeight + 500, 500, 500);
					GUI.DrawTexture (levelTitlePos, levels [levelSelectCount].levelIcon);

                    // Termina MAPA

                    */

				} else {
                    
                    Rect levelTitlePos = new Rect (originalWidth / 2 - 400, originalHeight - originalHeight + 200, 800, 200);
					GUI.Box (levelTitlePos, "Level Locked", text);                    

                    levelTitlePos = new Rect (originalWidth / 2 - 250, originalHeight - originalHeight + 400, 500, 500);
					GUI.DrawTexture (levelTitlePos, bg);
                    
				}

			}
		}
		GUI.matrix = svMat;
	}
    
}
