using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            this.gameObject.SetActive(true);
        }
    }
}
