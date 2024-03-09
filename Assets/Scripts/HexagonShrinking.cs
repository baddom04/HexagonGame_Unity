using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonShrinking : MonoBehaviour
{
    private float shrinkSpeed = 3f;
    void Start() {
        transform.Rotate(Vector3.forward * Random.Range(0, 360));
        transform.localScale = Vector3.one * 10f;
    }
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if(transform.localScale.x <= 0.05f){
            Destroy(gameObject);
        }
    }
}
