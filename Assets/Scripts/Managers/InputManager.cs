using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager
{
    private static GameControls _Controls;

    public static void Init(Player myplayer)
    {
        _Controls = new GameControls();
        
        _Controls.Game.Movement.performed += hi =>
        {
            myplayer.SetMovementDirection(hi.ReadValue<Vector2>());
        };
        
        _Controls.Permanent.Enable();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public static void SetGameControls()
    {
        _Controls.Game.Enable();
        _Controls.UI.Disable();
    }

    public static void SetUIControls()
    {
        _Controls.UI.Enable();
        _Controls.Game.Disable();
    }
}