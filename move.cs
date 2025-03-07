using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float timer = 0.1f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
    
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(0.5f * Time.deltaTime * 6, 0, 0);
        
        
        
      
       
        
       
        

             
    }
   

}
