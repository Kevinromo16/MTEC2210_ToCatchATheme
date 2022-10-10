using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public AudioClip coinClip;
    public AudioClip hazardClip;

    public AudioSource audioSource;
    public GameManager gm;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float xMOve = Input.GetAxis("Horizontal");

        transform.Translate(xMOve * speed * Time.deltaTime, 0, 0);

    }
 
    private void OnTriggerEnter2D(Collider2D collider)
    
    {
        if (collider.gameObject.tag == "Goal")
        {
            gm.IncrementScore(1);

            gm.playSound(coinClip);
            Destroy(collider.gameObject);        
        }

        if (collider.gameObject.tag == "Red")
        {
            gm.playSound(hazardClip);
            Destroy(gameObject);       
        }
    

    }
}
