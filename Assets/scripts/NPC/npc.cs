using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter2D(Collision2D col)
    {
      
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("NPC GUIDE");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
