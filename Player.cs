using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void onCollisionEnter(Collision collision)
    {
        print("onCollision");
    }

    private void onTriggerEnter(Collider other)
    {
       print("Secret Number = " + MySingleton.secretNumber);
       
        MySingleton.secretNumber = 5;
        
        EditorSceneManager.LoadScene("Scene 2");
    }
    
    private void onTriggerExit(Collider other)
    {
        print("onTriggerExit");
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
