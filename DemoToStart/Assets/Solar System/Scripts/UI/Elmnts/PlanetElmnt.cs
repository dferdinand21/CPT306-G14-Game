using System;
using UnityEngine;
using UnityEngine.UI;

namespace SolarSystem
{
    public class PlanetElmnt : MonoBehaviour
    {
        #region FIELDS

        [SerializeField]
        private Button _button = default;

        [SerializeField]
        private Text _text = default;

        private EPlanet _type;
        public event Action<EPlanet> OnClick;

        #endregion

        #region UNITY_METHODS

        private void Start()
        {
            _button.onClick.AddListener(() => { OnClick?.Invoke(_type); });
        }

        #endregion

        #region PUBLIC_METHODS
        
        public void Setup(EPlanet type, string namePlanet)
        {
            _type = type;
            _text.text = namePlanet;
        }
        
        #endregion
    }
}