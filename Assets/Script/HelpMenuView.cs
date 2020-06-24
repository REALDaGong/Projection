using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace MoleMole
{
    public class HelpMenuContext :BaseContext
    {
        public HelpMenuContext() : base(UIType.OptionMenu)
        {

        }
    }

    public class HelpMenuView : AnimateView
    {

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

        public void toggleBGM()
        {
            AudioSource audio = GameObject.FindGameObjectWithTag("BGMobject").GetComponent<AudioSource>();
            Text text = GameObject.Find("toggleBGM").GetComponent<Text>();
            if (audio.isPlaying == false)
            {
                audio.Play();
                text.text = "On";
            }
            else
            {
                audio.Stop();
                text.text = "Off";
            }
        }
    }
}

