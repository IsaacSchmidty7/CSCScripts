using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2Controller : MonoBehaviour
{
    private PlayerClass thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGO;
    // Start is called before the first frame update
    void Start()
    {
        this.thePlayer = new PlayerClass("Dave");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
        this.gameObject.transform.position = this.destinationGO.transform.position;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.thePlayer.display();
    }
}
