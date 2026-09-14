using System;
using UnityEngine;

namespace SO
{
    [Serializable]
    [CreateAssetMenu(fileName = "Camera Setting", menuName = "Test Task/Camera setting", order = 1)]
    public class CameraSettings : ScriptableObject
    {
        [SerializeField]
        [Range(1,5)]
        private float _sensitivity = 5;

        public float Sensitivity => _sensitivity;
    }
}