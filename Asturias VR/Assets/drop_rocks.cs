using UnityEngine;
using System.Collections;

public class drop_rocks : MonoBehaviour
{
    private int numSelectors = 20;
    public GameObject brick; //selected in the editor
    
    void Start(){ 
        
    }


    public void Inst(){
        for (int i = 0; i < numSelectors; i++)
        {
                Instantiate(brick, new Vector3(-8.552f+(i*0.001f), 2.43f+(i*0.001f), 1f+(i*0.1f)), Quaternion.identity);            
        }
        
    }
}