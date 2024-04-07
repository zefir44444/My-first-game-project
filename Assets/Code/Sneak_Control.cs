using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Sneak_Control : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is run");
    }

    // Update is called once per frame
    void Update()
    {
        //Read input from the player
        UnityEngine.Vector2 input = ReadInput();

        //Snake current location in the game per frame
        //Vector3 position = transform.position;
        //position.y = position.y +  0.01f;
        //transform.position = position;

        //Read postition of the snake
        //smooth movemenet
        UnityEngine.Vector3 movemenet = new UnityEngine.Vector3(input.x, input.y, 0) * speed * Time.deltaTime;
        transform.position += movemenet;
    }

    private static UnityEngine.Vector2 ReadInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        return new UnityEngine.Vector2(horizontal, vertical);
    }
}
