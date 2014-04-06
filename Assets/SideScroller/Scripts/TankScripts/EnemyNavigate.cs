using UnityEngine;
using System.Collections;

public class EnemyNavigate : MonoBehaviour {

	    public GameObject target;
     
    // Update is called once per frame
    void Update () {
    
    this.gameObject.GetComponent<NavMeshAgent>().destination = target.transform.position;
     
    }
}
