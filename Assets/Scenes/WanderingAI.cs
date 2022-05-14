using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Scenes
{
    public class WanderingAI : MonoBehaviour
    {
        public float speed = 3.0f;
        public float obstacleRange = 5.0f;
        private bool isAlive;
        
        private void Start()
        {
            isAlive = true;
        }

        private void Update()
        {
            if (isAlive)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
                Ray ray = new Ray(transform.position, transform.forward);
                RaycastHit hit;
                if (Physics.SphereCast(ray, .75f, out hit))
                {
                    if (hit.distance < obstacleRange)
                    {
                        float angle = Random.Range(-110, 110);
                        transform.Rotate(0, angle, 0);
                    }
                }
            }
        }

        public void setAlive(bool alive)
        {
            isAlive = alive;
        }
    }
}