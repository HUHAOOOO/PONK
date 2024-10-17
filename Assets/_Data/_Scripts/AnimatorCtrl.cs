using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCtrl : SaiMonoBehaviour
{
    [SerializeField] private string currentAnimaton;
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerCtrl playerCtrl;

    //Animation States
    const string PLAYER_IDLE = "Idle";
    const string PLAYER_ATTACK = "Attack";
    const string PLAYER_DODGE = "Dodge";

    protected override void LoadComponents()
    {
        animator = GetComponentInChildren<Animator>();
        playerCtrl = GetComponent<PlayerCtrl>();
    }
    // Update is called once per frame
    void Update()
    {
        ShowAnimation();
    }


    private void ShowAnimation()
    {
        if (playerCtrl.GetPlayerInput().istAttack)
        {
            ChangeAnimationState(PLAYER_ATTACK);
        }
        // neu an z thi attack
        // x dodge

        // Chem xong quay ve idle bug
        ChangeAnimationState(PLAYER_IDLE);

    }

    private void ChangeAnimationState(string newAnimation)
    {
        if (currentAnimaton == newAnimation) return;

        animator.Play(newAnimation);
        currentAnimaton = newAnimation;
    }

}
