﻿using Gamgaroo.MVVM.Runtime.Extensions;
using Gamgaroo.Reactive.Runtime;
using Gamgaroo.Reactive.Runtime.Abstractions;
using Gamgaroo.View.Runtime.Views.Primitives;
using UnityEngine;

namespace Gamgaroo.Samples
{
    /// <summary>
    ///     This is a View binding sample. After the View is bound to the Reactive Property,
    ///     it will update automatically when the Property value is updated.
    /// </summary>
    public sealed class TestBehaviour : MonoBehaviour
    {
        private readonly IReactiveProperty<float> _input = new ReactiveProperty<float>();

        private void Start()
        {
            // Bind the View to the Property
            GetComponent<TextView>().Bind(_input);
        }

        private void Update()
        {
            // Update the Property value
            _input.Value += Time.deltaTime;
        }
    }
}