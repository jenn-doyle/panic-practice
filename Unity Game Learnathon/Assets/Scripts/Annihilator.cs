﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annihilator : MonoBehaviour
{
    public float lifetime;
       private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
