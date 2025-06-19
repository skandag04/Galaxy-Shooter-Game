using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    //speed variable at 8
    private float _speed = 10.0f;
    
    // Update is called once per frame
    void Update()
    {
        //translate laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        
        if(transform.position.y > 8.0f)
        {
            Destroy(this.gameObject);
        }
        
    }
}
