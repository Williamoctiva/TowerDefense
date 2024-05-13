using UnityEngine;

public class Bullet1 : MonoBehaviour// Artillery
{
    private Transform target;

    public float speed = 70f;

    public void Seek (Transform _target1){

      target = _target1;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null){
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame){
            HitTarget();
            return;
        }

        transform.Translate (dir.normalized * distanceThisFrame, Space.World);
        

    }

    void HitTarget(){

        Destroy(gameObject);
    }
    
}
