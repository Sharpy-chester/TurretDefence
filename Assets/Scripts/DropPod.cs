using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Square")
        {
            //spawn enemies
        }
        else if (col.gameObject.name == "Shot(Clone)")
        {
            Destroy(col.gameObject);
            //might want to remove heatlh instead of just destroying the pod at some point
            Destroy(this.gameObject);
        }
    }
}
