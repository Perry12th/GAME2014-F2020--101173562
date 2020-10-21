/* Source file Name: BackgroundController.cs
 * Student Name: Flavio Araujo Silva
 * StudentID: 101173562
 * Last Date Mod: 2020-10-20
 * Description: Controller for the Space Background
 * Revision History: Changed the background to scroll from right to left instead of top-down
 */
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the left side of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
