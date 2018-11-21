using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KingdomGates
{
    public class Axe : MonoBehaviour
    {
        public int playerDMG = 1;
        public GameObject hammer;
        private Animator swing;

        public bool canSwing;

        private void Start()
        {
            canSwing = true;
            swing = GetComponent<Animator>();
        }

        private void Update()
        {
            if(Input.GetMouseButton(0) && canSwing)
            {
                Debug.Log("SwungBoi");
                canSwing = false;
                swing.Play("Swing");
            }
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

            }
        }

        public void EnableSwing()
        {
            Debug.Log("EnabledBoi");

            canSwing = true;
        }
    }

}
