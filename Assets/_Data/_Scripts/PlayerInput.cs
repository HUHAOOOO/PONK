using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : SaiMonoBehaviour
{
    [SerializeField] private KeyCode keyAttack = KeyCode.None;
    [SerializeField] private KeyCode keyDodge = KeyCode.None;

    [SerializeField] private PlayerCtrl playerCtrl;
    public bool istAttack;
    protected override void LoadComponents()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }
    // Update is called once per frame
    void Update()
    {

        istAttack = Input.GetKeyDown(keyAttack);

        if (istAttack)
        {
            Attack();
        }
    }


    public void Attack()
    {
        playerCtrl.GetPlayerAttack().TriggerAttack();
    }

    //lm tam thoi
    //HAM atack
    //public void ButtonAttack()
    //{
    //    istAttack = true; // ko chay dc anim vi Update gan isAttack = 0 lien tuc r
    //    Attack();
    //}

}
