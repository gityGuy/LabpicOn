using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ray : MonoBehaviour
{
    public GameObject target;
    public GameObject object1, object2, object3, object4, object5, object6;
    public GameObject title1, title2, title3, title4, title5, title6;
    public GameObject Qr;
    public bool boll = false;
    /*
    //  public RayCastHit _Hit;
    //  public LayerMask _RaycastCollidableLayers;
    //  public float _CheckDistance = 100f;


    void Update()
    {
        if (Physics.Raycast(transform.position, tranform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f)) ;
        {
            Debug.Log("hit something");
            Debug.DrawRay(transform.position, tranform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.red);

        }
    }


}


*/
    //............................................................................................................
    /**
     public Camera fpsCam;
public float  range = 100f;
     void PerformRaycast()
     {
        RaycastHit hit;
      if(  Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit,range));
        {
            Debug.Log(hit.transform.name);
             Target target =hit.transform.GetComponent<Target>();
            if(target != null)
            {
                Debug.Log("on");
            }
       }
     }
*/

    //...................................................................................................................................................................
    //   public RayCastHit _Hit;









    public LayerMask layermask; //Set this in inspector, makes you able to say which layers should be collided with and which not.
    public float rayLength = 100f;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 100f)) ;
            {
                Debug.Log(hitinfo.collider.name);
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.red);


                if (hitinfo.collider.name == "Cube")
                {
                    target.transform.position = new Vector3(-59.75f, 0.1f, -3f);
                }
                else if (hitinfo.collider.name == "PAY1")
                {
                    target.transform.position = new Vector3(0f, 1f, -6f);//.........inner lobby
                                                                         // SceneManager.LoadScene(1);
                                                                         // target.transform.position = new Vector3(-22f, 0.7f, 4f);//.............outer lobby
                                                                         //object1.SetActive(false);
                }
                //..............................................

                else if (hitinfo.collider.name == "Cube (1)")
                {
                    target.transform.position = new Vector3(-59.75f, 0.1f, -3f);
                    //   object1.SetActive(true);
                }


                else if (hitinfo.collider.name == "pOn")
                {
                    object1.SetActive(false);
                    object2.SetActive(true);
                    object3.SetActive(true);
                    object4.SetActive(true);
                    object5.SetActive(true);
                    object6.SetActive(true);


                    title1.SetActive(true);
                    title2.SetActive(false);
                    title3.SetActive(false);
                    title4.SetActive(false);
                    title5.SetActive(false);
                    title6.SetActive(false);
                }


                //.............................

                else if (hitinfo.collider.name == "Cube (2)")
                {
                    target.transform.position = new Vector3(-59.75f, 0.1f, -3f);
                }

                else if (hitinfo.collider.name == "pOn (1)")
                {
                    object1.SetActive(true);
                    object2.SetActive(false);
                    object3.SetActive(true);
                    object4.SetActive(true);
                    object5.SetActive(true);
                    object6.SetActive(true);


                    title1.SetActive(false);
                    title2.SetActive(true);
                    title3.SetActive(false);
                    title4.SetActive(false);
                    title5.SetActive(false);
                    title6.SetActive(false);
                }
                //.....................................

                else if (hitinfo.collider.name == "Cube (3)")
                {
                    target.transform.position = new Vector3(-59.75f, 0.1f, -3f);
                }
                else if (hitinfo.collider.name == "pOn (2)")
                {
                    object1.SetActive(true);
                    object2.SetActive(true);
                    object3.SetActive(false);
                    object4.SetActive(true);
                    object5.SetActive(true);
                    object6.SetActive(true);


                    title1.SetActive(false);
                    title2.SetActive(false);
                    title3.SetActive(true);
                    title4.SetActive(false);
                    title5.SetActive(false);
                    title6.SetActive(false);
                }
                //....................................
                else if (hitinfo.collider.name == "Cube (4)")
                {
                    target.transform.position = new Vector3(-59.75f, 0.1f, -3f);
                }
                else if (hitinfo.collider.name == "pOn (3)")
                {

                    object1.SetActive(true);
                    object2.SetActive(true);
                    object3.SetActive(true);
                    object4.SetActive(false);
                    object5.SetActive(true);
                    object6.SetActive(true);


                    title1.SetActive(false);
                    title2.SetActive(false);
                    title3.SetActive(false);
                    title4.SetActive(true);
                    title5.SetActive(false);
                    title6.SetActive(false);

                }
                //............................


                else if (hitinfo.collider.name == "Cube (5)")
                {
                    target.transform.position = new Vector3(-59.75f, 0.1f, -3f);
                }
                else if (hitinfo.collider.name == "pOn (4)")
                {
                    object1.SetActive(true);
                    object2.SetActive(true);
                    object3.SetActive(true);
                    object4.SetActive(true);
                    object5.SetActive(false);
                    object6.SetActive(true);


                    title1.SetActive(false);
                    title2.SetActive(false);
                    title3.SetActive(false);
                    title4.SetActive(false);
                    title5.SetActive(true);
                    title6.SetActive(false);

                }
                else if (hitinfo.collider.name == "pOn (5)")
                {
                    object1.SetActive(true);
                    object2.SetActive(true);
                    object3.SetActive(true);
                    object4.SetActive(true);
                    object5.SetActive(true);
                    object6.SetActive(false);


                    title1.SetActive(false);
                    title2.SetActive(false);
                    title3.SetActive(false);
                    title4.SetActive(false);
                    title5.SetActive(false);
                    title6.SetActive(true);

                }
                //.................................................
                else if (hitinfo.collider.name == "okDone")
                {

                    target.transform.position = new Vector3(-22f, 0.7f, 4f);
                }


                else if (hitinfo.collider.name == "paytm btn")
                {
                    Qr.SetActive(true);

                }
                else if (hitinfo.collider.name == "Quit")
                {
                    Application.Quit();

                }
                else if (hitinfo.collider.name == "Restart")
                {
                    SceneManager.LoadScene(2);

                }









            }

        }

    }
}