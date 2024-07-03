using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Camera _camera;
    [SerializeField] private Joystick _joystick;

    private Vector3 _origCameraPos;

    private void Start()
    {
        _origCameraPos = _camera.transform.position;
    }
    private void Update()
    {
        _camera.transform.position = _origCameraPos + new Vector3(_rigidbody.transform.position.x, 0, _rigidbody.transform.position.z);

        if(_joystick.gameObject.activeInHierarchy)
            _rigidbody.velocity += new Vector3(_joystick.Direction.normalized.x, 0, _joystick.Direction.normalized.y) * 0.05f;

    }
}
