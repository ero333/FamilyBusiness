using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuScreen : MonoBehaviour {

	static public MenuScreen mu;//new menu 2


	float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
	public bool display = false;    
    public GUIStyle text, boton;    
    public Texture2D bg; //  ELIMINAR SI NO SE APLICA BACKGROUND NEGRO AL SER SELECCIONADO
    public GameObject mapTutorial, volver;  
    public Button volverMenu;
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
        mapTutorial.SetActive(false);
        volver.SetActive(false);
        volverMenu.onClick.AddListener(volverM);               

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
    {
        if (play == true) {
			curLevel = levels [levelSelectCount].levelName;
            mapTutorial.SetActive(true);
            volver.SetActive(true);            

            if (Input.GetKeyDown (KeyCode.D) && levelSelectCount < levels.Length - 1) {
				levelSelectCount++;
				checkForLevelUnlocked ();
			}

			if (Input.GetKeyDown (KeyCode.A) && levelSelectCount > 0) {
				levelSelectCount--;
				checkForLevelUnlocked ();
			}      
                                   
			if (Input.GetKeyDown (KeyCode.Mouse0) && levels [levelSelectCount].unlocked == true && Hover.onhover == false) {
                
				SceneManager.LoadScene (levels [levelSelectCount].sceneManagerName);
				display = false;
			}
		}

	}


    void volverM()
    {
        play = false;
        menu = true;
        mapTutorial.SetActive(false);
        volver.SetActive(false);
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
			
			if (menu == true) {

				play = false;
                          
                if (GUI.Button(new Rect(originalWidth / 2 - 230, originalHeight - originalHeight + 600, 500, 100), "Jugar", boton))
                {                    
                    menu = false;
                    play = true;
                }

                if (GUI.Button(new Rect(originalWidth / 2 - 230, originalHeight - originalHeight + 750, 500, 100), "Salir", boton))
                {
                    Application.Quit();
                }

                // Este es el segundo menu que aparece

			} else if (play == true) {
                
               

                if (levels [levelSelectCount].unlocked == true) {

                    // Comienza título de Nivel 1

					Rect levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 600, 500, 100);

					GUI.Box (levelTitlePos, levels [levelSelectCount].levelName, text);

                    // Termina título de nivel

                    //Comienza titulo de High Score

                    levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 725, 500, 100);
                    GUI.Box (levelTitlePos, "High Score : " + levels [levelSelectCount].highScore, text);

                    // Termina titulo de High Score

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
