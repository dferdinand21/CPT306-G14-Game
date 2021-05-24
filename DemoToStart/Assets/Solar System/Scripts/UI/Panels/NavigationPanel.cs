using System;
using System.Collections.Generic;
using UnityEngine;

namespace SolarSystem
{
    public class NavigationPanel : MonoBehaviour
    {
        #region FIELDS

        [SerializeField]
        private GameObject _planetElmnt = default;

        public event Action<EPlanet> OnClick;

        #endregion

        #region PUBLIC_METHODS

        public void Setup(List<PlanetModel> data)
        {
            foreach (var model in data)
            {
                var go = (GameObject) Instantiate(_planetElmnt, transform, false);
                go.name = model.Name;
                var elmnt = go.GetComponent<PlanetElmnt>();
                elmnt.Setup((EPlanet) model.Planet, model.Name);
                elmnt.OnClick += OnElmnt;
            }
        }

        #endregion

        #region PLAYER_EVENTS

        private void OnElmnt(EPlanet planet)
        {
            OnClick?.Invoke(planet);
        }

        #endregion
    }
}