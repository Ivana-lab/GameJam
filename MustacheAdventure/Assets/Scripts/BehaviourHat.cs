using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourHat : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            pl.setHat();
            gameObject.SetActive(false);
        }
    }
}
