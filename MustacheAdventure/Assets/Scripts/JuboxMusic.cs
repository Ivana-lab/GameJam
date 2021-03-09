using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuboxMusic : MonoBehaviour
{
    public GameObject mirror;
    public GameObject anim;
    public GameObject discoBall;

    public bool isActive = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null) 
        {
            if (pl.hasDicsoBall() && pl.hasCoins())
            {
                pl.givesItem();
                mirror.SetActive(true);
                anim.SetActive(true);
                Invoke("JuboxAnimation", 1f);
                discoBall.SetActive(true);
                JuboxSetActiv();
            }
        }
            
    }

    public void JuboxAnimation()
    {
        anim.SetActive(false);
    }

    public void JuboxSetActiv()
    {
        isActive = true;
    }

    public bool JuboxIsActive()
    {
        return isActive;
    }
}
