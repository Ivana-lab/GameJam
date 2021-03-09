using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disoBall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            pl.getDiscoBall();
            gameObject.SetActive(false);
        }
    }
}
