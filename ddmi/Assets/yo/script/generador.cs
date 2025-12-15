using UnityEngine;
using System.Collections.Generic;
public class generador : MonoBehaviour
{
    private static generador instance;
    public List<GameObject> pieza;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void CrearPiezaNueva(Vector3 spawnPosition )
    {
        Instantiate(instance.pieza[Random.Range(0,instance.pieza.Count)], spawnPosition, Quaternion.identity);
    }
}
