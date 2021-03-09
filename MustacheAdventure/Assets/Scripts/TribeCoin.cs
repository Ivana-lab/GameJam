using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TribeCoin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        PlayerMove pll = collision.gameObject.GetComponent<PlayerMove>();

        if (pll != null)
        {
            if (pll.has3Coins())
            {
                pll.giveCoin();
                gameObject.SetActive(false);
            }
        }

    }
}
