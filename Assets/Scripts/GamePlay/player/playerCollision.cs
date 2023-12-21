using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement Movement;
    public forwardMovement ForwardMovement;
    public Animator animator;
    public AudioSource collision;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
            // DisableMovement();
            //  Disable_Platform_Movement();
            // Play_Collided_Animation();
            animator.SetBool("HasCollided", true);
            ForwardMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            collision.Play();
        }
    }

    void DisableMovement()
    {
        Movement.enabled = false;
    }
    void Disable_Platform_Movement()
    {
        ForwardMovement.enabled = false;
    }
    void Play_Collided_Animation()
    {
        animator.SetBool("HasCollided", true);
    }

}
