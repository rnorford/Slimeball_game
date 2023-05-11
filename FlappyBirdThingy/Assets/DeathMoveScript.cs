using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMoveScript : MonoBehaviour
{
    public float moveSpeed = 5; //default value in Unity
    //public float deadZone = -45;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //physics runs on its own clock
        
        //if (transform.position.x < deadZone) {
            //Destroy(gameObject);
        //}
    }
}
