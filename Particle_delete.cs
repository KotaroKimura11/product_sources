using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_delete : MonoBehaviour
{
    ParticleSystem Snow_Explosion_particle;
   
    // Start is called before the first frame update
    void Start()
    {
       
            Snow_Explosion_particle = GetComponent<ParticleSystem>();
      
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Snow_Explosion_particle.isStopped) //パーティクルが終了したか判別
            {
                Destroy(this.gameObject);//パーティクル用ゲームオブジェクトを削除
            }
        
        
        
    }
}
