using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Player");
        Debug.Log(gameObject);
        //transform.position is the position of the gameobjec that holds the script 
        //gameobject.transform.position is the gameobject of our player 
        //this gives the total of the direction 

        if (gameObject != null)
        {
            Vector2 playerPos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPos * speed;
        }
 
    }

  
   
}
