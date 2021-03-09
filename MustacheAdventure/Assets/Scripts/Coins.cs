using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coinAnim;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null) 
        {
            pl.addCoin();
            coinAnim.SetActive(true);
            gameObject.SetActive(false);
            Invoke("coinAnimation", 1f);
        }
    }

    public void coinAnimation()
    {
        coinAnim.SetActive(false);
    }
}
