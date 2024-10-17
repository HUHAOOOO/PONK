using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : SaiMonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;

    [SerializeField] private Attack playerAttack;

    public Attack GetPlayerAttack() { return playerAttack; }
    public PlayerInput GetPlayerInput() { return playerInput; }

    protected override void LoadComponents()
    {
        //For override
        LoadPlayerInput();
        LoadAttack();
    }

    private void LoadPlayerInput()
    {
        playerInput = GetComponent<PlayerInput>();
    }    
    
    private void LoadAttack()
    {
        playerAttack = transform.Find("Ability").GetComponentInChildren<Attack>();    
    }
}
