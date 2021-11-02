using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public GameObject from;
    public GameObject to;

    private void OnMouseDown()
    {
        from.SetActive(false);
        if (this.gameObject.name == "Blue Circle 1")
            Wait();
        else
            StartCoroutine(CalculateFibonacci());
        to.SetActive(true);
        Debug.Log("Done");
    }

    private static int Fibonacci(int n)
    {
        if ((n == 0) || (n == 1))
            return n;

        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    private IEnumerator CalculateFibonacci()
    {
        yield return new WaitForSeconds(3.0f);
        //Fibonacci(40);
    }

    private void Wait()
    {
        Fibonacci(40);
    }
}
