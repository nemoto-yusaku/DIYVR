using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    private Vector3 move;
    private CharacterController controller;

    public GameObject cameraC;
    private Vector3 moveDir = Vector3.zero;
    private float gravity = 9.8f;
    private float moveH;
    private float moveV;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        moveH = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x;
        moveV = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick).y;
        move = new Vector3 (moveH, 0,moveV);

       
        Vector3 desiredMove = cameraC.transform.forward * move.z + cameraC.transform.right * move.x;
        moveDir.x = desiredMove.x * 3f;
        moveDir.z = desiredMove.z * 3f;
        moveDir.y -= gravity * Time.deltaTime;
    }
}
