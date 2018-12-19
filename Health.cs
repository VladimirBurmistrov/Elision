using UnityEngine;
using UnityEngine.UI;

namespace CoverShooter
{
    [ExecuteInEditMode]
    public class Health : MonoBehaviour
    {
        [Tooltip("Object whose health is displayed on the health bar.")]
        public GameObject Target1;
        public GameObject Target2;
        private GameObject Target;
        [Range(0, 1)]
        [Tooltip("Current value of the health bar.")]
        public float Value = 1.0f;
        [Tooltip("Determines if the health bar is hidden when the target has no health.")]
        public bool HideWhenDead = true;
        [Tooltip("Determines if the health bar is hidden when there is no target.")]
        public bool HideWhenNone = false;
        [Tooltip("Link to the object that draws the health bar.")]
        public Image LoadingImg;

        private GameObject _cachedTarget;
        private CharacterHealth _cachedCharacterHealth;

        private void LateUpdate()
        {
            if (Target1.activeSelf)
            {
                Target = Target1;
            }
            if (Target2.activeSelf)
            {
                Target = Target2;
            }
            if (Target != _cachedTarget)
            {
                _cachedTarget = Target;

                if (Target != null)
                {
                    _cachedCharacterHealth = Target.GetComponent<CharacterHealth>();
                }
                else
                {
                    _cachedCharacterHealth = null;
                }
            }

            if (_cachedCharacterHealth != null)
                Value = _cachedCharacterHealth.Health / _cachedCharacterHealth.MaxHealth;

            var isVisible = true;

            if (Application.isPlaying)
            {
                isVisible = (!HideWhenDead || Value > float.Epsilon) && (!HideWhenNone || Target != null);

                if (LoadingImg != null) LoadingImg.gameObject.SetActive(isVisible);
            }

            if (isVisible)
            {
                if (LoadingImg != null)
                    LoadingImg.fillAmount = Value;
            }
        }
    }
}