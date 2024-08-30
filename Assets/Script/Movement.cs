using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
     [SerializeField]int jumpPower;
    int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 3;
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "pindah")
        {
            SceneManager.LoadScene("Scene3");
        }

        if(col.tag == "pindah1")
        {
            SceneManager.LoadScene("Scene4");
        }
          
          if(col.tag == "pindah2")
        {
            SceneManager.LoadScene("Scene5");
        }
        if(col.tag == "pindah3")
        {
            SceneManager.LoadScene("Scene2");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0,0);
        if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed,0);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-speed,0);
        }
         if(Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }
}
