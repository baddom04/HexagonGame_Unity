using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private float rotationSpeed = 300f;
    void Update()
    {
        ComputerControl();
        MobileControl();
    }
    void ComputerControl(){
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            transform.RotateAround(Vector3.zero, Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            transform.RotateAround(Vector3.zero, Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
    void MobileControl(){
        foreach (Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Moved){
                transform.RotateAround(Vector3.zero, Vector3.forward, -touch.deltaPosition.x * 0.75f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        SceneManager.LoadScene("SampleScene");
    }
}
