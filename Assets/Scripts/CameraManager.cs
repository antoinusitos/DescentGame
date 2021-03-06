﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private float _speed = 5.0f;
    private float _rotationSpeed = 100.0f;

    private bool _rotate = false;

    private Vector2 _lastMousePos = Vector3.zero;

	void Update ()
    {
        if(Input.GetMouseButtonDown(1))
        {
            _rotate = true;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            _rotate = false;
        }

        if(_rotate)
        {
            Vector3 newPos = Input.mousePosition;

            // @Upgrade : Add a pitch move

            /*if(newPos.y > _lastMousePos.y)
            {
                transform.Rotate(-Vector3.right, Time.deltaTime * _rotationSpeed);
            }
            else if(newPos.y < _lastMousePos.y)
            {
                transform.Rotate(Vector3.right, Time.deltaTime * _rotationSpeed);
            }*/

            if (newPos.x > _lastMousePos.x)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * _rotationSpeed);
            }
            else if (newPos.x < _lastMousePos.x)
            {
                transform.Rotate(-Vector3.up, Time.deltaTime * _rotationSpeed);
            }


            _lastMousePos = newPos;
        }
    }
}
