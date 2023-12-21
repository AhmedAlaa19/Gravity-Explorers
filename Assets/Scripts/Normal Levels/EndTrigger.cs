using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource WarpSound;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameManager.CompleteLevel();
            WarpSound.Play();
            
        }

    }
}
