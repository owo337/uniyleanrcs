using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 4*Time.deltaTime, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 45);


        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            this.transform.position += new Vector3(0, 4 * -1*Time.deltaTime, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, -45);
        }
        if (this.transform.position.y > 4.6)
        {
            this.transform.position = new Vector3(-8, 4.6f, -5);
        }
        if (this.transform.position.y < -2)
        {
            this.transform.position = new Vector3(-8, -2, -5);
        }
    }
}
