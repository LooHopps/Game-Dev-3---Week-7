using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;
        public void UpdateScoreText()
        {
            scoreText.text = $"< b > score </ b >:{GameManager.Instance.Score}";
        }
    }
}
