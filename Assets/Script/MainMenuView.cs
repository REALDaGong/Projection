using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace MoleMole
{
    public class MainMenuContext : BaseContext
    {
        public MainMenuContext() : base(UIType.MainMenu)
        {

        }
    }

    public class MainMenuView : AnimateView
    {

        [SerializeField]
        private Button _buttonHighScore;
        [SerializeField]
        private Button _buttonOption;

        public override void OnEnter(BaseContext context)
        {
            base.OnEnter(context);
        }

        public override void OnExit(BaseContext context)
        {
            base.OnExit(context);
        }

        public override void OnPause(BaseContext context)
        {
            _animator.SetTrigger("OnExit");
        }

        public override void OnResume(BaseContext context)
        {
            _animator.SetTrigger("OnEnter");
        }

        public void HelpCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new HelpMenuContext());
        }

        public void HighScoreCallBack()
        {
            Singleton<ContextManager>.Instance.Push(new HighScoreContext());
        }

        public void StartCallBack()
        {
            GameObject.Find("LevelLoader").GetComponent<LevelLoader>().SwitchScene("Map01");
        }

        public void ExitCallBack()
        {
            Application.Quit();
        }
    }
}
