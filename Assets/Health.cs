using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public Slider playerSlider3D;
    Slider playerSlider2D;
    public int health;
    public GameObject gameover;
    void Start()
    {
        playerSlider2D = GetComponent<Slider>();
        playerSlider2D.maxValue = health;
        playerSlider3D.maxValue = health;
        gameover.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        playerSlider2D.value = health;
        playerSlider3D.value = playerSlider2D.value;

        if (Input.GetKey(KeyCode.E))
        {
            health -= 1;
        }
        if(health <= 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void damage()
    {
        health -= 1;
    }
    }
