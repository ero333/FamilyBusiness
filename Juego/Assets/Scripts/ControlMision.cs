using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMision : MonoBehaviour {

    public SpriteRenderer enemy;
    public static int cont = 0;
   

	// Use this for initialization
	void Start () {
        Debug.Log(enemy.name);

    }


	// Update is called once per frame
	void Update () {

        if (enemy.name == "EnemyAttackTest IZQ")
        {
            if (((enemy.sprite.name == "tut5sprites_13") || (enemy.sprite.name == "tut5sprites_12")) && (cont == 0))
            {
                Destroy(gameObject);
                cont = 1;

            }
        }

        else if (enemy.name == "EnemyAttackTest DER")
        {
            cont = 0;
            if (((enemy.sprite.name == "tut5sprites_13") || (enemy.sprite.name == "tut5sprites_12")) && (cont == 0))
            {
                Destroy(gameObject);
                cont = 1;

            }
        }
    }
}
