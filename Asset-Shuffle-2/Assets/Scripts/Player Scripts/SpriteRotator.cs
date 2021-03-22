using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Visual Component; Allows for rotation of a sprite
/// </summary>
public class SpriteRotator : MonoBehaviour
{
    public static readonly float HALF_ROTATION = 180f;
    public static readonly float FULL_ROTATION = 360f;

    /// Rotates a transform either to a specific angle or by a relative amount
    public float Rotate(Transform obj, float currentAngle, float targetAngle, bool relative = false)
    {
        // Normalize the given angles
        currentAngle = NormalizeAngle(currentAngle);
        targetAngle = NormalizeAngle(targetAngle);
        // Determine the amount to rotate by
        float rotationAmount = relative ? targetAngle : (targetAngle - currentAngle);
        obj.Rotate(Vector3.forward, rotationAmount);
        // Return the resulting angle
        if (relative)
            targetAngle += currentAngle;
        return targetAngle;
    }

    /// Simplies an angle to a normalized range
    private float NormalizeAngle(float angle)
    {
        angle = angle % FULL_ROTATION;
        if (angle > HALF_ROTATION)
            angle -= FULL_ROTATION;
        else if (angle < -HALF_ROTATION)
            angle += FULL_ROTATION; 
        return angle;
    }
}
