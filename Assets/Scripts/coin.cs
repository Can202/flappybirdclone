using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    float istime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        istime += 1 * Time.deltaTime;
        if (istime >= 4)
        {
            istime = 0;
            Destroy(gameObject);
        }
        gameObject.transform.position += new Vector3(-10 * Time.deltaTime, 0, 0);
    }
}
