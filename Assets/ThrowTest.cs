 using UnityEngine;
 using System.Collections;
 
 public class ThrowTest : MonoBehaviour
 {
     public GameObject player;
     private Vector3 offset;
     void Start() {
         offset = transform.position - player.transform.position;
       
     }
 
     void LateUpdate()
     {
         transform.position = player.transform.position + offset;
         /*if (Input.GetMouseButtonDown(0)) {
             transform.position = transform.position + Camera.main.transform.forward * 2;
             Rigidbody rb = GetComponent<Rigidbody>();
             rb.velocity = Camera.main.transform.forward * 40;

         }*/
     }
 }