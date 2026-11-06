# Player controller — Unity setup notes

Scripts added:

- `PlayerMovementController.cs`
- `ThirdPersonCameraController.cs`
- `TouchInputController.cs`

## Required Unity configuration

1. Add a `CharacterController` to the player prefab.
2. Assign `PlayerSurvivalStats` to `PlayerMovementController`.
3. Assign the camera target to `ThirdPersonCameraController`.
4. Create UI buttons for run, jump and crouch and connect them to `TouchInputController`.
5. Configure a joystick area on the left side of the screen.

## Not verified

No Unity Editor import, scene setup, prefab creation or runtime test has been performed.
