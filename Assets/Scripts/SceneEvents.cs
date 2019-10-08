using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEvents : MonoBehaviour
{
    public static SceneEvents Events;

    public event Action<GameObject> OnBoxDestroyed;

    private void Awake()
    {
        Events = this;
    }

    public void BoxDestroyed(GameObject box)
    {
        OnBoxDestroyed?.Invoke(box);
    }
}
