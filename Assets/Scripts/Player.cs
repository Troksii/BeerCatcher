using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    Vector3 pos;
    Rigidbody2D Rigidbody;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
        pos = Input.mousePosition;
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(pos);
        transform.position = new Vector3(objPosition.x, transform.position.y, transform.position.z);
        }

    }

    
}
