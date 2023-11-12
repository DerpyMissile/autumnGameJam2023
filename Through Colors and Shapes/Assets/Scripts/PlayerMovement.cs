using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float Move;
    public float jump;
    private Rigidbody2D rb;
    public int numJumps = 1;
    public int maxJumps = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        if((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W )) && numJumps > 0){
            rb.velocity = new Vector2(rb.velocity.x, jump);
            numJumps -= 1;
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        numJumps = maxJumps;
    }
}
