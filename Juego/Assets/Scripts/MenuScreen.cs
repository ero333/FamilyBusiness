using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuScreen : MonoBehaviour {

	static public MenuScreen mu;//new menu 2


	float originalWidth = 1920.0f; //turn these to floats to fix placement issue
	float originalHeight = 1080.0f;
	Vector3 scale;
	public static bool display = false;    
    public GUIStyle text;       
    public static bool play=false,menu=true;
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
    {
        if (play == true) {
			curLevel = levels [levelSelectCount].levelName;
         

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

                // Este es el segundo menu que aparece

			} else if (play == true) {                               

                if (levels [levelSelectCount].unlocked == true) {

                    // Comienza título de Nivel 1

					Rect levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 500, 800, 100);

					GUI.Box (levelTitlePos, levels [levelSelectCount].levelName, text);

                    // Termina título de nivel

                    //Comienza titulo de High Score

                    levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 575, 800, 100);
                    GUI.Box (levelTitlePos, "High Score : " + levels [levelSelectCount].highScore, text);

                    // Termina titulo de High Score

				} else {

                    Rect levelTitlePos = new Rect (originalWidth / 2 - 50, originalHeight - originalHeight + 500, 800, 100);
                    GUI.Box (levelTitlePos, "Level Locked", text);                    
                   
                }

            }
		}
		GUI.matrix = svMat;
    
	}
    
}
