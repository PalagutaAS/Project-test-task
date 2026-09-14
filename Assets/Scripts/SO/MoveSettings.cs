using System;
using UnityEngine;

namespace SO
{
    [Serializable]
    [CreateAssetMenu(fileName = "Move Setting", menuName = "Test Task/Move setting", order = 0)]
    public class MoveSettings : ScriptableObject
    {
        [SerializeField]
        [Range(2,10)]
        private float _speed = 10;

        public float Speed => _speed;
    }
}