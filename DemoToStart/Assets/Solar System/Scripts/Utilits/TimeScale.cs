using UnityEngine;

namespace SolarSystem
{
    public sealed class TimeScale : MonoBehaviour
    {
        #region FIELDS

        [SerializeField]
        private float _timeScale = 1.0f;

        #endregion

        #region UNITY_METHODS

        private void Update()
        {
            Time.timeScale = Mathf.Clamp(_timeScale, 0.0f, 100.0f);
        }

        #endregion
    }
}