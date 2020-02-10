using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum NumberOfPlayer{One = 1,Two = 2,Three = 3,Four = 4};
    public NumberOfPlayer numP; 
    public GameObject player;
    public Transform spawnPosition1;
    public Transform spawnPosition2;
    public Transform spawnPosition3;
    public Transform spawnPosition4;
    // Start is called before the first frame update
    void Start()
    {
        switch((int)numP)
        {
            default:
            break;
            case 1:
            createPlayer1();
            break;

            case 2:
            createPlayer1();
            createPlayer2();
            break;

            case 3:

            break;

            case 4:

            break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void createPlayer1(){
        GameObject player1 = Instantiate(player,spawnPosition1.position,Quaternion.identity);
        player1.name = "player1";
        player1.GetComponent<PlayerData>().playerNumber = 1;
        player1.GetComponent<PlayerData>().playerControlMethod = "keyboard1";

    }
    void createPlayer2(){
        GameObject player2 = Instantiate(player,spawnPosition2.position,Quaternion.identity);
        player2.name = "player2";
        player2.GetComponent<PlayerData>().playerNumber = 2;
        player2.GetComponent<PlayerData>().playerControlMethod = "keyboard2";

    }
    void createPlayer3(){
        GameObject player3 = Instantiate(player,spawnPosition3.position,Quaternion.identity);
        player3.name = "player3";
        player3.GetComponent<PlayerData>().playerNumber = 3;
        player3.GetComponent<PlayerData>().playerControlMethod = "keyboard1";

    }
    void createPlayer4(){
        GameObject player4 = Instantiate(player,spawnPosition4.position,Quaternion.identity);
        player4.name = "player4";
        player4.GetComponent<PlayerData>().playerNumber = 4;
        player4.GetComponent<PlayerData>().playerControlMethod = "keyboard1";

    }
}
