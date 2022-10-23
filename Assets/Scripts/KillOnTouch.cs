using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillOnTouch : MonoBehaviour
{
    [SerializeField]
    Transform transformToStickTo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transformToStickTo.position;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        if(other.tag == "Player")
        {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
