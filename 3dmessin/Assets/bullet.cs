﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public void onCollisionEnter(Collision  collision )
    {
        Debug.Log("collision");
        if(collision.gameObject.CompareTag("obstical"))
        {
            Destroy(gameObject);
        }
    }
}
