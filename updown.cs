using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(count), 2, 1);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > 3.4f)
        {
            this.transform.position = new Vector3(-8, 3.4f, -5);
        }
        if (this.transform.position.y < -1)
        {
            this.transform.position = new Vector3(-8, -1, -5);
        }
    }
    public void uu()
    {
        this.transform.position += new Vector3(0, 2* Time.timeScale, 0);
        this.transform.rotation = Quaternion.Euler(0, 0, 45 * Time.timeScale);
        
    }
    public void dd()
    {
        this.transform.position -= new Vector3(0, 1 * Time.timeScale, 0);
        this.transform.rotation = Quaternion.Euler(0, 0, -45 * Time.timeScale);
    }
    void count()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
