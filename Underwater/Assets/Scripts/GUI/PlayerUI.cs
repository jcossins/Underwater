﻿using UnityEngine;
using System.Collections;

public class PlayerUI : MonoBehaviour {

    public Player player;

    public HealthBar healthBar;
    public MeterBar meterBar;
    public StockCount stockCount;

	// Use this for initialization
	void Start () {
        healthBar.SetMaxHealth(player.maxHealth);
        healthBar.SetHealth(player.health);
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.SetHealth(player.health);
	}
}
