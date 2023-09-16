using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        Vector3 changePosition = new Vector3((stickR.x), 0, (stickR.y));

        Vector3 changePositon = new Vector3(0, InputTracking.GetLocalRotation(XRNode.Head).eulerAngles.y,0);

        this.transform.position += this.transform.rotation * (Quaternion.Euler(changePositon) * changePositon);
        
    }
}

