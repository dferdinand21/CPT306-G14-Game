using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolarSystem
{
    [RequireComponent(typeof(LineRenderer))]
    public class AxisController : MonoBehaviour
    {
        #region FIELDS

        [SerializeField]
        private Axis _axis = default;

        [SerializeField]
        private float _axisProgress = 0.0f;

        [SerializeField]
        private float _days = 0.0f;

        [SerializeField]
        private float _periodPlanet = 365.2564f;

        private LineRenderer _lineRenderer;

        #endregion

        #region UNITY_METHODS

        private void Start()
        {
            SetIncline();
            SetAxis();
            StartCoroutine(RotateAsync());
        }

        private void OnValidate()
        {
            SetIncline();
            SetAxis();
        }

        #endregion

        #region PRIVATE_METHODS

        private void SetIncline()
        {
            transform.localRotation = Quaternion.AngleAxis(_axis.Angle, Vector3.right);
        }

        private void SetAxis()
        {
            var points = new Vector3[2];
            var position = _axis.Evaluate();

            switch (_axis.Plane)
            {
                case EPlane.XY:
                    points[0] = new Vector3(position.x, position.y, 0f);

                    break;
                case EPlane.XZ:
                    points[0] = new Vector3(position.x, 0f, position.y);
                    break;
                case EPlane.YZ:
                    points[0] = new Vector3(0f, position.x, position.y);
                    break;
            }

            points[1] = -points[0];

            if (_lineRenderer == null)
            {
                _lineRenderer = GetComponent<LineRenderer>();
            }

            _lineRenderer.startWidth = 0.01f;
            _lineRenderer.endWidth = 0.01f;
            _lineRenderer.useWorldSpace = false;
            _lineRenderer.enabled = true;
            _lineRenderer.positionCount = 2;
            _lineRenderer.SetPositions(points);
        }

        private IEnumerator RotateAsync()
        {
            var orbitSpeed = 1.0f / _periodPlanet;

            while (true)
            {
                _axisProgress += Time.deltaTime * orbitSpeed;
                _axisProgress %= 1.0f;
                _days = _axisProgress * _periodPlanet;
                transform.Rotate(Vector3.down * _axisProgress);
                yield return new WaitForSeconds(orbitSpeed);
            }
        }

        #endregion
    }
}