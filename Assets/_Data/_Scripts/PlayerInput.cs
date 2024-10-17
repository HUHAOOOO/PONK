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

        if (Input.GetKeyDown(keyAttack))
        {
            playerCtrl.GetPlayerAttack().TriggerAttack();
        }
    }
}
