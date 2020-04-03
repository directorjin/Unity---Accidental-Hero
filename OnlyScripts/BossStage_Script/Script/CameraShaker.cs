using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    

    public float shakes = 0f;

    public float shakeAmount = 0.000001f;

    public float decreaseFactor = 1.0f;

    bool CameraShaking = false;



    void Start()

    {
        


    }

    public void ShakeCamera(float shaketime)

    {

        shakes = shaketime;
        
        CameraShaking = true;

    }



    void LateUpdate()

    {



        if (CameraShaking)
        {

            if (shakes > 0)

            {
                
                gameObject.transform.position = gameObject.transform.position + Random.insideUnitSphere * shakeAmount;
                shakes -= Time.deltaTime * decreaseFactor;
                

            }
            
                
            else

            {

                shakes = 0f;
                CameraShaking = false;
                

            }





        }



    }

}
