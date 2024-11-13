using GameDevWithMarco.Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class VFXManager : Singleton<VFXManager>
    {
        public void HitStop(float stopDuration)
        {
            StartCoroutine(HitStopCoroutine(stopDuration));
        }

        IEnumerator HitStopCoroutine(float duration)
        {
            Time.timeScale = 0;
            yield return new WaitForSeconds(duration);
            Time.timeScale = 1;
        }
    }
}
