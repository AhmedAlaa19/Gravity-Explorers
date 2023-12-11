using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRoad : MonoBehaviour
{   
    public GenerateLevel level;
    private void OnTriggerEnter()
    {
        level.DestroyRoad();
    }
}
