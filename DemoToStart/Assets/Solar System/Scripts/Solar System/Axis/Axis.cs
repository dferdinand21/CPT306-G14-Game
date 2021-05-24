using System;
using UnityEngine;

namespace SolarSystem
{
    [Serializable]
    public class Axis
    {
        [Range(0.0f, 90.0f)]
        public float Angle = default;

        [Range(0.0f, 5.0f)]
        public float Diameter = default;

        public EPlane Plane;
        public bool IsFreeAngle = false;

        public Axis(float angle, float diameter, EPlane plane)
        {
            Angle = angle;
            Diameter = diameter;
            Plane = plane;
        }

        public Vector2 Evaluate()
        {
            var x = 0.0f;
            var y = 0.0f;

            if (IsFreeAngle)
            {
                x = Mathf.Sin(Mathf.Deg2Rad * (90 - Angle)) * Diameter;
                y = Mathf.Cos(Mathf.Deg2Rad * (90 - Angle)) * Diameter;
            }
            else
            {
                x = Mathf.Sin(Mathf.Deg2Rad * 90) * Diameter;
                y = Mathf.Cos(Mathf.Deg2Rad * 90) * Diameter;
            }

            return new Vector2(x, y);
        }
    }
}