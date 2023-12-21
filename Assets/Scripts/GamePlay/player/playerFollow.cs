 using UnityEngine;

public class playerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Cam_To_Player();
    }

    void Cam_To_Player()
    {
        transform.position = player.position + Offset;
    }
}
