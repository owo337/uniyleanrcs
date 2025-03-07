using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Transform shooting;
    public GameObject bomb;
    public float currenTime = 4f;
    float invokTime=0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&Time.time>invokTime)
        {

            invokTime = Time.time + currenTime;
            Instantiate(bomb, shooting.position, shooting.rotation);


        }
        
    }
   
   

}
