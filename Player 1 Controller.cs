using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player1Controller : MonoBehaviour
{
    private PlayerClass thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGO;
    public float speed;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
       // Vector3.MoveTowards
        this.thePlayer = new PlayerClass("Mike");
     
       // this.gameObject.transform.position
       // tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
       // this.gameObject.transform.position = this.destinationGO.transform.position;
       
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.thePlayer.display();
          Player.gameObject.transform.position = Vector3.MoveTowards(Player.gameObject.transform.position, destinationGO.transform.position, speed);
    } 

        
}
