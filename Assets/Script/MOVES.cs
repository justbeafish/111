using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up")) { transform.Translate(0, 0.1f, 0); }
        // ���� �W�� �ɡA����C�� frame �¦ۨ� z �b��V���� 0.1 ����

        if (Input.GetKey("down")) { transform.Translate(0, -0.1f,0 ); }
        // ���� �U�� �ɡA����C�� frame �¦ۨ� z �b��V���� -0.1 ����


    }
}
