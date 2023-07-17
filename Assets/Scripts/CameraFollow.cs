using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float speed = 4f;
    private float y_offest = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x,target.position.y+ y_offest, -10f);
        transform.position = Vector3.Slerp(transform.position,newpos,speed*Time.deltaTime);
    }
}
