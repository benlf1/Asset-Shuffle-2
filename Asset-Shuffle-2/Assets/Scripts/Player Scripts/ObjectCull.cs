﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCull : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(transform.parent.gameObject);
    }
}
