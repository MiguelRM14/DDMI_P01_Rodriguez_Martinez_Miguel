using UnityEngine;
[RequireComponent (typeof(Rigidbody2D))]
public class jugador : MonoBehaviour
{
    int speed=  7;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);
        }
        /* if (Input.GetKeyDown(KeyCode.D)) 
        {
            rb.linearVelocityX = speed;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocityY = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX = -speed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.linearVelocityY = 0;
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("tronco"))
        {
            speed = 4;
        }
    }
}
