using Assets.Scripts.Character.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Character.Attack
{
    public class AttackComponent : MonoBehaviour
    {
        [SerializeField] private int damage;
        public int Damage { get => damage; }

        public string soundName;
        public string damageEnemy;
        private PlaySound playsound;
        public Action<int> OnDamageChanged;
        public Action OnAttackFinished;

        private void Start()
        {
            playsound = GetComponent<PlaySound>();
        }
        public void Attack(HealthComponent healthComponent)
        {
            if (healthComponent.IsDead)
            {
                OnAttackFinished?.Invoke();
                return;
            }

            healthComponent.ApplyDamage(this);
            OnAttackFinished?.Invoke();
        }

        public void AttackSound()
        {
            if(playsound) playsound.Play(soundName);
        }

        public void DamageSoundEnemy()
        {
            if(playsound) playsound.Play(damageEnemy);
        }
    }
}