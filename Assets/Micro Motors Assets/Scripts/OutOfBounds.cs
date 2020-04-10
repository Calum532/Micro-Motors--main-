using System.Collections;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject explosionParticle;
    private GameObject _explosionCache;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"<color=cyan>{other.transform.name}: Out of bounds</color>");

            // instantiate particle
            _explosionCache = Instantiate(explosionParticle, other.transform.position, Quaternion.identity);
            Destroy(_explosionCache, 1f);

            //reset them
            foreach (MeshRenderer m in other.GetComponentsInChildren<MeshRenderer>())
            {
                m.enabled = false;
            }
            other.GetComponent<Rigidbody>().Sleep();
            StartCoroutine(resetPlayer(other));
        }
        else if (other.CompareTag("AICar"))
        {
            Debug.Log($"<color=yellow>{other.transform.name}: Out of bounds</color>");

            // instantiate particle
            _explosionCache = Instantiate(explosionParticle, other.transform.position, Quaternion.identity);
            Destroy(_explosionCache, 1f);

            //reset them
            other.GetComponent<ResetAICar>().Reset();
        }
    }

    IEnumerator resetPlayer(Collider other)
    {
        yield return new WaitForSeconds(1f);

        foreach (MeshRenderer m in other.GetComponentsInChildren<MeshRenderer>())
        {
            m.enabled = true;
        }
        other.GetComponent<PlayerSpeed>().Reset();
    }
}
