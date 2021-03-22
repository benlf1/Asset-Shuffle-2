using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Game Component; Controls and manages the actions of a Player
/// </summary>
public class PlayerController : Controller
{
    [Header("Player Host Component")]
    public PlayerHost host;

    [SerializeField] private Vector2 currDirection;

    #region Update
    // Iterate each frame to check for player input
    void Update()
    {
        // Check for any play input
        GetInput();

        // Rotate Player to Face towards mouse
        host.Face((Vector3)currDirection);
    }
    #endregion

    #region Input
    // Override the virtual input receiver
    protected override void GetInput()
    {
        GetMousePosition();
    }

    // Converts Mouse Position to a World Position
    private void GetMousePosition()
    {
        Vector2 mousePos = Input.mousePosition; // Returns coordinates in the Screen Coordinate System
        currDirection = Camera.main.ScreenToWorldPoint(mousePos) - transform.position; // Converts from Screen position to World Position relative to the player's position
    }
    #endregion
}
