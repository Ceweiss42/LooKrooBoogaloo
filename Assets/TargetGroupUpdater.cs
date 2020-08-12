using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class TargetGroupUpdater : MonoBehaviour
{
    public Transform targetGroup;

    public List<Cinemachine.CinemachineTargetGroup.Target> targets = new List<Cinemachine.CinemachineTargetGroup.Target>();
    bool contains  = false;
    // Start is called before the first frame update
    void Start()
    {
        targetGroup = GetComponent<Transform>();
        foreach (Cinemachine.CinemachineTargetGroup.Target t in targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets)
        {
            targets.Add(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        for (int i = 0; i < targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets.Length; i++)
        {
            Cinemachine.CinemachineTargetGroup.Target t = targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets[i];
            Debug.Log(t.target.transform.position.y);
            if (t.target.transform.position.z < -5 || t.target.transform.position.z > 15 || t.target.transform.position.y < -5 || t.target.transform.position.y > 10)
            {
                targetGroup.GetComponent<CinemachineTargetGroup>().RemoveMember(t.target.transform);
            }
            else
            {
                t.weight = 1f;
            }
        }

        foreach (Cinemachine.CinemachineTargetGroup.Target t in targets)
        {
            
            if(t.target.transform.position.z > -5 && t.target.transform.position.z < 15 && t.target.transform.position.y > -5 && t.target.transform.position.y < 10)
            {
                if (targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets.Length == 1)
                {
                    if(targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets[0].target.transform == GameObject.Find("Stage").transform)
                    {
                        targetGroup.GetComponent<CinemachineTargetGroup>().AddMember(t.target.transform, 1, 0);
                    }

                    else if(targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets[0].target.transform != t.target.transform)
                    {
                        targetGroup.GetComponent<CinemachineTargetGroup>().AddMember(t.target.transform, 1, 0);
                    }
                }

                if (targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets.Length == 2)
                {
                    if (targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets[0].target.transform == GameObject.Find("Stage").transform)
                    {
                        targetGroup.GetComponent<CinemachineTargetGroup>().RemoveMember(GameObject.Find("Stage").transform);
                    }
                }
            }
        }

        if(targetGroup.GetComponent<CinemachineTargetGroup>().m_Targets.Length == 0)
        {
            targetGroup.GetComponent<CinemachineTargetGroup>().AddMember(GameObject.Find("Stage").transform, 1, 0);
        }
        
    }
}
