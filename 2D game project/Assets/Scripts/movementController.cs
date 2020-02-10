using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    private Rigidbody2D myRig;
    public int playerNumber;
    public float walkSpeed = 5;
    private Vector3 lookingAt;
    private bool weponAviable = true;
    Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed.x = Input.GetAxisRaw("Horizontal" + playerNumber);
        speed.y = Input.GetAxisRaw("Vertical"+ playerNumber);
        if(Input.GetButton("Fire") && weponAviable == true){
            useWeapon();
        }
        if(speed != Vector3.zero){
            movePlayer();
        }
        else{

            speed = new Vector3(0,0,0);
            movePlayer();
        }
  
    }

    void movePlayer(){
 
        transform.position = transform.position + speed * walkSpeed * Time.deltaTime;
    }
  
    void useWeapon(){
        Collider2D[] hits2 = Physics2D.OverlapBoxAll(transform.GetChild(0).position, GetComponentInChildren<BoxCollider2D>().size, 0);
        foreach (Collider2D hit in hits2)
        {
            if (hit == this.GetComponent<BoxCollider2D>())
                continue;

            if(hit.gameObject.tag == "Player"){
                GetComponent<Rigidbody2D>().AddForce(new Vector3(1,0,0)*100);
                StartCoroutine("MoveToSpot",hit.gameObject);
              

            }
        
        }

    }
    IEnumerator MoveToSpot(GameObject thingi){
        weponAviable = false;
        StartCoroutine("cooldown");

        float elapsedTime = 0;
        float waitTime = 0.5f;
        Vector3 newposition = thingi.transform.position + new Vector3(1,0,0);
        while (elapsedTime < waitTime)
        {
            thingi.transform.position = Vector3.MoveTowards(thingi.transform.position, newposition, (elapsedTime / waitTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }  
        
    }
      IEnumerator cooldown(){
      
        yield return new WaitForSeconds(5);

        weponAviable = true;
       
       
    }
    
   
}
