using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zpos = 100;
    public bool creatingSection = false;
    public int secNum;
    public List<GameObject> loadedRoads = new List<GameObject>();   
    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }

    
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        GameObject road =Instantiate(section[secNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 100;
        loadedRoads.Add(road);
        yield return new WaitForSeconds(2);
        creatingSection = false;
     
    }


    public  void DestroyRoad()
    {
        Destroy(loadedRoads[0]);
        loadedRoads.RemoveAt(0);
    }
}
