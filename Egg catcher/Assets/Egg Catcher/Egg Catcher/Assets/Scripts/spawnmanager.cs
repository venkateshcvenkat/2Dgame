using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject egg;
    void Start()
    {
        StartCoroutine(spawnegg());
    }

    
    void Update()
    {
        
    }
    IEnumerator spawnegg()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Vector2 pos = new Vector2(Random.Range(-6.0f, 6.0f), 6f);
            Instantiate(egg, pos, Quaternion.identity);
        }
    }
}
