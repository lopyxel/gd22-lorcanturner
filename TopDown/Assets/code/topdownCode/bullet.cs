﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class bullet : MonoBehaviour
{
    
    public static int kills = 0;
    public static float  maxKills;
    public GameObject pred;
    void update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("preditor"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            kills = kills + 1;
       
               

        }

        if(collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            kills += 1;
            Instantiate(pred, gameObject.transform.position, gameObject.transform.rotation);
        }
        
        if(collision.gameObject.CompareTag("obticle") || collision.gameObject.CompareTag("key"))
        {
            Destroy(gameObject);
            soundFX.playSound("impact");
            
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            health.playerLives -= 1;
            Destroy(gameObject);
           //animation for bullet will be added
            if(health.playerLives < 1)
            {
                Destroy(collision.gameObject);
            }

        }

        if(collision.gameObject.CompareTag("time"))
        {
            Destroy(gameObject);
        }


        if (collision.gameObject.CompareTag("spinner"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            kills += 1;
        }


    }
}
