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
                if (sceneName == "Level1")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 1 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level2")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 2 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level3")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 3 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level4")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 4 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level5")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 5 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level6")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 6 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level7")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 7 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level8")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 8 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level9")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 9 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }

                else if (sceneName == "Level10")
                {
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "nivel", 10 }   }
                );
                    deadName[x] = enemies[x].name;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "enemigo", deadName[x] }   }
                    );
                    deadTime[x] = Time.timeSinceLevelLoad;
                    Analytics.CustomEvent("Matar", new Dictionary<string, object>
                {  { "tiempo", deadTime[x] }   }
                    );
                }




            }
        }
    }

}
