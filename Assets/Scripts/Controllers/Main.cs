﻿using UnityEngine;
using System.Collections.Generic;
using unity3dexperience.Controller; // Подключаем пространство имен, в котором находятся контроллеры
using unity3dexperience.Helper;     // Подключаем пространство имен, в котором находятся хэлперы

namespace unity3dexperience
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
    public sealed class Main : MonoBehaviour
    {
        private GameObject _controllersGameObject;
        private InputController _inputController;
        private FlashlightController _flashlightController;
        private static Main _instance;
        void Start()
        {
            _instance = this;
            _controllersGameObject = new GameObject { name = "Controllers" };
            _inputController = _controllersGameObject.AddComponent<InputController>();
            _flashlightController = _controllersGameObject.AddComponent<FlashlightController>();
        }
        #region Property      
        /// <summary>
        /// Получить контроллер фонарика
        /// </summary>
        public FlashlightController GetFlashlightController
        {
            get { return _flashlightController; }
        }
        /// <summary>
        /// Получить контроллер ввода данных
        /// </summary>
        /// <returns></returns>
        public InputController GetInputController()
        {
            return _inputController;
        }
        #endregion
    }
}
