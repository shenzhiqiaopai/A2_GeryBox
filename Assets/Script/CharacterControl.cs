using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    float moveSpeed = 100f; // move speed
    float rotateAngle = 45f; // Rotat


    public Button moveLeftButton;
    public Button moveRightButton;
    public Button resetButton;
    public Button turnLeftButton;
    public Button turnRightButton;
    Vector3 initialPosition; 
    Quaternion initialRotation;


    void Start()
    {
        moveLeftButton.onClick.AddListener(MoveLeft);
        moveRightButton.onClick.AddListener(MoveRight);
        resetButton.onClick.AddListener(ResetPosition); 
        turnLeftButton.onClick.AddListener(TurnLeft);
        turnRightButton.onClick.AddListener(TurnRight);
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }


    void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }


    void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
     void TurnLeft()
    {
        transform.Rotate(Vector3.up, -rotateAngle);
    }

    void TurnRight()
    {
        transform.Rotate(Vector3.up, rotateAngle);
    }

     void ResetPosition()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}
