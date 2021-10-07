using UnityEngine;

namespace snake.Snake
{
    public class InputManager : MonoBehaviour
    {
        private Camera _mainCamera;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        public bool GetPointerDown()
        {
            return Input.GetMouseButton(0);
        }

        public float GetPointerPosition()
        {
            return Input.mousePosition.x / _mainCamera.pixelWidth * 1.2f;
        }
    }
}
