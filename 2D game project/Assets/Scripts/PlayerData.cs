using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int playerNumber;
    public string playerControlMethod;
    public movementController movC;

    // Start is called before the first frame update
    void Start()
    {
        movC = this.gameObject.GetComponent<movementController>();
        movC.playerNumber = playerNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
