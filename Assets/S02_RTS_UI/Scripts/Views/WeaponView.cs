﻿using Gamgaroo.Samples.S02_RTS_UI.Scripts.Gears;
using Gamgaroo.View.Runtime.Abstractions;
using Gamgaroo.View.Runtime.Views.Primitives;
using UnityEngine;

namespace Gamgaroo.Samples.S02_RTS_UI.Scripts.Views
{
    public sealed class WeaponView : MonoBehaviour, IView<Weapon>
    {
        [SerializeField]
        private ImageView _icon;

        [SerializeField]
        private TextView _title;

        public void Set(Weapon viewModel)
        {
            _icon.sprite = viewModel.Icon;
            _title.text = viewModel.Title;
        }
    }
}