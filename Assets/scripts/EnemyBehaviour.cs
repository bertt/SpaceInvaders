using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets
{
    public class EnemyBehaviour:MonoBehaviour
    {
        public int Speed = -6;
        void Start()
        {
            var ps = this.GetComponent<ParticleSystem>();
            ps.Stop();

            var rigidBody = this.GetComponent<Rigidbody2D>();
            rigidBody.velocity = new Vector2(0, Speed);

            rigidBody.angularVelocity = Random.Range(-200, 200);

            // Destroy(this.gameObject, 3);
        }


        private void OnTriggerEnter2D(Collider2D obj)
        {
            var ps = this.GetComponent<ParticleSystem>();
            ps.Play();

            var name = obj.gameObject.name;

            // If it collided with a bullet
            if (name == "bulletprefab(Clone)")
            {
                // Destroy itself (the enemy)
                Destroy(gameObject);

                // And destroy the bullet
                Destroy(obj.gameObject);
            }

            // If it collided with the spaceship
            if (name == "spaceship")
            {
                // Destroy itself (the enemy) to keep things simple
                Destroy(gameObject);
            }
        }

        void Update()
        {
            
        }

        public void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

    }
}
