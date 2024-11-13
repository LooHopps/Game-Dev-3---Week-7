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
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                int coinValue = collision.GetComponent<Coins>().CoinValue;
                GameManager.Instance.AddToScore(coinValue);
                Destroy(collision.gameObject);
                coinCollected.Raise();
            }
        }
    }
}
