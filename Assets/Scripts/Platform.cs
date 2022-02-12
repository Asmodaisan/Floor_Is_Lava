using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public bool wasVisited;
    
    public void VisitPlatform()
    {
        wasVisited = true;
    }

    public bool WasPlatformVisited()
    {
        return wasVisited;
    }
}
