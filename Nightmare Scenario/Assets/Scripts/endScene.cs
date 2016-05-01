using UnityEngine;
using System.Collections;

public class endScene : MonoBehaviour {


    void Start()
    {
        StartCoroutine(CloseAfterTime());

    }
        

 


    IEnumerator CloseAfterTime()
    {

        Debug.Log("Before waiting");
       yield return new WaitForSeconds(9);
        Debug.Log("After Waiting");
        Application.LoadLevel(0);

    }

     public void Update()
    {
        //if (Input.GetButtonDown("Space"))
        //{
           // Debug.Log("Escape was pressed");
           // Application.Quit();
        //}
            
    }

}
