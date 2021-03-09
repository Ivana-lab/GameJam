using UnityEngine;

public class TreeIteraction : MonoBehaviour
{
    public GameObject appleItem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            if (pl.hasFullCan())
            {
                appleItem.SetActive(true);
                pl.setEmptyCan();
            }
        }
    }

}
