using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




    }
    public void up()
    {
        this.transform.position += new Vector3(0, 1 * Time.timeScale, 0);
        this.transform.rotation = Quaternion.Euler(0, 0, 45 * Time.timeScale);

    }
}
