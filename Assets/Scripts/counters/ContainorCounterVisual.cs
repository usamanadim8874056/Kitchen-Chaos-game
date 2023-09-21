using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainorCounterVisual : MonoBehaviour
{

    private const string OPEN_CLOSE = "OpenClose";

    [SerializeField] ContainorCounter containorCounter;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        containorCounter.OnPlayerGrabbedObject += ContainorCounter_OnPlayerGrabbedObject;
    }

    private void ContainorCounter_OnPlayerGrabbedObject(object sender, System.EventArgs e)
    {
        animator.SetTrigger(OPEN_CLOSE);
    }
}
