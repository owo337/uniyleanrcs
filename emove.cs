using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class emove : MonoBehaviour
{
    // Start is called before the first frame update
     
    public float  score = 0f;
    public TMP_Text pla;
    public TMP_Text End;
    public AudioSource s;
    public GameObject smoke;
    public GameObject r;
    Boolean play = true;
    public Slider a;
    void Start()
    {
        
      
        s.Stop();
    }
    float x = 0f;

    // Update is called once per frame
    
    void Update()
    {
        x = UnityEngine.Random.Range(10, 40);
        transform.Translate(-x*Time.deltaTime, 0, 0);
        
        if (this.transform.position.x<=-10)
        {
            this.transform.position = new Vector3(10, -5.29f, -3);
            
        }
        pla.text = score.ToString()+":" +"Killed" ;
        //score -= Time.deltaTime * 0.5f;
        if (Time.timeScale == 0)
        {
            
            End.text = "THE Gamer over";
            r.SetActive(true);
            Invoke("p", 0);
            
            
        }
        else
        {
            End.text = "";
        }
        
        //if (score > 80)
        //{
            //Time.timeScale = 4;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{

            //score = score - 4;

        //}
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="owo")
        {
            score = 1+score;
            print("pwp");
            a.value += 0.01f*3;
            Instantiate(smoke, this.transform.position, this.transform.rotation);

        }
        Destroy(collision.gameObject);
        
        
        
    }
    void p()
    {
        if (play)
        {
            //s.Play();
            play = false;
            Time.timeScale = 0;
        }
    }

}
