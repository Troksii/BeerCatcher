using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   public static int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <-6f && gameObject.tag != "Koskenkorva" && gameObject.tag != "Long Drink")
        {
            Destroy(gameObject);
            lives--;
        }
        else if (transform.position.y <-6f)
        {
        Destroy(gameObject);
        }
       
    }
}
