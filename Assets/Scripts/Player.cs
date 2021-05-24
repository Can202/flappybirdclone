using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    int score = 0;
    float gravity = 90f;
    bool Nogra = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.UseGravity = false;
            
            Nogra = false;
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 400f)); //sirve
        }
        rb.AddForce(new Vector2(0, -gravity * Time.deltaTime));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            Globle.score += 1;
            Destroy(collision.gameObject);
        }
    }
}
