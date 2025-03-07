using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class a1 : MonoBehaviour
{
    public Color c;

    // Start is called before the first frame update
    void Start()
    {
        
       this.gameObject.SetActive(false);
        c = GetComponent<Renderer>().material.color;
        
    }

    // Update is called once per frame
    void Update()
    {
        var s = Time.timeScale;
        if (s == 0)
        {
            this.gameObject.SetActive(true);
        }

    }
    public void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.blue;

    }
    public void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = c;

    }
}
