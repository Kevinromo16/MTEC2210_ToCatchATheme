using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCard : MonoBehaviour
{

    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 3);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);

    }
}
