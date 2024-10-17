using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : SaiMonoBehaviour
{
    [SerializeField] private Transform player;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        player = transform.parent.GetComponent<Transform>();

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            player.Rotate(0, 180, 0);
        }
    }

}
