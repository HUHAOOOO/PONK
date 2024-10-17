using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : SaiMonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance => instance;



    protected override void Awake()
    {
        base.Awake();
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager allow to exist");
        InputManager.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }


    private void GetInput()
    {

    }

}
