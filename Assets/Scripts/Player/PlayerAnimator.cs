using System;
using UnityEngine;

namespace DarkSalo.Player
{
  public class PlayerAnimator : MonoBehaviour
  {
    private static readonly int MoveHash = Animator.StringToHash("Walking");
    private static readonly int AttackHash = Animator.StringToHash("AttackNormal");
    private static readonly int HitHash = Animator.StringToHash("Hit");
    private static readonly int DieHash = Animator.StringToHash("Die");

    private readonly int _idleStateHash = Animator.StringToHash("Idle");
    private readonly int _idleStateFullHash = Animator.StringToHash("Base Layer.Idle");
    private readonly int _attackStateHash = Animator.StringToHash("Attack Normal");
    private readonly int _walkingStateHash = Animator.StringToHash("Run");
    private readonly int _deathStateHash = Animator.StringToHash("Die");
    
    public Animator Animator;
    public CharacterController CharacterController;

    private void Update()
    {
      Animator.SetFloat(MoveHash, CharacterController.velocity.magnitude, 0.1f, Time.deltaTime);
    }

    public void PlayHit() => Animator.SetTrigger(HitHash);
    
    public void PlayAttack() => Animator.SetTrigger(AttackHash);

    public void PlayDeath() =>  Animator.SetTrigger(DieHash);

    public void ResetToIdle() => Animator.Play(_idleStateHash, -1);
    
  }
}