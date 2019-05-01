using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    [SerializeField]
    private  float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoAutomatico();
        MovimientoLateral();
    }

    private void MovimientoAutomatico() {
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward*force, ForceMode.Force);
    }

    private void MovimientoLateral() {
        this.GetComponent<Rigidbody>().AddForce(Vector3.right * Input.acceleration.x * force, ForceMode.Force);
    }
}
