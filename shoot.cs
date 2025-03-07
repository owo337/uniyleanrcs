using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.Subsystems;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bullet;
    public GameObject bulletPrefab;
    

    void Start()
    {
        
    }

    public float timer = 0f;
    

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Space))
        {

            Instantiate(bulletPrefab, bullet.position, bullet.rotation);

        }

    }
    
    
       
    
}
