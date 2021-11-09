using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckExit : MonoBehaviour
{
    public bool Trigger = false;
    public bool exist = false;
    GameObject OnTheWay;

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("wall")){
            Debug.Log("wall here");
            Trigger = true;
        }

        if(exist){
            other.gameObject.tag = "Exist";
        }
    }

    public void Update()
    {
        
        if(exist && Trigger){
            GameObject[] BoxOnTheWay = GameObject.FindGameObjectsWithTag("Exist");
            foreach(GameObject Box in BoxOnTheWay)
            GameObject.Destroy(Box);

        }

        if (exist && !Trigger){
            exist = false;
        }
    }

}
