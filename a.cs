using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale > 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset()
    {
      
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        
    }
}
