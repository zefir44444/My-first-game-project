using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sneak_Control : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Read input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Debug.Log($"Horizontal: {horizontal}, Vertical: {vertical}");
    }
}
