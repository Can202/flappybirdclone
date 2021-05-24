using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plus : MonoBehaviour
{

    public GameObject coin;
    float istime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        istime += 1 * Time.deltaTime;
        if (istime >= 2)
        {
            Instantiate(coin, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(-2.8f, 2.8f)), transform.rotation);
            istime = 0;
        }
    }
}
