using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changecolor : MonoBehaviour
{




    //void Update()
    //{

    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //        if (Physics.Raycast(ray, out hit))
    //        {

    //            Debug.Log(hit.transform.name);
    //            //Select Stage
    //            if (hit.transform.name == "Button01")
    //            {
                  
    //                this.GetComponent<Renderer>().material.color = Color.green;

    //                Invoke("WaitingMethod", 1f);
    //            }
    //        }
    //    }

    //}




    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Renderer>().material.color = Color.green;

            Invoke("WaitingMethod", 1f);

        }
    }


    void WaitingMethod()
    {
        SceneManager.LoadScene(3);
    }

}