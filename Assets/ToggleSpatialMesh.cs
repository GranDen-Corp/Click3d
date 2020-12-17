using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using UnityEngine;

public class ToggleSpatialMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Toggle()
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        
        switch (observer.DisplayOption)
        {
            case SpatialAwarenessMeshDisplayOptions.None:
                observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
                break;
            case SpatialAwarenessMeshDisplayOptions.Visible:
                observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Occlusion;
                break;
            case SpatialAwarenessMeshDisplayOptions.Occlusion:
                observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
                break;
        }
    }
}