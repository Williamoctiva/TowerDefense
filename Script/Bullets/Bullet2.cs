using UnityEngine;

public class Bullet2 : MonoBehaviour // Cannon
{
    private Transform target;

    public float speed = 20f;

    public void Seek (Transform _target2){

      target = _target2;
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
