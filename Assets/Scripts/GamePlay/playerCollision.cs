using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement Movement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
             
        }
    }
}
