using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    bool isRotStop = false; // 룰렛 감속 여부

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 좌클릭시 회전 속도 유지
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            isRotStop = false;
        }
        
        // 우클릭시 회전 속도 감소
        if (Input.GetMouseButtonDown(1))
        {
            isRotStop = true;
        }
        if (isRotStop)
        {
            // 룰렛을 감속
            this.rotSpeed *= 0.96f;
        }

        // 회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
