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

        if (sceneName == "Level1")
        {
            GameManager.curScore1 = score;
            if (GameManager.curScore1 > GameManager.maxScore1)
            {
                GameManager.maxScore1 = GameManager.curScore1;
            }            
            
        }

        else if (sceneName == "Level2")
        {
            GameManager.curScore2 = score;
            if (GameManager.curScore2 > GameManager.maxScore2)
            {
                GameManager.maxScore2 = GameManager.curScore2;
            }
        }
        else if (sceneName == "Level3")
        {
            GameManager.curScore3 = score;
            if (GameManager.curScore3 > GameManager.maxScore3)
            {
                GameManager.maxScore3 = GameManager.curScore3;
            }
        }
        else if (sceneName == "Level4")
        {
            GameManager.curScore4 = score;
            if (GameManager.curScore4 > GameManager.maxScore4)
            {
                GameManager.maxScore4 = GameManager.curScore4;
            }
        }
        else if (sceneName == "Level5")
        {
            GameManager.curScore5 = score;
            if (GameManager.curScore5 > GameManager.maxScore5)
            {
                GameManager.maxScore5 = GameManager.curScore5;
            }
        }
        else if (sceneName == "Level6")
        {
            GameManager.curScore6 = score;
            if (GameManager.curScore6 > GameManager.maxScore6)
            {
                GameManager.maxScore6 = GameManager.curScore6;
            }
        }
        else if (sceneName == "Level7")
        {
            GameManager.curScore7 = score;
            if (GameManager.curScore7 > GameManager.maxScore7)
            {
                GameManager.maxScore7 = GameManager.curScore7;
            }
        }
        else if (sceneName == "Level8")
        {
            GameManager.curScore8 = score;
            if (GameManager.curScore8 > GameManager.maxScore8)
            {
                GameManager.maxScore8 = GameManager.curScore8;
            }
        }
        else if (sceneName == "Level9")
        {
            GameManager.curScore9 = score;
            if (GameManager.curScore9 > GameManager.maxScore9)
            {
                GameManager.maxScore9 = GameManager.curScore9;
            }
        }
        else if (sceneName == "Level10")
        {
            GameManager.curScore10 = score;
            if (GameManager.curScore10 > GameManager.maxScore10)
            {
                GameManager.maxScore10 = GameManager.curScore10;
            }
        }
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

            if (comboTimer <= 0) {
                score += (tempScoreHold * currentMultiplier);
                tempScoreHold = 0;
                currentMultiplier = 1;
            }
            // Agregar combo hecho al final del nivel
            else if (Time.timeScale == 0 && flag != true)
            {
                score += (tempScoreHold * currentMultiplier);
                flag = true;
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
