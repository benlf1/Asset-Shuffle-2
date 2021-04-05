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
    private float shootTime;
    public float shootCooldown;

    public GameObject bullet;

    #region Update
    // Iterate each frame to check for player input
    void Update()
    {
        // Check for any play input
        GetInput();
        Shoot();

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

    private void Shoot()
    {
        if (Input.GetButton("Fire1") && Time.time >= shootTime)
        {
            GameObject b = Instantiate(bullet, transform.position + transform.forward * 1, transform.rotation);
            shootTime = Time.time + shootCooldown;
        }
    }
    #endregion
}
