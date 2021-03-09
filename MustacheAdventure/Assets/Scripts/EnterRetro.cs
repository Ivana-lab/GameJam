using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRetro : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null) 
        {
            if (pl.hasHat() && pl.hasDicsoBall())
            {
                pl.ShowPopUp();
            }
            
        }
    }
}
