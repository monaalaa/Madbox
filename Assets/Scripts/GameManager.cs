using System;
using System.Collections.Generic;
using Player;
using UnityEngine;
using Weapons;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        private void Start()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public PlayerController Player;
        /*public GameObject[] weaponsPrefabs;
        public PlayerController player;

        public List<IWeapon> weapons=new List<IWeapon>();
        private void Awake()
        {
            //instantiate prefabs
            for (int i = 0; i < weaponsPrefabs.Length; i++)
            {
               IWeapon weapon= Instantiate(weaponsPrefabs[i]).GetComponent<IWeapon>();
            }

            player.SetWeapon(weapons[0]);
        }*/
    }
}
