using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject death;
    public float spawnRate = 5;
    private float timer = 0;
    public float heightOffset = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnDeath();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnDeath();
            timer = 0;
        }
    
        
    }
    
    void spawnDeath() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(death, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation); //(gameObject,position, rotation)
    }
}
