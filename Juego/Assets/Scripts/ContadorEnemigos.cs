using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorEnemigos : MonoBehaviour {

    public GameObject[] enemies;    
    public Text contEnemigos;
    public static int enemigosLeft = 0;
    


    // Update is called once per frame
    void Update()
    {        
        GameObject[] dogs = GameObject.FindGameObjectsWithTag("Dog");
        GameObject[] heavies = GameObject.FindGameObjectsWithTag("Heavy");
        GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("Enemy");
        enemies = new GameObject[dogs.Length + heavies.Length + enemies1.Length];
        dogs.CopyTo(enemies, 0);
        heavies.CopyTo(enemies, dogs.Length);
        enemies1.CopyTo(enemies, (dogs.Length) + (heavies.Length));        
        areAllEnemiesDead();
        contEnemigos.text = "Enemigos restantes " + enemies.Length;
        enemigosLeft = enemies.Length;

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
