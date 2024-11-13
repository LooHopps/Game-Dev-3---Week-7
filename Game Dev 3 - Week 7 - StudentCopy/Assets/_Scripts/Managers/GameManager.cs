using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;

namespace GameDevWithMarco
{
    public class GameManager : Singleton<GameManager>
    {
        private int score;
        public int Score
        {
            get
            {
                return score;
            }
        }

        public void AddToScore(int numberToAdd)
        {
            score += numberToAdd;
            Debug.Log($"The Current Score is {score}");
        }
    }
}
