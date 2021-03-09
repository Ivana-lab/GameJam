using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlDance : MonoBehaviour
{
    public JuboxMusic jubox;
    public GameObject animationGirl;

    private void Update()
    {
        if (jubox.JuboxIsActive())
        {
            setAnimation();
        }
    }

    void setAnimation()
    {
        animationGirl.SetActive(true);
        gameObject.SetActive(false);
    }
}
