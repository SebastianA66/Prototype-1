using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace KingdomGates
{
    public class NPCHandler : MonoBehaviour
    {
        public float npcSpeed = 10;
        public int npcMaxHealth = 1;
        public bool npcAlive;
        public int npcDmg = 25;
        public bool doDMG;
        public bool takeDMG;
        public int npcHealth = 1;





        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {

                CharHandler playerHealth = other.GetComponent<CharHandler>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(npcDmg);
                    Debug.Log("Die");
                }

                //DealDamage(npcDmg);
            }
        }

        private void NPCDeath()
        {

        }
        public void DealDamage(int npcDmg)
        {

        }
        public void TakeDMG(int playerDMG)
        {
            npcMaxHealth -= playerDMG;
        }
    }
}

