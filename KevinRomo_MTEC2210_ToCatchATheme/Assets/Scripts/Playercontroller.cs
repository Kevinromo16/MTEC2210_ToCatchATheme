using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public Transform otherObject;
    public float speed = 5; 
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float xMOve = Input.GetAxis("Horizontal");

        transform.Translate(xMOve * speed * Time.deltaTime , 0, 0); 

    }
}
