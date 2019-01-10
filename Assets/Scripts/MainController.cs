using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public float maxTimer = 10f;
    float timer = 0f;
    int rand1 = 0;
    int rand2 = 0;
    public GameObject dropPod;
    public GameObject podSpawnPoint;

    void Awake()
    {
        timer = maxTimer;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > maxTimer)
        {
            int rand1 = Random.Range(3, 9);
            int rand2 = Random.Range(0, 2); //There has to be a better way to do this
            if (rand2 == 0)
            {
                podSpawnPoint.transform.position = new Vector3(rand1, 6, 0);
                GameObject pod = Instantiate(dropPod, podSpawnPoint.transform);
                pod.transform.SetParent(null);
            }
            else
            {
                podSpawnPoint.transform.position = new Vector3(-rand1, 6, 0);
                GameObject pod = Instantiate(dropPod, podSpawnPoint.transform);
                pod.transform.SetParent(null);
            }
            timer = 0;
        }
    }
}
