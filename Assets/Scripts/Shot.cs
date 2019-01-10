using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public float speed = 5f;

    void Awake()
    {
        
        
        
    }

    void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        Destroy(this.gameObject, 2);
    }
}
