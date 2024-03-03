using System.Collections;
using System.Collections.Generic;
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
        Vector2 input = ReadInput();

        //Read postition of the snake
        Vector3 movemenet = new Vector3(input.x, input.y, 0) * speed * Time.deltaTime;
        transform.position += movemenet;
    }

    private static Vector2 ReadInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        return new Vector2(horizontal, vertical);
    }
}
