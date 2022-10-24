using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman_explode : MonoBehaviour
{
    public GameObject snow_particle1;
    public GameObject snow_particle2;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(snow_particle1, new Vector3(transform.position.x, transform.position.y+3.0f, transform.position.z), Quaternion.identity);
            Instantiate(snow_particle2, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //Debug.Log("ê·ÇæÇÈÇ‹Ç¬Ç≠ÇÎÅ`");
        }

    }

}
