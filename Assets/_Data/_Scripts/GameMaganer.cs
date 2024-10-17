using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaganer : SaiMonoBehaviour
{
    private static GameMaganer instance;
    public static GameMaganer Instance => instance;


    protected override void Awake()
    {
        base.Awake();
        if (GameMaganer.instance != null) Debug.LogError("Only 1 GameMaganer allow to exist");
        GameMaganer.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
    }

}
