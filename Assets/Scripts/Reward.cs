using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
   public  int coinValue = 10;

  

private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioCoins.playMusic();
            Gamecontroller.instance.addScore(coinValue);
           
            Destroy(gameObject);
           
        }
    }
}
