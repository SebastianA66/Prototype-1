using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingdomGates
{
    public class CharHandler : MonoBehaviour
    {
        public bool alive;
        public int maxHealth = 100;
        public float curHealth;
        public GUIStyle healthBar;
        public bool takeDMG;
        //public int damage = 25;
        public int playerDMG = 1;



        private void Start()
        {
            curHealth = maxHealth;
            alive = true;
        }

        private void LateUpdate()
        {
            if (curHealth >= maxHealth)
            {
                curHealth = maxHealth;
            }
            if (curHealth <= 0 && alive)
            {
                alive = false;
                Dead();
            }
            //if (curHealth <= 0)
            //{
            //    alive = false;
            //}
        }
        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.gameObject.name == "Enemy")
        //    {
        //        takeDMG = true;
        //        if (takeDMG == true)
        //        {
        //            curHealth -= damage;
        //        }
        //    }
        //}
        public void TakeDamage(int npcDmg)
        {
            curHealth -= npcDmg;
        }
        public void Dead()
        {
            gameObject.SetActive(false);
        }
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

                //DealDamage(npcDmg);
            }
        }

    }
}
