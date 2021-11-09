using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exist : MonoBehaviour
{
      public GameObject WayOne;
      public GameObject WayTwo;

    void Update(){
        if(WayOne.GetComponent<CheckExit>().Trigger && WayTwo.GetComponent<CheckExit>().Trigger){
            if(!WayOne.GetComponent<CheckExit>().Trigger && !WayTwo.GetComponent<CheckExit>().Trigger){
                int num = Random.Range(1,3);
                if(num == 1){
                    WayOne.GetComponent<CheckExit>().exist = true;
                }
                if(num == 2){
                    WayTwo.GetComponent<CheckExit>().exist = true;
                }
            }

        }
        
    }


}
