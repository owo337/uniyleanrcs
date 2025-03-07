using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Npuwwdwdw : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform ta;


    public void Start()
    {
        ta = GameObject.FindGameObjectWithTag("w").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        var loc = transform.position.x;
        var loc2 = transform.position.y;

        if (loc < -10)
        {
            transform.position = new Vector3(10, Random.Range(-2, 3.6f), 0);


        }

        transform.position += new Vector3(-12 * Time.deltaTime, 0, 0);

        if (loc2 <= -3)
        {
            transform.position = new Vector3(10, Random.Range(-2, 3.6f), 0);
        }
        //if (Vector2.Distance(transform.position, transform.position) == 0)//¥i¤£¥Î
        //{
        transform.position = Vector2.MoveTowards(transform.position, ta.position, 2.5f * Time.deltaTime);


        //}
        transform.up = ta.transform.position - transform.position;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            transform.position = new Vector3(10, Random.Range(-2, 3.6f), 0);

        }

    }
}
