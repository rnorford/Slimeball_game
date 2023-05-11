using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject life;
    public float spawnRate = 5;
    private float timer = 0;
    public float heightOffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnLife();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnLife();
            timer = 0;
        }
    
        
    }
    
    void spawnLife() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(life, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation); //(gameObject,position, rotation)
    }
}
