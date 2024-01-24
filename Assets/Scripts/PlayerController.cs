using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float _speed = 20f;
    [SerializeField] float _turnSpeed = 10f;
    float horizontalInput, verticalInput;

    [SerializeField] string horizontalInpName, verticalInpName;


    void Start(){

        // _plyInput = GetComponent<PlayerInput>();
    }

    void Update()
    {

        horizontalInput = Input.GetAxis(horizontalInpName);
        verticalInput = Input.GetAxis(verticalInpName);

        //vehicle move forward
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * _speed);

        // turn vehicle
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * _turnSpeed );   
        }
}
