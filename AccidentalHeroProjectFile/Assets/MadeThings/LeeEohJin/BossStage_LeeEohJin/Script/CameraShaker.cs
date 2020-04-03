using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    

    private float shakes = 0f;

    public float shakeAmount;

    public float decreaseFactor;

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
                //Debug.Log(shakes);

                

                Debug.Log(Random.insideUnitSphere);
                gameObject.transform.position = gameObject.transform.position + (Random.insideUnitSphere * shakeAmount);
                Debug.Log(gameObject.transform.position);
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
