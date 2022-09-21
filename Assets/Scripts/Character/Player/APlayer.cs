using System;
using KinematicCharacterController;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.TextCore.Text;

public abstract class APlayer : SCharacter
{
    public Camera cam;

    protected override void StartCharacter()
    {
        StartPlayer();
    }

    protected override void UpdateCharacter()
    {
        UpdatePlayer();
    }

    protected override void HandleInputs()
    {
        //TODO(mish): bring common input handler code here for all players


        // Calls player specific inputs (each character can have an extra spicy
        // player input)
        HandlePlayerInputs();

    }

    protected abstract void HandlePlayerInputs();
    protected abstract void StartPlayer();
    protected abstract void UpdatePlayer();


}

