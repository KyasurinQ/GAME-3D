using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{

    public int LightMode; // nut cong tat
    public GameObject FlameLight; // doi tuong anh sang
    void Start()
    {
        
    }

    void Update()
    {
       if(LightMode == 0)
        {
            StartCoroutine(AnimateLight()); // lam mot cai gi do no se co 1 khoang thoi gian cho` ma` lap di lap lai
        } 
    }

    IEnumerator AnimateLight()
    {
        LightMode = Random.Range( 1, 6);

        if(LightMode == 1 )
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim01");

        }

        if (LightMode == 2)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim02");

        }

        if (LightMode == 3)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim03");

        }

        if (LightMode == 4)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim04");

        }

        if (LightMode == 5)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim05");

        }

        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
}
