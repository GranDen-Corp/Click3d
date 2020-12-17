using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyConfig : MonoBehaviour
{
    private Vector3 _originPosition;
    private Quaternion _originRotation;
    private Vector3 _originScale;
    private Collider _collider;

    // Start is called before the first frame update
    void Start()
    {
        var gameObjTransform = this.transform;
        _originPosition = gameObjTransform.position;
        _originScale = gameObjTransform.localScale;
        _originRotation = gameObjTransform.rotation;

        _collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ResetToInitial()
    {
        var gameObjectTransform = this.transform;
        gameObjectTransform.position = _originPosition;
        gameObjectTransform.localScale = _originScale;
        gameObjectTransform.rotation = _originRotation;
    }

    public void ToggleGravity()
    {
        if (_collider == null)
        {
            return;
        }

        if (_collider.attachedRigidbody.useGravity)
        {
            _collider.attachedRigidbody.useGravity = false;
        }
        else
        {
            _collider.attachedRigidbody.useGravity = true;
        }
    }
}