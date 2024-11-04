/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEngine.Events;

public class RewardedVideoButton : MonoBehaviour
{
	private const string ACTION_NAME = "rewarded_video";

	public UnityEvent onRewarded;

	private void OnEnable()
	{
		Timer.Schedule(this, 0.1f, AddEvents);
	}

	private void AddEvents()
	{
		
	}

	public void OnClick()
	{
		Toast.instance.ShowMessage("Ad is not available now, please wait..");
		Sound.instance.PlayButton();
	}

	public void HandleRewardBasedVideoRewarded(object sender)
	{
		onRewarded.Invoke();
	}

	public bool IsAdAvailable()
	{
		return false;
	}
}
