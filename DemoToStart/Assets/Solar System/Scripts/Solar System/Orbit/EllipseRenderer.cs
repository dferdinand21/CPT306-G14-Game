using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolarSystem
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(LineRenderer))]
    public class EllipseRenderer : MonoBehaviour
    {
        private LineRenderer _lineRenderer;

        [Range(3, 360)]
        public int Segments = 360;

        public bool IsPlaneY;

        public Ellipse Ellipse;

        private void Awake()
        {
            _lineRenderer = GetComponent<LineRenderer>();
            _lineRenderer.startWidth = 0.01f;
            _lineRenderer.endWidth = 0.01f;

            CalculateEllipse();
        }

        private void OnValidate()
        {
            if (_lineRenderer != null)
            {
                CalculateEllipse();
            }
        }

        private void CalculateEllipse()
        {
            var points = new Vector3[Segments + 1];

            for (var i = 0; i < Segments; i++)
            {
                var position2D = Ellipse.Evaluate((float) i / (float) Segments);

                if (IsPlaneY)
                {
                    points[i] = new Vector3(position2D.x, position2D.y, 0f);
                }
                else
                {
                    points[i] = new Vector3(position2D.x, 0f, position2D.y);
                }
            }

            points[Segments] = points[0];

            _lineRenderer.positionCount = Segments + 1;
            _lineRenderer.SetPositions(points);
        }
    }
}