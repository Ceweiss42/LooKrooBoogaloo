using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace roundbeargames_tutorial
{
    public class SupCam : MonoBehaviour
    {

        public FocusCam FocusCam;

        public List<GameObject> Players;

        public float DepthUpdateSpeed = 5f;
        public float AngleUpdateSpeed = 7f;
        public float PositionUpdateSpeed = 5f;

        public float DepthMax = -10f;
        public float DepthMin = -22f;

        public float AngleMax = 11f;
        public float AngleMin = 3f;

        private float CameraEulerX;
        private Vector3 CameraPosition;


        // Use this for initialization
        void Start()
        {
            Players.Add(FocusCam.gameObject);
        }

        // Update is called once per frame
        private void LateUpdate()
        {
            CalculateCameraLocations();
            MoveCamera();
        }

        private void MoveCamera()
        {
            Vector3 position = gameObject.transform.position;
            if (position != CameraPosition)
            {
                Vector3 targetPosition = Vector3.zero;
                targetPosition.x = Mathf.MoveTowards(position.x, CameraPosition.x, PositionUpdateSpeed * Time.deltaTime);
                targetPosition.y = Mathf.MoveTowards(position.y, CameraPosition.y, PositionUpdateSpeed * Time.deltaTime);
                targetPosition.z = Mathf.MoveTowards(position.z, CameraPosition.z, DepthUpdateSpeed * Time.deltaTime);
                gameObject.transform.position = targetPosition;
            }

            Vector3 localEulerAngles = gameObject.transform.localEulerAngles;
            if (localEulerAngles.x != CameraEulerX)
            {
                Vector3 targetEulerAngles = new Vector3(CameraEulerX, localEulerAngles.y, localEulerAngles.z);
                gameObject.transform.localEulerAngles = Vector3.MoveTowards(localEulerAngles, targetEulerAngles, AngleUpdateSpeed * Time.deltaTime);
            }
        }


        private void CalculateCameraLocations()
        {
            Vector3 averageCenter = Vector3.zero;
            Vector3 totalPositions = Vector3.zero;
            Bounds playerBounds = new Bounds();

            for (int i = 0; i < Players.Count; i++)
            {
                Vector3 playerPosition = Players[i].transform.position;

                if (!FocusCam.FocusBounds.Contains(playerPosition))
                {
                    float playerX = Mathf.Clamp(playerPosition.x, FocusCam.FocusBounds.min.x, FocusCam.FocusBounds.max.x);
                    float playerY = Mathf.Clamp(playerPosition.y, FocusCam.FocusBounds.min.y, FocusCam.FocusBounds.max.y);
                    float playerZ = Mathf.Clamp(playerPosition.z, FocusCam.FocusBounds.min.z, FocusCam.FocusBounds.max.z);
                    playerPosition = new Vector3(playerX, playerY, playerZ);
                }

                totalPositions += playerPosition;
                playerBounds.Encapsulate(playerPosition);
            }

            averageCenter = (totalPositions / Players.Count);

            float extents = (playerBounds.extents.x + playerBounds.extents.z);
            float lerpPercent = Mathf.InverseLerp(0, (FocusCam.HalfXBounds + FocusCam.HalfZBounds) / 2, extents);

            float depth = Mathf.Lerp(DepthMax, DepthMin, lerpPercent);
            float angle = Mathf.Lerp(AngleMax, AngleMin, lerpPercent);

            CameraEulerX = angle;
            CameraPosition = new Vector3(depth, averageCenter.y, averageCenter.z);
        }
    }

}
