
namespace RoslynTest
{
    using UnityEngine;

    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var pos1 = new Vector2(100, 100);
            var pos2 = new Vector2(200, 200);
            ref var pos3 = ref RefTest1(ref pos1, ref pos2);
            RefTest2(pos1);
            RefTest2(pos2);
            RefTest2(pos3);
        }

        private ref Vector2 RefTest1(ref Vector2 pos1, ref Vector2 pos2)
        {
            return ref (pos1.x > pos2.x) ? ref pos1 : ref pos2;
        }

        private void RefTest2(in Vector2 pos)
        {
            Debug.Log($"X: {pos.x}, Y: {pos.y}");
        }
    }
}
