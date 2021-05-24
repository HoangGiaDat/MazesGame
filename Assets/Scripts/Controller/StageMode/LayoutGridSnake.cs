using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LTAUnityBase.Base.UI
{
    [DisallowMultipleComponent]
    public class LayoutGridSnake : MonoBehaviour
    {
        public Vector2 space;

        public float top;

        public float sizey = 0;

        public float left;

        public float sizex = 0;

        [SerializeField]
        protected float MaxXY = 100;

        [SerializeField]
        protected bool isVertical = false;

        private int direct = 1;

        public virtual void AddGameObject(Transform Gobject, Vector2 size)
        {
            Gobject.SetParent(this.transform);
            Gobject.localScale = Vector3.one;

            Gobject.localPosition = new Vector3(
                    left + this.sizex + space.x,
                    top + this.sizey + space.y,
                    0
                    );
            if (isVertical)
            {
                if (this.sizey + direct * size.y >= MaxXY || this.sizey + direct * size.y < 0)
                {
                    this.sizex += size.x + space.x;
                    this.direct = -direct;
                }
                else
                {
                    this.sizey += direct * (size.y + space.y);

                }
            }
            else
            {

                if (this.sizex + direct * size.x >= MaxXY || this.sizex + direct * size.x < 0)
                {
                    this.sizey -= size.y + space.y;
                    this.direct = -direct;
                }
                else
                {
                    this.sizex += direct * (size.x + space.x);
                }
            }
        }

        public void ResetLocation(float x = 0, float y = 0)
        {
            sizey = y;
            sizex = x;
            direct = 1;
        }
    }
}
