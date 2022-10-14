using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange;
    public float attackAngle;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print("HELLO"); 
        }
    }

    void Attack()
    {
        //Ativar animação de ataque

        //Encontrar inimigos no range da esfera
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange);
        foreach(Collider2D enemy in hitEnemies)
        {
            //Verificar se  inimigo está dentro da área de ataque (Compara utilizando o angulo)
            //Caso sim danifica-lo!
        }
    }
    private void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
