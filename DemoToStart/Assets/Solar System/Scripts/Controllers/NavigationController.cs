using System.Collections;
using UnityEngine;

namespace SolarSystem
{
    public class NavigationController : MonoBehaviour
    {
        #region FIELDS

        [SerializeField]
        private NavigationPanel _navigationPanel = default;

        [SerializeField]
        private Transform[] _planets = default;

        [SerializeField]
        private OrbitCamera _orbitCamera = default;

        #endregion

        #region UNITY_METHODS

        private IEnumerator Start()
        {
            yield return StartCoroutine(LocalCore.LoadTextFieldAsync("Data", "Data"));

            Setup();
        }

        #endregion

        #region PRIVATE_METHODS

        private void Setup()
        {
            var data = LocalCore.PlanetModelData;

            _navigationPanel.Setup(data);
            _navigationPanel.OnClick += OnNavigationPanel;
        }

        private void OnNavigationPanel(EPlanet planet)
        {
            Debug.Log(planet);

            switch (planet)
            {
                case EPlanet.Default:
                    _orbitCamera.target = _planets[0];
                    break;
                case EPlanet.Mercury:
                    _orbitCamera.target = _planets[1];
                    break;
                case EPlanet.Venus:
                    _orbitCamera.target = _planets[2];
                    break;
                case EPlanet.Earth:
                    _orbitCamera.target = _planets[3];
                    break;
                case EPlanet.Mars:
                    _orbitCamera.target = _planets[4];
                    break;
                case EPlanet.Jupiter:
                    _orbitCamera.target = _planets[5];
                    break;
                case EPlanet.Saturn:
                    _orbitCamera.target = _planets[6];
                    break;
                case EPlanet.Uranus:
                    _orbitCamera.target = _planets[7];
                    break;
                case EPlanet.Neptune:
                    _orbitCamera.target = _planets[8];
                    break;
                case EPlanet.Pluto:
                    _orbitCamera.target = _planets[9];
                    break;
            }
        }

        #endregion
    }
}