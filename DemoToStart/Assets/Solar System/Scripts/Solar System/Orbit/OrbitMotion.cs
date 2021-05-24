using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolarSystem
{
    public class OrbitMotion : MonoBehaviour
    {
        public Transform OrbitObject;
        public Ellipse OrbitPath;

        [Range(0f, 1f)]
        public float OrbitProgress = 0.0f;

        public float OrbitPeriod = 3.0f;
        public bool OrbitActive = true;

        private void Start()
        {
            if (OrbitObject == null)
            {
                OrbitActive = false;
                return;
            }

            SetOrbitingObjectPosition();
            StartCoroutine(AnimateOrbit());
        }

        private void SetOrbitingObjectPosition()
        {
            Vector2 orbitPos = OrbitPath.Evaluate(OrbitProgress);
            OrbitObject.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);
        }

        private IEnumerator AnimateOrbit()
        {
            if (OrbitPeriod < 0.1f)
            {
                OrbitPeriod = 0.1f;
            }

            float orbitSpeed = 1.0f / OrbitPeriod;

            while (OrbitActive)
            {
                OrbitProgress += Time.deltaTime * orbitSpeed;
                OrbitProgress %= 1.0f;
                SetOrbitingObjectPosition();
                yield return null;
            }
        }
    }
}