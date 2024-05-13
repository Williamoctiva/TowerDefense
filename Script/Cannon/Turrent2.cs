using System.Collections;
using UnityEngine;

public class Turrent2 : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]
    public float range = 15f;
    public float fireRate =1f;
    private float fireCountdown =0f;
    
    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public GameObject bulletPrefab;

    public Transform firePoint;

    AudioMAnager audiomanager;
    
     private void Awake(){
        //audiomanager = GameObject.FindGameObjectsWithTag("audio").GetComponent<AudioMAnager>();
        audiomanager = FindObjectOfType<AudioMAnager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountdown <= 0f){
            Shoot();
            fireCountdown = 1 / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }
    void Shoot(){
        GameObject bulletGO = (GameObject)Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet2 bullet2 = bulletGO.GetComponent<Bullet2>();

        if(bullet2 != null)
           bullet2.Seek(target);
            audiomanager.PlaySFX1(audiomanager.cannon);
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

/*using System.Collections;
using UnityEngine;

public class Turrent : MonoBehaviour
{
    private Transform target;

    public float range = 15f;

    public string enemyTag = "Enemy";

    public Transform partToRotate;

    public float turnSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget(){
       GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
       float shortesDistance = Mathf.Infinity;
       GameObject nearestEnemy = null;

       foreach (GameObject enemy in enemies)
       {
         float distanceToEnemy = Vector3.Distance (transform.position, enemy.transform.position);
         if(distanceToEnemy < shortesDistance ){
            shortesDistance = distanceToEnemy;
            nearestEnemy = enemy;
         }
       }

       if(nearestEnemy != null && shortesDistance <= range){
          target = nearestEnemy.transform;
       }
       else{
        target=null;
       }
    }
    // Update is called once per frame
    void Update()
    {
        if(target == null){
            return;

            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
            partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);

        }
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);

    }
}*/
