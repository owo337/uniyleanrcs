using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("s", 4, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void s()
    {
        Destroy(this.gameObject);
    }
}
