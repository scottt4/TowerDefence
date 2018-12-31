using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealthController : MonoBehaviour
{
    public bool UseRelativeLocation = true;

    private Quaternion RelativeLocation;

    // Start is called before the first frame update
    void Start()
    {
        RelativeLocation = transform.parent.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (UseRelativeLocation)
        {
            transform.rotation = RelativeLocation;
        }
    }
}
