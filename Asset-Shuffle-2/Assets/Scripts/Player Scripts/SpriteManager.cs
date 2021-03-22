using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Manager Component; Manages sprite-related components to an object in the scene
/// </summary>
public class SpriteManager : MonoBehaviour
{
    [Header("Sprite Components")]
    public Transform playerTransform;
    public SpriteRotator rotator;

    private float currentRotation;

    /// Rotates the main body to a given angle
    public void RotateBody(float rotation)
    {
        currentRotation = rotator.Rotate(playerTransform, currentRotation, rotation, false);
    }

    /// Rotates the main body to a given vector direction
    public void RotateBody(Vector3 direction)
    {
        // Vector3.Angle returns unsigned angle; Use Mathf.Sign to get correct sign
        float rotation = Vector3.Angle(Vector3.up, direction) * Mathf.Sign(-direction.x);
        RotateBody(rotation);
    }
}
