using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeObject : MonoBehaviour
{

    public LivesManager lm;

    // Start is called before the first frame update
    void Start()
    {
        lm = GameObject.FindGameObjectWithTag("Lives").GetComponent<LivesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            lm.getLife();
            //Destroy(gameObject);
        }
    }
    
}
