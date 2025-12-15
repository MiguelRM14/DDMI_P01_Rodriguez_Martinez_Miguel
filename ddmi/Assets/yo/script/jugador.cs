using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.UIElements;
using System.Security;
[RequireComponent (typeof(Rigidbody2D))]
public class jugador : MonoBehaviour
{

    int speed=  7;
    public int puntos = 10;
    bool enaire = false;
    public TextMeshProUGUI contador_puntos;
    private Rigidbody2D rb;
    public float tiempoaire;
    public ParticleSystem articleSystem;
    public ParticleSystem articleSystem2;
    public ParticleSystem articleSystem3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //ScreenBordersMovement();
        FingerMovement();

        if (enaire == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            //ParticleSystem.MainModule a = ;
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
    }
    private void Caida()
    {
        transform.localScale = new Vector3(1, 1, 1);
        enaire = false;
        articleSystem.Play();
        articleSystem2.Play();
        articleSystem3.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mo"))
        {
            puntos = 5 + puntos;
            contador_puntos.text = puntos.ToString();
        }
        if (collision.gameObject.CompareTag("rampa"))
        {
            transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            enaire = true;
            articleSystem.Stop();
            articleSystem2.Stop();
            articleSystem3.Stop(); 
            Invoke("Caida", tiempoaire);
        }
    }
    private void FingerMovement()
    {
        if (Input.touchCount > 0)
        {
            float FingerMovementX = Input.touches[0].deltaPosition.x;
            transform.Translate(FingerMovementX * speed * Time.deltaTime, 0, 0);
            //rb.linearVelocityX = FingerMovementX*speed;
        }
    }
    /*private void ScreenBordersMovement() 
    {
        if (Input.touchCount > 0)
        {
            float TouchScreenPositionX = Input.touches[0].position.x;
            float ScreenCenter = Screen.width / 2;
            if (TouchScreenPositionX > ScreenCenter)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
                //rb.linearVelocityX=speed
            }
            else
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }
        else Movimiento para Rigidbody
        {
            rb.linearVelocityX = 0;
        } */
}
