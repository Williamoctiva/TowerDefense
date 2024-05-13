using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;

    private float countdown = 2f;
    public Text waveCountdownText;

    private int WaveIndex = 0;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(countdown <= 0){
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
          WaveIndex++;
        for(int i = 0; i < WaveIndex; i++){
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
      
    }
    void SpawnEnemy(){
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
