using GameDevWithMarco.Managers;
using GameDevWithMarco.ObserverPattern;
using GameDevWithMarco.RandomStuff;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class CollectCoinsOnEnter : MonoBehaviour
    {
        [SerializeField] GameEvent coinCollected;
        [SerializeField] Globaldata globaldata;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                int coinValue = collision.GetComponent<Coins>().CoinValue;
                if (globaldata != null)
                {
                    globaldata.AddToScore(coinValue);
                }
                else
                {
                    Debug.LogWarning("No Global Data SO assigned to CollecteCoinOnTriggerEnter Script ");
                }
                Destroy(collision.gameObject);
                coinCollected.Raise();
            }
        }
    }
}
