using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int force = 1000;
 
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) )
        {
            GetComponent<Rigidbody>().AddForce( force ,0,0 );
        }
        
    }
}
