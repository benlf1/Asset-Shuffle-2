using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Abstract Class; Controls and manages movement of a Movement object
/// </summary>
public class Controller : MonoBehaviour
{
    #region Variables
    //[Header("Components")]
    //[SerializeField] protected Movement movement;

    protected static readonly string HRZ = "Horizontal";
    protected static readonly string VRT = "Vertical";
    #endregion

    protected virtual void GetInput() { }
}
