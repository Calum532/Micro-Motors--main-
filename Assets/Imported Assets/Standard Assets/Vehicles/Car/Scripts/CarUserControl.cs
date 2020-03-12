using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject ReverseCam;
        public GameObject FrontCam;
        public GameObject WaypointTargetObject;
        public GameObject resetOnCooldownUI;
        GameObject Player;

        private bool resetCooldownFinished = true;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif

            Player = GameObject.FindGameObjectWithTag("Player");

            if (Input.GetKey(KeyCode.LeftControl))
            {
                ReverseCam.SetActive(true);
                FrontCam.SetActive(false);
            }
            else
            {
                ReverseCam.SetActive(false);
                FrontCam.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.F) && resetCooldownFinished == true)
            {
                StartCoroutine(resetVehicle());
            }
            else if (Input.GetKeyDown(KeyCode.F) && resetCooldownFinished == false)
            {
                FindObjectOfType<AudioManager>().Play("Nope");
                resetOnCooldownUI.SetActive(true);
            }
        }

        IEnumerator resetVehicle()
        {
            resetCooldownFinished = false;
            Player.transform.position = WaypointTargetObject.transform.position;
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            //Player.transform.LookAt(WaypointTargetObject);
            yield return new WaitForSeconds(5);
            resetCooldownFinished = true;
            resetOnCooldownUI.SetActive(false);
        }
    }
}
