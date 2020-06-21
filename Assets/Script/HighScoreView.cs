using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MoleMole
{
    public class HighScoreContext : BaseContext
    {
        public HighScoreContext()
            : base(UIType.HighScore)
        {

        }
    }

    public class HighScoreView : AnimateView
    {
        public GridScroller _gridScroller;

        public override void OnEnter(BaseContext context)
        {
            base.OnEnter(context);
            _gridScroller.Init(OnChange, 5);
        }

        public override void OnExit(BaseContext context)
        {
            base.OnExit(context);
        }

        public override void OnPause(BaseContext context)
        {
            base.OnPause(context);
        }

        public override void OnResume(BaseContext context)
        {
            base.OnResume(context);
        }

        public void BackCallBack()
        {
            Singleton<ContextManager>.Instance.Pop();
        }

        public void OnChange(Transform trans, int index)
        {
            trans.GetComponent<HighScoreItem>().Init(index);
        }
    }
}
