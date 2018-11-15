using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class ContarMuertos : MonoBehaviour {

    public GameObject[] enemies;   
    public float[] deadTime;
    public string[] deadName;
    string sceneName;
    public static int contMuertos;
    public static string armaPlayer;
    

    // Use this for initialization
    void Start () {

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        GameObject[] dogs = GameObject.FindGameObjectsWithTag("Dog");
        GameObject[] heavies = GameObject.FindGameObjectsWithTag("Heavy");
        GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("Enemy");
        enemies = new GameObject[dogs.Length + heavies.Length + enemies1.Length];        
        dogs.CopyTo(enemies, 0);
        heavies.CopyTo(enemies, dogs.Length);
        enemies1.CopyTo(enemies, (dogs.Length) + (heavies.Length));
        deadTime = new float[enemies.Length];
        deadName = new string[enemies.Length];
        contMuertos = 0;
        

    }
	
	// Update is called once per frame
	void Update () {
        areAllEnemiesDead();
        //Debug.Log(Time.timeSinceLevelLoad);
        

    }

    public void areAllEnemiesDead()
    {
        for (int x = 0; x < enemies.Length; x++)
        {
            if (enemies[x].tag == "Dead" && deadTime[x] == 0)
            {
                contMuertos++;
                deadName[x] = enemies[x].name;
                deadTime[x] = Time.timeSinceLevelLoad;                

                int level;
                if (sceneName == "Tutorial")
                {
                    level = 0;
                }
                else
                {
                    level = Utils.LevelFromSceneName(sceneName);

                }                

                Debug.Log("nivel de Matar " + level);
                Debug.Log("enemigo de Matar " + deadName[x]);
                Debug.Log("arma de Matar " + armaPlayer);
                Debug.Log("tiempo de Matar " + deadTime[x]);                
                Debug.Log("Insertar evento de Matar aqui");                 

                Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", level },
                   { "enemigo", deadName[x] },
                   { "Arma", armaPlayer },
                   { "tiempo", deadTime[x] },

                }
                );
                armaPlayer = null;

                
            }

        }
    }

}
