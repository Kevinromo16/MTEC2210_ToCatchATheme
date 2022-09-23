using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public GameObject [] itemPrefab;
    public Transform leftTran;
    public Transform rightTran;

    public TextMeshPro scoretext;

    
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnItem",0,2);

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();

    }
    public void SpawnItem()
    {

        float rndXvalue = Random.Range(leftTran.position.x, rightTran.position.x);

        Vector2 spawnPos = new Vector2(rndXvalue, leftTran.position.y);

        int index = Random.Range(0, itemPrefab.Length);
        Instantiate(itemPrefab[index], spawnPos, Quaternion.identity);

    }
    
    public void IncrementScore(int value)
    {
        score += value;
    }

}