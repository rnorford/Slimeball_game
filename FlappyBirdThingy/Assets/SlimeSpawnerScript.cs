using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawnerScript : MonoBehaviour
{

    public GameObject slime;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnSlime();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnSlime();
            timer = 0;
        }
    
        
    }
    
    void spawnSlime() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(slime, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation); //(gameObject,position, rotation)
    }
    
}