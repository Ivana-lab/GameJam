using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject appleAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();

        if (pl != null)
        {
            pl.setApple();
            appleAnim.SetActive(true);
            Invoke("AppleAnim", 2f);
        }
    }

    public void AppleAnim()
    {
        appleAnim.SetActive(false);
        gameObject.SetActive(false);
    }
}
