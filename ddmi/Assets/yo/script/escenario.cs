using UnityEngine;

public class escenario : MonoBehaviour
{
    public float speed = 1f;
    public float tamaño;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed* Time.deltaTime,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("crear"))
        {
            generador.CrearPiezaNueva(transform.position - new Vector3(0, tamaño, 0));
        }  
        if (collision.gameObject.CompareTag("destruir"))
        {
            Destroy(gameObject);
        }
    }
}
