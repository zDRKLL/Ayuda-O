using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Csharpscript : MonoBehaviour
{
    //Vida del NPC
    public int health = 5;
    //Nivel del NPC
    public int level = 1;
    //Velocidad del NPC
    public float speed = 1.2f;
    //
    Vector3 newPosition;







    // Start is called before the first frame update
    void Start()
    {
        //Escribir "Hola" en la consola
        print("Hola");
        newPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //Actualiza la vida constantemente.
        health += level;
        print(health)
            ; newPosition.z +=
speed * Time.deltaTime;
        transform.position = newPosition;


    }
}
