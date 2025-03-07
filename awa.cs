using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class awa : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ta;
    private Rigidbody2D Rb;


    public void Start()
    {
        
        Rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var loc = transform.position.x;
        var loc2 = transform.position.y;
        
        
        if (loc< -10)
        {
            transform.position = new Vector3(10, Random.Range(-2, 3.6f), 0);
            

        }
        missile();
       


        if (loc2 <= -3)
        {
            transform.position = new Vector3(10, Random.Range(-2, 3.6f), 0);
        }
        //if (Vector2.Distance(transform.position, transform.position) == 0)//�i����
        //{
        //transform.position = Vector2.MoveTowards(transform.position, ta.position, 2.5f * Time.deltaTime);


        //}
        //transform.up = ta.transform.position - transform.position;

        //Vector3 t = ta.transform.position - transform.position;
        //transform.position += t * Time.deltaTime*1;
        //transform.LookAt(ta);


        //}


    }
    void missile()
    {
        Vector2 direction = (Vector2)ta.position - Rb.position;
        direction.Normalize();
        float rotaten = Vector3.Cross(direction, transform.up).z;
        Rb.angularVelocity = -rotaten * 100f;
        
        Rb.linearVelocity = transform.up * 10f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            transform.position = new Vector3(10, Random.Range(-2, 3.6f), 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 90);

        }
        
    }
}
