using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockStart : MonoBehaviour
{
    //public variables
    public int jumpCount;
    public GameObject carLock;
    public GameObject startText;

    // Update is called once per frame
    void Update()
    {
        //Starting game
        if (jumpCount >= 2)
        {
            startText.SetActive (true);//Start game here
        }
    }

   void OnCollisionEnter(Collision other)
   {
        if (other.gameObject.tag == "Player")
        {
            jumpCount++;
            //making lock go down
            carLock.transform.Translate(Vector3.down * 0.5f);
        }
   }
}
