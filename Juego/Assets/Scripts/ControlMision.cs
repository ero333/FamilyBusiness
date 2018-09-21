using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMision : MonoBehaviour {

    public SpriteRenderer enemy;
    public static int cont = 0;
       
	// Update is called once per frame
	void Update () {

        if (enemy.name == "Enemigo Oficial IZQ")
        {
            if (((enemy.sprite.name == "Apuñalado") || (enemy.sprite.name == "Bala")) && (cont == 0))
            {
                Destroy(gameObject);
                cont = 1;
                Debug.Log("Puerta 1 se abre");

            }
        }

        else if (enemy.name == "Enemigo Oficial DER")
        {
            cont = 0;
            if (((enemy.sprite.name == "Apuñalado") || (enemy.sprite.name == "Bala")) && (cont == 0))
            {
                Destroy(gameObject);
                cont = 1;
                Debug.Log("Puerta 2 se abre");
            }
        }
    }
}
