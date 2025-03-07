
using UnityEngine;

using UnityEngine.UI;


public class player : MonoBehaviour { 
    public Slider hpa;
    public GameObject smoke;
    public float hightmax = 4.6f;
    public float hightmin = -2f;
    public float speed = 4f * Time.deltaTime;


    public float hpmax = 100f;
   



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(count), 2, 1);
        hpa.value = 1f;
        
        smoke.SetActive(false);
        
        
        
    }

    
    
    

    void Update()
    {
        

        if (Input.GetKeyUp(KeyCode.W))
        {
            this.transform.position += new Vector3(0, speed*Time.timeScale, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 45*Time.timeScale);
            
            
        }
        else if (Input.GetKeyUp(KeyCode.S)) 
            {
                this.transform.position += new Vector3(0, speed * -1*Time.timeScale, 0);
                this.transform.rotation = Quaternion.Euler(0, 0, -45*Time.timeScale);
        }
        
        
        

        if (this.transform.position.y>hightmax)
        {
            this.transform.position = new Vector3(-8, hightmax, -5);
        }
        if (this.transform.position.y <hightmin)
        {
            this.transform.position = new Vector3(-8, hightmin, -5);
        }
        if (hpa.value <=0)
        {
            Invoke("aw", 0.1f);
        }
        if (hpa.value <= 0.46f)
        {
            smoke.SetActive(true);
        }
        else
        {
            smoke.SetActive(false); //owo
        }
        if (Time.timeScale == 0)
        {
            this.transform.position = new Vector3(-8, 0, -5);
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //lqx0526
            

        

        



    }
    void count()
{
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "apt")
            {

                hpa.value -= 0.08f;
               
            }

        }
    }
    private void aw()
    {
        Time.timeScale = 0;
    }


}
