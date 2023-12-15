using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement Movement;
    public forwardMovement ForwardMovement;
    public Animator animator;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            
            Movement.enabled = false;
            ForwardMovement.enabled = false;
            animator.SetBool("HasCollided", true);

            FindObjectOfType<GameManager>().EndGame();
             
        }
    }
}
