using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {
    int score = 0;
    int currentMultiplier = 1;
    float comboTimer = 0.0f;
    int tempScoreHold = 0;
    private string sceneName;
    bool flag = false;
    float originalWidth = 1920.0f; //turn these to floats to fix placement issue
    float originalHeight = 1080.0f;
    Vector3 scale;
    public GUIStyle text;
    public Texture2D bg;
    public GameObject fiveHun, thou;
   
    // Use this for initialization
    void Start() {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update() {

        comboCountdown();
        
    }

    public void AddScore(int val, Vector3 position)
    {
        tempScoreHold += val;
        Vector3 spawnPos = position;
        spawnPos.y += 2;

        if (val == 500) {
            Instantiate(fiveHun, spawnPos, fiveHun.transform.rotation);
        } else if (val == 1000) {
            Instantiate(thou, spawnPos, fiveHun.transform.rotation);
        }
    }

    public void increaseMultiplier()
    {
        Debug.Log("Increased multiplier to " + currentMultiplier);
        currentMultiplier++;
        comboTimer = 3.5f;
    }

    public int getScore()//new
    {
        return score;
    }

    void comboCountdown()
    {

        if (tempScoreHold > 0) {
            comboTimer -= Time.deltaTime;


            // Esto ocurre cuando el timer es mayor a 0
            if (comboTimer <= 0) {
                score += (tempScoreHold * currentMultiplier);
                tempScoreHold = 0;
                currentMultiplier = 1;
                Debug.Log("score actual despues del timer: " + score);
            }
            // fin de timer
            else
            {
                GameManager.curScore = score + (tempScoreHold * currentMultiplier);
                //Debug.Log("Score con el tiempo mayor a 0: " + GameManager.curScore);
                
            }
            
            

        }
        
    }

    public void scoreReset(int val)//new
    {
        score = val;
    }

    void OnGUI()
    {
      
            GUI.depth = 0;
            scale.x = Screen.width / originalWidth;
            scale.y = Screen.height / originalHeight;
            scale.z = 1;
            var svMat = GUI.matrix;
            GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);
            if (CutsceneDisplay.anyCutsceneDisplaying == false && Time.timeScale == 1)
            {
                Rect scorePos = new Rect(originalWidth - 500, (originalHeight - originalHeight) + 25, 200, 100);
                Rect multiPos = new Rect(originalWidth - 500, (originalHeight - originalHeight) + 75, 200, 100);
                Rect diePos = new Rect(originalWidth - 500, (originalHeight - originalHeight) + 50, 200, 100);
                Rect bgPos = new Rect(originalWidth - 750, (originalHeight - originalHeight) + 50, 700, 150);
                GUI.DrawTexture(bgPos, bg);
                if (PlayerHealth.dead == false && Time.timeScale == 1)
                {//changed for ep on cutscenes
                    GUI.Box(scorePos, "Score: " + score, text);
                    GUI.Box(multiPos, "Combo: " + currentMultiplier + " * " + tempScoreHold + " - " + (int)comboTimer, text);
                }
                else if (PlayerHealth.dead)
                {
                    Debug.Log("************************* PlayerHealth.dead");
                    GUI.Box(diePos, "You Died", text);
                }
            }
            GUI.matrix = svMat;
          
    }
}
