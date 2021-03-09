using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGod : MonoBehaviour
{
    public GameObject appleAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            if (pl.hasApple())
            {
                if (pl.hasApple())
                {
                    appleAnim.SetActive(true);
                    Invoke("AppleAnimation", 1f);
                }
            }
        }
    }

    public void AppleAnimation()
    {
        gameObject.SetActive(false);
        appleAnim.SetActive(false);
    }
}
