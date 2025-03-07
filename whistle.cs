using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whistle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        var a = Time.timeScale;
        if (a==0)
        {
            Invoke("p", 3);
        }
    }
    void p()
    {
        this.gameObject.SetActive(true);
    }
}
