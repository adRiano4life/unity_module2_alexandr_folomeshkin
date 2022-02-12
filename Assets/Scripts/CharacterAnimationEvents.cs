using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;

    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void ShootEnd()
    {
        character.SetState(Character.State.Idle);
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
    }

    void EnemyDeath()
    {
        character.enemy.SetState(Character.State.Death);
    }

    void ZombieAttackEnd()
    {
        character.SetState(Character.State.Idle);
    }
}
