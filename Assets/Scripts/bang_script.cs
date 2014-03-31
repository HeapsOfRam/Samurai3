using UnityEngine;
using System.Collections;

public class bang_script : MonoBehaviour {

    public GameObject bang, samurai, enemy;
    private GameObject bang_clone, samurai_clone, enemy_clone;
    public GameObject samurai_victor, samurai_corpse, enemy_victor, enemy_corpse;
    private GameObject samurai_victor_clone, samurai_corpse_clone, enemy_victor_clone, enemy_corpse_clone;
    public Vector3 bang_spawn_position, samurai_spawn_position, enemy_spawn_position;
    public Vector3 samurai_victor_position, samurai_corpse_position, enemy_victor_position, enemy_corpse_position;
    public float enemy_reaction;
    public int next_level;
    float spawn_timer = 0.0f;
    float reaction_timer = 0.0f;
    float wait_time;
    bool not_instantiated = true;
    bool preemptive = false;

	// Use this for initialization
	void Start () {
        wait_time = Random.Range(3.0f, 20.0f);

        samurai_clone = (GameObject)Instantiate(samurai, samurai_spawn_position, Quaternion.identity);
        enemy_clone = (GameObject)Instantiate(enemy, enemy_spawn_position, Quaternion.identity);
	}

    void spawn_bang()
    {
        not_instantiated = false;
        bang_clone = (GameObject) Instantiate(bang, bang_spawn_position, Quaternion.identity);
    }

    void destroy_bang()
    {
        Destroy(bang_clone);
    }

    void enemy_win()
    {

    }

    void player_win()
    {
        samurai_victor_clone = (GameObject) Instantiate(samurai_victor, samurai_victor_position, Quaternion.identity);
        enemy_corpse_clone = (GameObject) Instantiate(enemy_corpse, enemy_corpse_position, Quaternion.identity);
        Destroy(samurai_clone);
        Destroy(enemy_clone);
        //Application.LoadLevel(next_level);
    }

	// Update is called once per frame
	void Update () {
        if (not_instantiated)
        {
            spawn_timer += Time.deltaTime;

            if (spawn_timer > wait_time)
            {
                spawn_bang();
            }
        }
        else
        {
            reaction_timer += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (reaction_timer > enemy_reaction)
                    enemy_win();
                else
                    player_win();

                destroy_bang();
                print(reaction_timer);
            }
        }
	}
}
