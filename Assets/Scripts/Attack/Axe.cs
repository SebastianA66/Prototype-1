using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingdomGates
{
    public class Axe : MonoBehaviour
    {
        public int playerDMG = 1;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Enemy")
            {

                NPCHandler npcHealth = other.GetComponent<NPCHandler>();
                if (npcHealth != null)
                {
                    npcHealth.TakeDMG(playerDMG);
                    Debug.Log("EnemyDie");
                }

            }
        }
    }
}
