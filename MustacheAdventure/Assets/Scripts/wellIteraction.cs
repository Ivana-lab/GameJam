using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wellIteraction : MonoBehaviour
{
    public GameObject wellAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            pl.setFullCan();
            wellAnim.SetActive(true);
            Invoke("WellAnimation", 1f);
        }
    }

    public void WellAnimation()
    {
        wellAnim.SetActive(false);
    }
}
