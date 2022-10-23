using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossManager : MonoBehaviour
{
    [SerializeField]
    Slider timeDisplay;
    [SerializeField]
    float maxTime;
    float currentTimer;
        [SerializeField]
    GameObject winmsg;
    [SerializeField]
    Image img;
    [SerializeField]
    Sprite[] jeffStates;
       [SerializeField]
    GameObject[] spawners;


    // Start is called before the first frame update
    void Start()
    {
        currentTimer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;
        timeDisplay.value = currentTimer;
        if(currentTimer <= 0)
        {
            winmsg.SetActive(true);
        } 
        if(currentTimer <= -2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
         if(currentTimer < maxTime / 4)
        {
            img.sprite = jeffStates[2];
                      spawners[1].SetActive(true);
        } else
        if(currentTimer < maxTime / 2)
        {
            img.sprite = jeffStates[1];
            spawners[0].SetActive(true);
        } else
        {
            img.sprite = jeffStates[0];
        }
    }
}
