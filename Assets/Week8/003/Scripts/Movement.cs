using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = .05f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   void Awake() 
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.F)){

           rb.bodyType = RigidbodyType2D.Dynamic;
        }
    
         
    
        if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(Vector2.right * -1 * speed);
        }
        
        if (Input.GetKey(KeyCode.RightArrow)){

            transform.Translate(Vector2.right * speed);
             
        }
        if (Input.GetKey(KeyCode.DownArrow)){

            transform.Translate(Vector2.up * -1 * speed);
        }
        
        if (Input.GetKey(KeyCode.UpArrow)){

            transform.Translate(Vector2.up * speed);
             
        }
    }
}
