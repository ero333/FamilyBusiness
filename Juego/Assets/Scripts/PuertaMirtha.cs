using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PuertaMirtha : MonoBehaviour {
    public GameObject[] enemies;
    public static bool apagado = false;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (areAllEnemiesDead() == true) //&& timeLeft != 0)
        {
            apagado = true;
            this.gameObject.SetActive(false);
            
        }
    }


    public bool areAllEnemiesDead()
    {
        for (int x = 0; x < enemies.Length; x++)
        {
            if (enemies[x].tag != "Dead")
            {
                return false;
            }
        }

        return true;
    }

}
