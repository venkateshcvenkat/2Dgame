using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public float speed = 6f;
    bool iscollid = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && iscollid==false)
        {
            soundeffect.instance.eggcollect();
            uimanager.instance.updatescore();
            iscollid = true;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "ground" && iscollid == false)
        {
            soundeffect.instance.eggcrack();
            iscollid = true;
            Destroy(gameObject);
            uimanager.instance.updatelife();
        }
    }
}
