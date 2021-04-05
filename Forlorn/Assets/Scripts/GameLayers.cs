using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLayers : MonoBehaviour
{
    [SerializeField] LayerMask solidObjctsLayer;
    [SerializeField] LayerMask interactableLayer;
    [SerializeField] LayerMask sceneTransitionLayer;

    public static GameLayers i { get; set; }

    private void Awake()
    {
        i = this;
    }

    public LayerMask SolidLayer
    {
        get => solidObjctsLayer;
    }

    public LayerMask InteractableLayer
    {
        get => interactableLayer;
    }

    public LayerMask SceneTransitionLayer
    {
        get => sceneTransitionLayer;
    }

    public LayerMask TriggerableLayers
    {
        get => sceneTransitionLayer;
    }
}
