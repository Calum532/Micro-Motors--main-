using UnityEngine;
using TMPro;

public class PlayerSpeed : MonoBehaviour
{
    public static float magnitudeSpeed;
    public static double mphSpeed;
    public bool validReset = false;
    private float resetCountdown = 4;

    public GameObject SpeedUI;
    public GameObject WaypointTargetObject;
    public GameObject Reset_UI;

    [Header("Explosion particle:")]
    public GameObject explosionParticle;

    // caching
    private GameObject _explosionCache;
    private Rigidbody _rb;
    private TextMeshProUGUI _TMP_speed;
    private TextMeshProUGUI _TMP_reset;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _TMP_speed = SpeedUI.GetComponent<TextMeshProUGUI>();
        _TMP_reset = Reset_UI.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        magnitudeSpeed = _rb.velocity.magnitude;
        mphSpeed = magnitudeSpeed * 2.222;
        // colour stuff
        _TMP_speed.color = Color.Lerp(_TMP_speed.color, mphSpeed >= 30 ? Color.yellow : Color.white, Time.deltaTime * 2f);
        _TMP_speed.color = Color.Lerp(_TMP_speed.color, mphSpeed >= 90 ? Color.red : Color.white, Time.deltaTime * 2f);
        //
        _TMP_speed.text = mphSpeed.ToString("F0") + "mph";

        if (mphSpeed < 5)
        {
            resetCountdown -= Time.deltaTime;
            if (resetCountdown <= 0)
            {
                _TMP_reset.text = "Press [E] to reset racer";
                validReset = true;
                if (Input.GetKeyDown(KeyCode.E) && validReset == true)
                {
                    //explosion wow.
                    _explosionCache = Instantiate(explosionParticle, transform.position, Quaternion.identity);
                    Destroy(_explosionCache, 3f);
                    Reset();
                    _TMP_reset.text = "";
                    resetCountdown = 4;
                    validReset = false;
                }
            }
        }
        else if (mphSpeed > 5)
        {
            resetCountdown = 4;
            validReset = false;
            _TMP_reset.text = "";
        }
    }

    public void Reset()
    {
        Debug.Log($"<color=cyan>{transform.name}: Resetting</color>");

        // play audio
        FindObjectOfType<AudioManager>().Play("Reset");

        transform.position = WaypointTargetObject.transform.position;
        transform.rotation = WaypointTargetObject.transform.rotation;
    }
}
