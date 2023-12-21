using UnityEngine;


public class forwardMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Transform playerTransform;

    void Start()
    {
        // Assuming the player has a "Player" tag; adjust this if needed
        Find_Player();
    }

    void Update()
    {
        Move_Platform();
    }

    void Find_Player() 
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player not found. Make sure the player has the 'Player' tag.");
        }
    }

    void Move_Platform() 
    {
        if (playerTransform != null)
        {
            // Move the track towards the player along the z-axis
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
    }

}

