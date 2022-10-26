using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Sword"){
            TakeDamage();
        }
    }

    void TakeDamage(){
        currentHealth--;
        animator.SetTrigger("TookDamage");
        if(currentHealth <= 0){
            Destroy(gameObject);
        }
        
    }
}
