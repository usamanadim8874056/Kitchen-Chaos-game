using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private Player player;
    private float footStepTImer;
    private float footStepTImerMax = .1f;


    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        footStepTImer -= Time.deltaTime;
        if (footStepTImer < 0f)
        {
            footStepTImer = footStepTImerMax;

            if (player.IsWalking())
            {
                float volume = 1f;
                SoundManager.Instance.PlayFootStepSound(player.transform.position, volume);
            }
        }
    }
}
