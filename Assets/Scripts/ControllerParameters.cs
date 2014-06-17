using UnityEngine;
using System.Collections;
using System;
[Serializable] 
public class ControllerParameters {
  public enum JumpBehavior{
      CanJumpOnGround,
      CanJumpAnywhere,
      CantJump
  }

  public Vector2 MaxVelocity = new Vector2(float.MaxValue, float.MaxValue);
  [Range (0,90)]
  public float SlopeLimit = 30;
  public float Gravity = -25f;
  public JumpBehavior JumpRestrictions;
  public float JumpFrequency = .25f;
}
