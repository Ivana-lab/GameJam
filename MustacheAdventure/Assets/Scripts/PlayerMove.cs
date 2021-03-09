using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 4;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;

    public GameObject popUpWindow;
    public GameObject teleportEffect;
    public GameObject panelNewGame;

            
    // moving LblFix animation (Update method)
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    // coallision lblFIX
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // dies
        EnemyBehaviour pl = collision.gameObject.GetComponent<EnemyBehaviour>();
        if (pl != null)
        {
            gameObject.SetActive(false);
            panelNewGame.SetActive(true);
            Invoke("startOver", 5f);
        }

    }

    public void startOver()
    {
        panelNewGame.SetActive(false);
        SceneManager.LoadScene(0);
    }

    // switch map
    public void ShowPopUp()
    {
        popUpWindow.SetActive(true);
        gameObject.transform.position = new Vector3(-51.99f, 17.02f, 0f);
        gameObject.SetActive(false);
        Invoke("teleport", 2f);
    }

    public void teleport()
    {
        popUpWindow.SetActive(false);
        gameObject.SetActive(true);
    }

    // Item
    // lblFIX make new Script Inventory

    public bool diso = false;
    public bool mirror = false;
    public bool hat = false;
    public bool dynamite = false;
    public int coins = 0;
    public bool apple = false;
    public bool can = false;
    public bool fullCan = false;

    public void setDynamite()
    {
        dynamite = true;
    }

    public bool hasDynamite()
    {
        return dynamite;
    }

    public void getDiscoBall() 
    {
        diso = true;
    }

    public bool hasDicsoBall() 
    {
        return diso;
    }

    public void setHat()
    {
        hat = true;
    }

    public bool hasHat()
    {
        return hat;
    }

    public void addCoin()
    {
        coins++;
    }

    public bool hasCoins()
    {
        if (coins >= 5)
            return true;
        else
            return false;
    }

    public bool has3Coins()
    {
        if (coins >= 5)
            return true;
        else
            return false;
    }

    public void giveCoin()
    {
        coins--;
    }

    public void givesItem()
    {
        mirror = true;
    }

    public bool hasMirror()
    {
        return mirror;
    }

    public void setApple()
    {
        apple = true;
    }
    public bool hasApple()
    {
        return apple;
    }

    public void setCan()
    {
        can = true;
    }

    public void setFullCan()
    {
        if (hasCan())
        {
            fullCan = true;
        }
    }

    public void setEmptyCan()
    {
        fullCan = false;
    }

    public bool hasCan()
    {
        return can;
    }

    public bool hasFullCan()
    {
        return fullCan;
    }

}
