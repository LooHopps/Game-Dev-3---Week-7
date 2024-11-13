using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;
        [SerializeField] Globaldata globaldata;
        public void UpdateScoreText()
        {
            if (globaldata != null)
            {
                scoreText.text = $"<b>Score</b>:{globaldata.Score}";
            }
            else
            {
                Debug.Log("No Global Data SO assigned to the UIManager");
            }
        }
    }
}
