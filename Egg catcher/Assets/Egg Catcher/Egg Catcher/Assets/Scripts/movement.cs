using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed1,speed2;
    public Transform playerTrs;
    void Start()
    {
     
       

    }

   
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate (new Vector2(input, 0f)*speed1*Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.7f, 7.7f),transform.position.y);
    }
    public void left()
    {
        
        playerTrs.transform.Translate( Vector2.left * speed2 * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y);
    }
    public void right()
    {

        playerTrs.transform.Translate( Vector2.right * speed2 * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y);
    }
}
