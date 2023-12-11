using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }

}