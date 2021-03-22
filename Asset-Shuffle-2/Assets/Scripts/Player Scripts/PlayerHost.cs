using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Host Component; Hosts and connects all related player components
/// </summary>
public class PlayerHost : MonoBehaviour
{
    [Header("Player Components")]
    public SpriteManager spriteManager;

    // Rotate to face a direction
    public void Face(Vector3 direction)
    {
        spriteManager.RotateBody(direction);
    }
}
