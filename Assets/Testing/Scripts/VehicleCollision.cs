
using UnityEngine;

public class VehicleCollision : MonoBehaviour
{
    [Header("Particle to play:")]
    public ParticleSystem collisionParticles;

    [Header("Settings")]
    public int ForceRequired;

    private ParticleSystem _cachedParticles;
    private GameObject _this;

    void Awake()
    {
        _this = gameObject;
    }

    void OnCollisionEnter(Collision collision)
    {       
        if (collision.relativeVelocity.magnitude > ForceRequired)
        {
            _cachedParticles = Instantiate(collisionParticles, _this.transform.position, collision.transform.rotation);
        }
    }
}
