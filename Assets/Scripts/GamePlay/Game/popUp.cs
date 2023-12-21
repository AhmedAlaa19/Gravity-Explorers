using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class popUp : MonoBehaviour
{

    public TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            textMeshPro.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            textMeshPro.enabled = false;
        }
    }
}
