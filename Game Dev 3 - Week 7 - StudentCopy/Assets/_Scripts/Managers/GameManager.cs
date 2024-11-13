using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Data;

namespace GameDevWithMarco.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Globaldata globaldata;
        private void Start()
        {
            if (globaldata != null)
            {
                Globaldata.ResetsScore();
                Globaldata.SetTheScoreRequiredToWin();
            }
            else
            {
                Debug.LogWarning("The Global Data SO has not been assigned to the Game Manager");
            }
        }


        public void GameWon()
        {
            Time.timeScale = 0;
            Debug.Log("GAME WON");
        }
    }
}
