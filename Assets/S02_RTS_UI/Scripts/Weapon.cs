﻿using UnityEngine;
using UnityEngine.Serialization;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObjects/Weapon")]
    public sealed class Weapon : ScriptableObject
    {
        [FormerlySerializedAs("_sprite")]
        [SerializeField]
        private Sprite _icon;

        [SerializeField]
        private string _title;

        public string Title => _title;
        public Sprite Icon => _icon;
    }
}